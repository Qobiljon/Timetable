namespace Timetable
{
    partial class ProjectManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadBuilding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadSubjects = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadProfessors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buildingStatus = new System.Windows.Forms.Panel();
            this.subjectStatus = new System.Windows.Forms.Panel();
            this.professorStatus = new System.Windows.Forms.Panel();
            this.buttonCreateBuilding = new System.Windows.Forms.Button();
            this.buttonCreateSubject = new System.Windows.Forms.Button();
            this.buttonCreateProfessor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSaveProject = new System.Windows.Forms.Button();
            this.buttonLoadStudents = new System.Windows.Forms.Button();
            this.buttonCreateStudents = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.studentStatus = new System.Windows.Forms.Panel();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadBuilding
            // 
            this.buttonLoadBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonLoadBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadBuilding.FlatAppearance.BorderSize = 0;
            this.buttonLoadBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadBuilding.ForeColor = System.Drawing.Color.White;
            this.buttonLoadBuilding.Location = new System.Drawing.Point(157, 87);
            this.buttonLoadBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadBuilding.Name = "buttonLoadBuilding";
            this.buttonLoadBuilding.Size = new System.Drawing.Size(144, 28);
            this.buttonLoadBuilding.TabIndex = 0;
            this.buttonLoadBuilding.Text = "LOAD";
            this.buttonLoadBuilding.UseVisualStyleBackColor = false;
            this.buttonLoadBuilding.Click += new System.EventHandler(this.buttonLoadBuilding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Building";
            // 
            // buttonLoadSubjects
            // 
            this.buttonLoadSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonLoadSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadSubjects.Enabled = false;
            this.buttonLoadSubjects.FlatAppearance.BorderSize = 0;
            this.buttonLoadSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSubjects.ForeColor = System.Drawing.Color.White;
            this.buttonLoadSubjects.Location = new System.Drawing.Point(157, 123);
            this.buttonLoadSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadSubjects.Name = "buttonLoadSubjects";
            this.buttonLoadSubjects.Size = new System.Drawing.Size(144, 28);
            this.buttonLoadSubjects.TabIndex = 2;
            this.buttonLoadSubjects.Text = "LOAD";
            this.buttonLoadSubjects.UseVisualStyleBackColor = false;
            this.buttonLoadSubjects.Click += new System.EventHandler(this.buttonLoadSubjects_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subjects";
            // 
            // buttonLoadProfessors
            // 
            this.buttonLoadProfessors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonLoadProfessors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadProfessors.Enabled = false;
            this.buttonLoadProfessors.FlatAppearance.BorderSize = 0;
            this.buttonLoadProfessors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadProfessors.ForeColor = System.Drawing.Color.White;
            this.buttonLoadProfessors.Location = new System.Drawing.Point(157, 159);
            this.buttonLoadProfessors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadProfessors.Name = "buttonLoadProfessors";
            this.buttonLoadProfessors.Size = new System.Drawing.Size(144, 28);
            this.buttonLoadProfessors.TabIndex = 4;
            this.buttonLoadProfessors.Text = "LOAD";
            this.buttonLoadProfessors.UseVisualStyleBackColor = false;
            this.buttonLoadProfessors.Click += new System.EventHandler(this.buttonLoadProfessors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teachers";
            // 
            // buildingStatus
            // 
            this.buildingStatus.BackColor = System.Drawing.Color.Red;
            this.buildingStatus.Location = new System.Drawing.Point(16, 92);
            this.buildingStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buildingStatus.Name = "buildingStatus";
            this.buildingStatus.Size = new System.Drawing.Size(20, 18);
            this.buildingStatus.TabIndex = 2;
            // 
            // subjectStatus
            // 
            this.subjectStatus.BackColor = System.Drawing.Color.Red;
            this.subjectStatus.Location = new System.Drawing.Point(16, 128);
            this.subjectStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjectStatus.Name = "subjectStatus";
            this.subjectStatus.Size = new System.Drawing.Size(20, 18);
            this.subjectStatus.TabIndex = 2;
            // 
            // professorStatus
            // 
            this.professorStatus.BackColor = System.Drawing.Color.Red;
            this.professorStatus.Location = new System.Drawing.Point(16, 164);
            this.professorStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.professorStatus.Name = "professorStatus";
            this.professorStatus.Size = new System.Drawing.Size(20, 18);
            this.professorStatus.TabIndex = 2;
            // 
            // buttonCreateBuilding
            // 
            this.buttonCreateBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonCreateBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateBuilding.FlatAppearance.BorderSize = 0;
            this.buttonCreateBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateBuilding.ForeColor = System.Drawing.Color.White;
            this.buttonCreateBuilding.Location = new System.Drawing.Point(309, 87);
            this.buttonCreateBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateBuilding.Name = "buttonCreateBuilding";
            this.buttonCreateBuilding.Size = new System.Drawing.Size(144, 28);
            this.buttonCreateBuilding.TabIndex = 1;
            this.buttonCreateBuilding.Text = "CREATE";
            this.buttonCreateBuilding.UseVisualStyleBackColor = false;
            this.buttonCreateBuilding.Click += new System.EventHandler(this.buttonCreateBuilding_Click);
            // 
            // buttonCreateSubject
            // 
            this.buttonCreateSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonCreateSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateSubject.Enabled = false;
            this.buttonCreateSubject.FlatAppearance.BorderSize = 0;
            this.buttonCreateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateSubject.ForeColor = System.Drawing.Color.White;
            this.buttonCreateSubject.Location = new System.Drawing.Point(309, 123);
            this.buttonCreateSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateSubject.Name = "buttonCreateSubject";
            this.buttonCreateSubject.Size = new System.Drawing.Size(144, 28);
            this.buttonCreateSubject.TabIndex = 3;
            this.buttonCreateSubject.Text = "CREATE";
            this.buttonCreateSubject.UseVisualStyleBackColor = false;
            this.buttonCreateSubject.Click += new System.EventHandler(this.buttonCreateSubject_Click);
            // 
            // buttonCreateProfessor
            // 
            this.buttonCreateProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonCreateProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateProfessor.Enabled = false;
            this.buttonCreateProfessor.FlatAppearance.BorderSize = 0;
            this.buttonCreateProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProfessor.ForeColor = System.Drawing.Color.White;
            this.buttonCreateProfessor.Location = new System.Drawing.Point(309, 159);
            this.buttonCreateProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateProfessor.Name = "buttonCreateProfessor";
            this.buttonCreateProfessor.Size = new System.Drawing.Size(144, 28);
            this.buttonCreateProfessor.TabIndex = 5;
            this.buttonCreateProfessor.Text = "CREATE";
            this.buttonCreateProfessor.UseVisualStyleBackColor = false;
            this.buttonCreateProfessor.Click += new System.EventHandler(this.buttonCreateProfessor_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(8, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(29, 28);
            this.panel5.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(16, 346);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(437, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR HINTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "color means files loaded successfully";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "color means that files are not loaded";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Lime;
            this.panel6.Location = new System.Drawing.Point(8, 59);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 28);
            this.panel6.TabIndex = 2;
            // 
            // buttonSaveProject
            // 
            this.buttonSaveProject.BackColor = System.Drawing.Color.Red;
            this.buttonSaveProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveProject.Enabled = false;
            this.buttonSaveProject.FlatAppearance.BorderSize = 0;
            this.buttonSaveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveProject.Location = new System.Drawing.Point(16, 230);
            this.buttonSaveProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveProject.Name = "buttonSaveProject";
            this.buttonSaveProject.Size = new System.Drawing.Size(437, 68);
            this.buttonSaveProject.TabIndex = 9;
            this.buttonSaveProject.Text = "FINISH (Save Project)";
            this.buttonSaveProject.UseVisualStyleBackColor = false;
            this.buttonSaveProject.Click += new System.EventHandler(this.buttonSaveProject_Click);
            // 
            // buttonLoadStudents
            // 
            this.buttonLoadStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonLoadStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadStudents.Enabled = false;
            this.buttonLoadStudents.FlatAppearance.BorderSize = 0;
            this.buttonLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadStudents.ForeColor = System.Drawing.Color.White;
            this.buttonLoadStudents.Location = new System.Drawing.Point(157, 194);
            this.buttonLoadStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadStudents.Name = "buttonLoadStudents";
            this.buttonLoadStudents.Size = new System.Drawing.Size(144, 28);
            this.buttonLoadStudents.TabIndex = 6;
            this.buttonLoadStudents.Text = "LOAD";
            this.buttonLoadStudents.UseVisualStyleBackColor = false;
            this.buttonLoadStudents.Click += new System.EventHandler(this.buttonLoadStudents_Click);
            // 
            // buttonCreateStudents
            // 
            this.buttonCreateStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.buttonCreateStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateStudents.Enabled = false;
            this.buttonCreateStudents.FlatAppearance.BorderSize = 0;
            this.buttonCreateStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateStudents.ForeColor = System.Drawing.Color.White;
            this.buttonCreateStudents.Location = new System.Drawing.Point(309, 194);
            this.buttonCreateStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateStudents.Name = "buttonCreateStudents";
            this.buttonCreateStudents.Size = new System.Drawing.Size(144, 28);
            this.buttonCreateStudents.TabIndex = 7;
            this.buttonCreateStudents.Text = "CREATE";
            this.buttonCreateStudents.UseVisualStyleBackColor = false;
            this.buttonCreateStudents.Click += new System.EventHandler(this.buttonCreateStudents_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Students";
            // 
            // studentStatus
            // 
            this.studentStatus.BackColor = System.Drawing.Color.Red;
            this.studentStatus.Location = new System.Drawing.Point(16, 199);
            this.studentStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentStatus.Name = "studentStatus";
            this.studentStatus.Size = new System.Drawing.Size(20, 18);
            this.studentStatus.TabIndex = 2;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label7);
            this.panelToolBar.ForeColor = System.Drawing.Color.White;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(469, 62);
            this.panelToolBar.TabIndex = 10;
            this.panelToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.panelToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.panelToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(425, 4);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 37);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "x";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(173, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "New project";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 460);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.buttonSaveProject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentStatus);
            this.Controls.Add(this.professorStatus);
            this.Controls.Add(this.subjectStatus);
            this.Controls.Add(this.buildingStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateStudents);
            this.Controls.Add(this.buttonCreateProfessor);
            this.Controls.Add(this.buttonCreateSubject);
            this.Controls.Add(this.buttonLoadStudents);
            this.Controls.Add(this.buttonLoadProfessors);
            this.Controls.Add(this.buttonCreateBuilding);
            this.Controls.Add(this.buttonLoadSubjects);
            this.Controls.Add(this.buttonLoadBuilding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadProfessors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel buildingStatus;
        private System.Windows.Forms.Panel subjectStatus;
        private System.Windows.Forms.Panel professorStatus;
        private System.Windows.Forms.Button buttonCreateBuilding;
        private System.Windows.Forms.Button buttonCreateSubject;
        private System.Windows.Forms.Button buttonCreateProfessor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveProject;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLoadStudents;
        private System.Windows.Forms.Button buttonCreateStudents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel studentStatus;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExit;
    }
}