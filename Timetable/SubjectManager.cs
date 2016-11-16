using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class SubjectManager : Form
    {
        public SubjectManager(bool useAllRooms)
        {
            InitializeComponent();

            labelInstituteName.Text += Tools.building.Name;
            this.useAllRooms = useAllRooms;
            if (useAllRooms)
                panelFacilities.Visible = false;

            foreach (string sc in Tools.building.Schools)
                schoolComboBox.Items.Add(sc);

            for (int n = 0; n < Tools.building.Years; n++)
                yearComboBox.Items.Add(n + 1);

            yearComboBox.SelectedItem = yearComboBox.Items[0];

            for (int minutes = Tools.building.PeriodLength; minutes < 420; minutes += Tools.building.PeriodLength)
                hoursComboBox.Items.Add(Tools.getTimeFromMinutes(minutes));
            hoursComboBox.SelectedItem = hoursComboBox.Items[0];
        }

        #region Variables
        private List<Subject> subjects = new List<Subject>();
        public string[] filePaths;
        private bool useAllRooms;
        #endregion

        private void buttonSaveSubject_Click(object sender, EventArgs e)
        {
            if (subjects.Count == 0)
                MessageBox.Show("Please add at least one subject to save!");
            else
            {
                FolderBrowserDialog form = new FolderBrowserDialog();
                form.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string path = form.SelectedPath;
                    try
                    {
                        filePaths = new string[subjects.Count];
                        for (int n = 0; n < subjects.Count; n++)
                        {
                            filePaths[n] = path + '\\' + subjects[n].Name + ".sutf";
                            Tools.writeToFile(filePaths[n], subjects[n].toString(), false);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Close all apps using the files in folder, and try again!", "Eror writing to a file");
                        return;
                    }

                    MessageBox.Show("Files have been saved in:" + Environment.NewLine + path, "Successful");
                    Close();
                }
            }
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void schoolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            facultyListBox.Items.Clear();
            facilityListBox.Items.Clear();

            for (int n = 0; n < Tools.building.Years; n++)
                yearComboBox.Items[n] = n + 1;

            foreach (Faculty fc in Tools.building.Faculties)
                if (fc.School.Equals((string)schoolComboBox.SelectedItem))
                    facultyListBox.Items.Add(fc.Name);

            foreach (Room rm in Tools.building.Facilities)
                if (rm.School.Equals((string)schoolComboBox.SelectedItem))
                    facilityListBox.Items.Add(rm.Name + " (" + rm.Type + ", " + rm.AllowCapacity + "/" + rm.FullCapacity + ") ");
        }

        private void facultyListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(!useAllRooms)
                for (int n = 0, count = 0; n < Tools.building.Years; n++, count = 0)
                {
                    foreach (string item in facultyListBox.SelectedItems)
                        count += Faculty.find<Faculty>(item).Students[n];

                    yearComboBox.Items[n] = n + 1 + "    (" + count + " students)";
                }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            string temp = (string)yearComboBox.SelectedItem;

            string name = nameText.Text;
            string school = (string)schoolComboBox.SelectedItem;
            int year = int.Parse(temp.Substring(0, temp.IndexOf(' ')));
            Color legend = buttonLegend.BackColor;

            Room[] facilities;
            Faculty[] faculties;
            if (useAllRooms)
            {
                facilities = Tools.building.Facilities;
                faculties = Tools.building.Faculties;
            }
            else
            {
                facilities = new Room[facilityListBox.SelectedItems.Count];
                for (int n = 0; n < facilities.Length; n++)
                {
                    temp = (string)facilityListBox.SelectedItems[n];
                    facilities[n] = Room.find<Room>(temp.Substring(0, temp.IndexOf(' ')));
                }

                faculties = new Faculty[facultyListBox.SelectedItems.Count];
                for (int n = 0; n < faculties.Length; n++)
                {
                    temp = (string)facultyListBox.SelectedItems[n];
                    faculties[n] = Faculty.find<Faculty>(temp);
                }
            }

            int minutesPerWeek = Tools.getMinutesFromString(hoursComboBox.SelectedItem.ToString());

            subjects.Add(new Subject(name, school, year, minutesPerWeek, legend, facilities, faculties));
            subjectListBox.Items.Add(name);
            clearFields();
            nameText.Focus();
        }

        private void clearFields()
        {
            nameText.Clear();
            for (int n = 0; n < yearComboBox.Items.Count; n++)
                yearComboBox.Items[n] = n + 1;
            facilityListBox.Items.Clear();
            facultyListBox.Items.Clear();
            hoursComboBox.SelectedItem = hoursComboBox.Items[0];
            yearComboBox.SelectedItem = yearComboBox.Items[0];
            schoolComboBox.SelectedIndex = 0;
            schoolComboBox_SelectedIndexChanged(schoolComboBox, null);
        }

        private void buttonLegend_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonLegend.BackColor = colorDialog.Color;
            }
        }

        private Point delta;
        private bool move = false;
        private void moveYes(object sender, MouseEventArgs e)
        {
            delta = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            move = true;
            panelToolBar.Cursor = Cursors.SizeAll;
        }

        private void moveNo(object sender, MouseEventArgs e)
        {
            move = false;
            panelToolBar.Cursor = Cursors.Default;
        }

        private void moveDo(object sender, MouseEventArgs e)
        {
            if (move)
                Location = new Point(Cursor.Position.X - delta.X, Cursor.Position.Y - delta.Y);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
