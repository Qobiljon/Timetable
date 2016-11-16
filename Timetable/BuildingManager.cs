using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class BuildingManager : Form
    {
        public BuildingManager()
        {
            InitializeComponent();

            periodComboBox.SelectedItem = periodComboBox.Items[0];
            startHour.SelectedItem = startHour.Items[startHour.Items.Count - 1];
            startMinute.SelectedItem = startMinute.Items[startMinute.Items.Count - 1];
            finishHour.SelectedItem = finishHour.Items[0];
            finishMinute.SelectedItem = finishMinute.Items[0];
        }
        
        #region Variables
        public static List<NameValuePair<string>> tempSchools = new List<NameValuePair<string>>();
        public static List<NameValuePair<Faculty>> tempFaculties = new List<NameValuePair<Faculty>>();
        public static List<NameValuePair<Room>> tempFacilities = new List<NameValuePair<Room>>();
        public static string[] rows, columns = new string[]{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        public static string[] schools;
        public static Faculty[] faculties;
        public static Room[] facilities;
        public static int years = 1, periodLength, periodCount;
        public static int standardLessonDuration;
        public static string buildingName;
        public static int height; // the standard length of subject taught
        public string filePath;
        public static bool contiguous;

        private string[] durationElems = new string[]{ "180 Minutes", "150 Minutes", "120 Minutes", "90 Minutes", "60 Minutes", "45 Minutes", "30 Minutes" };
        #endregion

        private bool asked = false;
        private void buttonAddFacility_Click(object sender, EventArgs e)
        {
            if (periodComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, first set the PERIOD!", "ERROR");
                return;
            }
            else
                years = yearTrackBar.Value;

            // set up rows and columns for a table manager
            int st = int.Parse(startHour.Text) * 60 + int.Parse(startMinute.Text);
            int fn = int.Parse(finishHour.Text) * 60 + int.Parse(finishMinute.Text);
            if (st >= fn)
            {
                MessageBox.Show("Wrong time input, please recheck!");
                return;
            }
            periodLength = int.Parse(Regex.Match(periodComboBox.Text, "[0-9]+").Value);
            periodCount = (int)Math.Ceiling((double)(fn - st) / periodLength);
            standardLessonDuration = int.Parse(Regex.Match(durationComboBox.Text, "[0-9]+").Value);
            height = (int)Math.Ceiling((double)standardLessonDuration / periodLength);
            rows = new string[periodCount];
            for (int n = 0, temp; n < periodCount; n++)
            {
                temp = st + n * periodLength;
                rows[n] = (temp / 60).ToString("00") + ":" + (temp % 60).ToString("00") + "-" + ((temp + periodLength) / 60).ToString("00") + ":" + ((temp + periodLength) % 60).ToString("00");
            }


            for(int scl = 0; scl < tempSchools.Count; scl++)
                if (!asked && MessageBox.Show(this, "Are all roooms in the building of same capacity?", "Facilities set-up", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int minSize = Tools.getIntFromString(Microsoft.VisualBasic.Interaction.InputBox("How many students fit in those classes?", "Facilities set-up", "30"));
                    int count = Tools.getIntFromString(Microsoft.VisualBasic.Interaction.InputBox("How many rooms are there for teaching subjects?", "Facilities set-up", "0"));
                    while (count == 0)
                    {
                        MessageBox.Show("No building has no rooms inside! Please recheck your input!", "Error");
                        count = Tools.getIntFromString(Microsoft.VisualBasic.Interaction.InputBox("How many rooms are there for teaching subjects?", "0"));
                    }

                    string roomName;
                    for (int n = 1; n <= count; n++)
                    {
                        roomName = "Room: " + n;
                        tempFacilities.Add(new NameValuePair<Room>(roomName, new Room(roomName, "Room", tempSchools[scl].Name, minSize, 100, new Table(roomName, BuildingManager.columns, BuildingManager.rows))));
                        facilityListBox.Items.Add(tempFacilities[tempFacilities.Count - 1].Name);
                    }
                }
                else
                {
                    FacilityManager form = new FacilityManager();
                    Opacity = 0.3;
                    form.ShowDialog(this);
                    Opacity = 1;
                    if (form.facilityItem != null)
                    {
                        // check if new item name already typed in
                        foreach (string item in facilityListBox.Items)
                            if (item.Equals(form.facilityItem.Name))
                            {
                                MessageBox.Show("This facility has already been entered!");
                                return;
                            }
                        tempFacilities.Add(form.facilityItem);
                        facilityListBox.Items.Add(tempFacilities[tempFacilities.Count - 1].Name);
                    }
                }
            asked = true;
        }

        private void buttonClearFacility_Click(object sender, EventArgs e)
        {
            foreach (int n in facilityListBox.SelectedIndices)
            {
                tempFacilities.RemoveAt(n);
                facilityListBox.Items.RemoveAt(n);
            }
        }

        private void buttonSaveBuilding_Click(object sender, EventArgs e)
        {
            if (nameText.Text.Equals(""))
                MessageBox.Show("Please input the name of the institute first!");
            else
            {
                SaveFileDialog form = new SaveFileDialog();
                form.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                form.Filter = "Institute file|*.intf";
                if(form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = form.FileName;
                    if (!fileName.EndsWith(".intf"))
                        fileName += ".intf";

                    try
                    {
                        schools = new string[tempSchools.Count];
                        for (int n = 0; n < tempSchools.Count; n++)
                            schools[n] = tempSchools[n].Value;
                        faculties = new Faculty[tempFaculties.Count];
                        for (int n = 0; n < tempFaculties.Count; n++)
                            faculties[n] = tempFaculties[n].Value;
                        facilities = new Room[tempFacilities.Count];
                        for (int n = 0; n < tempFacilities.Count; n++)
                            facilities[n] = tempFacilities[n].Value;

                        Tools.building = new Building(buildingName = nameText.Text, years, periodCount, periodLength, height, standardLessonDuration, contiguous = contiguousCheckBox.Checked, rows, columns, schools, faculties, facilities);

                        Tools.writeToFile(fileName, Tools.building.toString(), false);
                        filePath = fileName;
                    }
                    catch
                    {
                        MessageBox.Show("Close all apps using the file before saving!", "Eror writing to a file");
                        return;
                    }

                    MessageBox.Show("Institute file has been saved as:" + Environment.NewLine + form.FileName, "Successful");
                    Close();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddSchool_Click(object sender, EventArgs e)
        {
            if (schoolText.Text.Length > 1)
            {
                foreach(object item in schoolListBox.Items)
                    if (item.Equals(schoolText.Text))
                    {
                        MessageBox.Show("It is already in the list!");
                        return;
                    }
                tempSchools.Add(new NameValuePair<string>(schoolText.Text, schoolText.Text));
                schoolListBox.Items.Add(tempSchools[tempSchools.Count - 1].Name);
                schoolText.Clear();
            }
            else MessageBox.Show("School name must contain at least two letters!");

            schoolText.Clear();
            schoolText.Focus();
        }

        private void buttonClearSchool_Click(object sender, EventArgs e)
        {
            foreach (int n in schoolListBox.SelectedIndices)
            {
                tempSchools.RemoveAt(n);
                schoolListBox.Items.RemoveAt(n);
            }
        }

        private void yearTrackBar_Scroll(object sender, EventArgs e)
        {
            yearLabel.Text = "Years of study: " + yearTrackBar.Value;
            years = yearTrackBar.Value;
        }

        private void buttonAddFaculty_Click(object sender, EventArgs e)
        {
            FacultyManager form = new FacultyManager();
            Opacity = 0.3;
            form.ShowDialog(this);
            Opacity = 1;
            if (form.facultyItem != null)
            {
                // check if new item name already typed in
                foreach (string item in facultyListBox.Items)
                    if (item.Equals(form.facultyItem.Name))
                    {
                        MessageBox.Show("This facility has already been entered!");
                        return;
                    }
                // add the item to the collection here
                tempFaculties.Add(form.facultyItem);
                facultyListBox.Items.Add(tempFaculties[tempFaculties.Count - 1].Name);
            }
        }

        private void buttonClearFaculty_Click(object sender, EventArgs e)
        {
            foreach(int n in facultyListBox.SelectedIndices)
            {
                tempFaculties.RemoveAt(n);
                facultyListBox.Items.RemoveAt(n);
            }
        }

        private void schoolText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAddSchool.PerformClick();
        }

        private void facultyText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAddFacility.PerformClick();
        }

        private void buttonDefaultWeekdays_Click(object sender, EventArgs e)
        {
            columns = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        }

        private void buttonSetColumns_Click(object sender, EventArgs e)
        {
            bool again = true;
            string str;
            List<string> data = null;

            try
            {
                while (again)
                {
                    str = Microsoft.VisualBasic.Interaction.InputBox("Please enter names of week days (your preference) consecutively after a comma:", "Enter weekdays", "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday");
                    data = new List<string>(str.Replace(" ", "").Split(','));
                    for (int n = 0; n < data.Count; n++)
                    {
                        data[n] = Regex.Match(data[n], "[0-9A-Za-z]+").Value;
                        if (data[n].Equals(""))
                            data.RemoveAt(n--);
                    }
                    if (data.Count > 6 || data.Count == 0)
                    {
                        MessageBox.Show("Maximum number of days that can be used in institutes is 6, and divs[year]imum is 1", "Please revise your input");
                        again = true;
                    }
                    else again = false;
                }

                columns = data.ToArray();
            }
            catch
            {
                buttonDefaultWeekdays.PerformClick();
                MessageBox.Show("Default weekdays (Mon-Fri) are chosen because input is incorrect, or insufficient!", "Note");
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

        private void periodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durationComboBox.Items.Clear();

            int len = Tools.getIntFromString(periodComboBox.SelectedItem.ToString());

            foreach (string data in durationElems)
            {
                if (Tools.getIntFromString(data) % len == 0)
                    durationComboBox.Items.Add(data);
            }

            if (durationComboBox.Items.Count > 0)
                durationComboBox.SelectedItem = durationComboBox.Items[0];
        }
    }
}
