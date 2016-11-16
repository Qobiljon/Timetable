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
    public partial class ProjectManager : Form
    {
        public ProjectManager()
        {
            InitializeComponent();
        }

        #region Project Variables
        private string buildingFile;
        public string projectFile;
        private string[] subjectFiles = new string[0];
        private string[] professorFiles = new string[0];
        private string[] studentFiles = new string[0];
        #endregion

        private void buttonCreateBuilding_Click(object sender, EventArgs e)
        {
            buttonSaveProject.BackColor = buildingStatus.BackColor = subjectStatus.BackColor = professorStatus.BackColor = studentStatus.BackColor = Color.Red;
            buttonLoadSubjects.Enabled = buttonCreateSubject.Enabled = buttonLoadProfessors.Enabled = buttonCreateProfessor.Enabled =
                buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = buttonSaveProject.Enabled = false;

            BuildingManager form = new BuildingManager();
            Opacity = 0.3;
            form.ShowDialog(this);
            Opacity = 1;
            if (form.filePath != null)
                loadBuilding(form.filePath);
        }

        private void buttonCreateSubject_Click(object sender, EventArgs e)
        {
            buttonSaveProject.BackColor = subjectStatus.BackColor = professorStatus.BackColor = studentStatus.BackColor = Color.Red;
            buttonLoadProfessors.Enabled = buttonCreateProfessor.Enabled =
                buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = buttonSaveProject.Enabled = false;
            SubjectManager form = new SubjectManager(MessageBox.Show(this, "Are all subjects taught in every room?", "Subjects set-up", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
            Opacity = 0.3;
            form.ShowDialog(this);
            Opacity = 1;

            if (form.filePaths != null)
                loadSubjects(form.filePaths.ToArray());
        }

        private void buttonCreateProfessor_Click(object sender, EventArgs e)
        {
            buttonSaveProject.BackColor = professorStatus.BackColor = studentStatus.BackColor = Color.Red;
            buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = buttonSaveProject.Enabled = false;

            TeacherManager form = new TeacherManager();
            Opacity = 0.3;
            form.ShowDialog(this);
            Opacity = 1;

            if (form.filePaths != null)
                loadProfessors(form.filePaths.ToArray());
        }

        private void buttonCreateStudents_Click(object sender, EventArgs e)
        {
            StudentManager form = new StudentManager();
            Opacity = 0.3;
            form.ShowDialog(this);
            Opacity = 1;

            if (form.filePaths != null)
                loadStudents(form.filePaths);
        }

        private void buttonLoadBuilding_Click(object sender, EventArgs e)
        {
            buttonSaveProject.BackColor = buildingStatus.BackColor = subjectStatus.BackColor = professorStatus.BackColor = studentStatus.BackColor = Color.Red;
            buttonLoadSubjects.Enabled = buttonCreateSubject.Enabled = buttonLoadProfessors.Enabled = buttonCreateProfessor.Enabled =
                buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = buttonSaveProject.Enabled = false;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dialog.Filter = "Institute file|*.intf";
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                loadBuilding(dialog.FileName);
        }

        private void buttonLoadSubjects_Click(object sender, EventArgs e)
        {
            buttonSaveProject.BackColor = subjectStatus.BackColor = professorStatus.BackColor = studentStatus.BackColor = Color.Red;
            buttonLoadProfessors.Enabled = buttonCreateProfessor.Enabled = 
                buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = buttonSaveProject.Enabled = false;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dialog.Filter = "Subject file(s)|*.sutf";
            dialog.Multiselect = true;
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                loadSubjects(dialog.FileNames);
        }

        private void buttonLoadProfessors_Click(object sender, EventArgs e)
        {
            buttonSaveProject.BackColor = professorStatus.BackColor = studentStatus.BackColor = Color.Red;
            buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = buttonSaveProject.Enabled = false;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dialog.Filter = "Teacher file(s)|*.tetf";
            dialog.Multiselect = true;
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                loadProfessors(dialog.FileNames);
        }

        private void buttonLoadStudents_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dialog.Filter = "Student file|*.sttf";
            dialog.Multiselect = true;
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                loadStudents(dialog.FileNames);
        }



        private void loadBuilding(string filePath)
        {
            MainForm.loadBuilding(filePath);

            buildingFile = filePath;
            buildingStatus.BackColor = Color.Lime;
            buttonLoadSubjects.Enabled = buttonCreateSubject.Enabled = true;
        }

        private void loadSubjects(string[] filePaths)
        {
            MainForm.loadSubjects(filePaths);

            subjectFiles = filePaths;
            subjectStatus.BackColor = Color.Lime;
            buttonLoadProfessors.Enabled = buttonCreateProfessor.Enabled = true;
        }

        private void loadProfessors(string[] filePaths)
        {
            MainForm.loadProfessors(filePaths);

            professorFiles = filePaths;
            buttonSaveProject.BackColor = professorStatus.BackColor = Color.Lime;
            buttonSaveProject.Enabled = buttonLoadStudents.Enabled = buttonCreateStudents.Enabled = true;
        }

        private void loadStudents(string[] filePaths)
        {
            MainForm.loadStudents(filePaths);

            studentFiles = filePaths;
            studentStatus.BackColor = Color.Lime;
        }



        private void buttonSaveProject_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Project File|*.prtf";
            if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string data = Tools.concat(Tools.delimiter_rep2,
                    buildingFile,
                    Tools.concat(Tools.delimiter, subjectFiles),
                    Tools.concat(Tools.delimiter, professorFiles),
                    Tools.concat(Tools.delimiter, studentFiles));

                Tools.writeToFile(dialog.FileName, data, false);
                projectFile = dialog.FileName;

                MessageBox.Show("The project has been saved successfully!", "Saved successfully");
                Close();
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
