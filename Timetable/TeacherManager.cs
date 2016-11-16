using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class TeacherManager : Form
    {
        public TeacherManager()
        {
            InitializeComponent();

            labelInstituteName.Text += Tools.building.Name;

            foreach (string sc in Tools.building.Schools)
                schoolComboBox.Items.Add(sc);

            timePreferenceComboBox.Items.Add(Teacher.ANYTIME);
            timePreferenceComboBox.Items.Add(Teacher.MORNING);
            timePreferenceComboBox.Items.Add(Teacher.NOON);
            timePreferenceComboBox.Items.Add(Teacher.EVENING);
            timePreferenceComboBox.SelectedItem = timePreferenceComboBox.Items[0];

            hoursComboBox.SelectedItem = hoursComboBox.Items[0];
        }

        #region Variables
        private List<Teacher> teachers = new List<Teacher>();
        public string[] filePaths;
        private Table timetable;
        #endregion

        private void buttonSaveProfessor_Click(object sender, EventArgs e)
        {
            if (teachers.Count == 0)
                MessageBox.Show("Please add at least one professor to save!");
            else
            {
                FolderBrowserDialog form = new FolderBrowserDialog();
                form.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string path = form.SelectedPath;
                    try
                    {
                        filePaths = new string[teachers.Count];
                        for (int n = 0; n < teachers.Count; n++)
                        {
                            filePaths[n] = path + '\\' + teachers[n].Name + ".tetf";
                            Tools.writeToFile(filePaths[n], teachers[n].toString(), false);
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
            subjectListBox.Items.Clear();

            foreach (Faculty fc in Tools.building.Faculties)
                if (fc.School.Equals((string)schoolComboBox.SelectedItem))
                    facultyListBox.Items.Add(fc.Name);

            foreach (Subject sb in Tools.subjects)
                if (sb.School.Equals((string)schoolComboBox.SelectedItem))
                    subjectListBox.Items.Add(sb.Name);
        }

        private void facultyListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            subjectListBox.Items.Clear();
            bool add;

            foreach(string item in facultyListBox.SelectedItems)
                foreach(Subject sb in Tools.subjects)
                    foreach (Faculty fc in sb.Faculties)
                        if (fc.Name.Equals(item))
                        {
                            add = true;

                            foreach (string subj in subjectListBox.Items)
                                if (subj.Equals(sb.Name))
                                {
                                    add = false;
                                    break;
                                }

                            if(add)
                                subjectListBox.Items.Add(sb.Name);
                            break;
                        }
        }

        private void buttonAddProfessor_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            Faculty[] faculties = new Faculty[facultyListBox.SelectedItems.Count];
            for (int n = 0; n < faculties.Length; n++)
                faculties[n] = Base.find<Faculty>((string)facultyListBox.SelectedItems[n]);
            Subject[] subjects = new Subject[subjectListBox.SelectedItems.Count];
            for (int n = 0; n < subjects.Length; n++)
                subjects[n] = Base.find<Subject>((string)subjectListBox.SelectedItems[n]);
            int hoursPerDay = int.Parse(Regex.Match((string)hoursComboBox.SelectedItem, "[0-9]+").Value);

            if(freeRadioButton.Checked)
                timetable = new Table(name, Tools.building.Columns, Tools.building.Rows);

            teachers.Add(new Teacher(name, (string)schoolComboBox.SelectedItem, (string)timePreferenceComboBox.SelectedItem, faculties, subjects, hoursPerDay, timetable));
            teacherListBox.Items.Add(name);

            clearFields();
            nameText.Focus();
        }

        private void clearFields()
        {
            nameText.Clear();
            facultyListBox.Items.Clear();
            subjectListBox.Items.Clear();
            hoursComboBox.SelectedItem = hoursComboBox.Items[0];
            timePreferenceComboBox.SelectedItem = timePreferenceComboBox.Items[0];
            schoolComboBox.SelectedIndex = 0;
            schoolComboBox_SelectedIndexChanged(schoolComboBox, null);
            timeRadioButton.Checked = !(freeRadioButton.Checked = true);
        }

        private void timeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (timeRadioButton.Checked)
            {
                TimeManager form = new TimeManager(nameText.Text, "teacher");
                Opacity = 0.3;
                form.ShowDialog(this);
                Opacity = 1;

                if (form.timetable == null)
                    freeRadioButton.Checked = !(timeRadioButton.Checked = false);
                else
                    timetable = form.timetable;
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
