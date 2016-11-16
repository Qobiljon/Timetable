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
    public partial class FacultyManager : Form
    {
        public FacultyManager()
        {
            InitializeComponent();

            foreach (NameValuePair<string> str in BuildingManager.tempSchools)
                schoolComboBox.Items.Add(str.Name);
            schoolComboBox.SelectedItem = schoolComboBox.Items[0];
        }

        public NameValuePair<Faculty> facultyItem;
        private List<int> studentCount = new List<int>();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (nameText.Text.Equals("") || schoolComboBox.Text.Equals("") || studentCount.Count == 0)
                MessageBox.Show("Please fill the blank fields first!");
            else
            {
                facultyItem = new NameValuePair<Faculty>(nameText.Text, new Faculty(nameText.Text, schoolComboBox.Text, studentCount));
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (studentCount.Count == BuildingManager.years)
            {
                MessageBox.Show("Data has already been entered!");
                return;
            }

            for (int n = 1;  n <= BuildingManager.years; n++)
            {
                try
                {
                    Opacity = 0.3;
                    studentCount.Add(int.Parse(Regex.Match(Microsoft.VisualBasic.Interaction.InputBox("How many students of Academic Year " + n + " are there on this Faculty?", "Enter a number", "0"), "[0-9]+").Value));
                    Opacity = 1;
                }
                catch
                {
                    n--;
                    Opacity = 1;
                }
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
