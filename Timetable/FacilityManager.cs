using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Timetable
{
    public partial class FacilityManager : Form
    {
        public FacilityManager()
        {
            InitializeComponent();

            foreach (NameValuePair<string> str in BuildingManager.tempSchools)
                schoolComboBox.Items.Add(str.Name);
        }

        public NameValuePair<Room> facilityItem;
        private Table timetable;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (nameText.Text.Equals("") || typeText.Text.Equals("") || capacityText.Text.Equals("") || schoolComboBox.Text.Equals(""))
                MessageBox.Show("Please fill the blank fields first!");
            else {
                if(!timeRadioButton.Checked)
                    timetable = new Table(nameText.Text, BuildingManager.columns, BuildingManager.rows);

                facilityItem = new NameValuePair<Room>(nameText.Text, 
                    new Room(nameText.Text,
                        typeText.Text, 
                        schoolComboBox.Text, 
                        int.Parse(capacityText.Text), 
                        int.Parse(Regex.Match(capacityPercentageLabel.Text, "[0-9]+").Value),
                        timetable));
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (timeRadioButton.Checked)
            {
                TimeManager form = new TimeManager(nameText.Text, typeText.Text);
                Opacity = 0.3;
                form.ShowDialog(this);
                Opacity = 1;

                if (form.timetable == null)
                    freeRadioButton.Checked = !(timeRadioButton.Checked = false);
                else
                    timetable = form.timetable;
            }
        }

        private void capacityText_TextChanged(object sender, EventArgs e)
        {
            string res = "";
            foreach (Match mt in Regex.Matches(capacityText.Text, "[0-9]+"))
                res += mt.Value;
            capacityText.Text = res;
            capacityText.SelectionStart = capacityText.Text.Length;
        }

        private void allowCapacityTrackBar_Scroll(object sender, EventArgs e)
        {
            capacityPercentageLabel.Text = String.Format("{0}%", allowCapacityTrackBar.Value * 100 / allowCapacityTrackBar.Maximum);
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
