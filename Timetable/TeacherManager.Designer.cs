namespace Timetable
{
    partial class TeacherManager
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
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.labelInstituteName = new System.Windows.Forms.Label();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonSaveSubject = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timePreferenceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hoursComboBox = new System.Windows.Forms.ComboBox();
            this.freeRadioButton = new System.Windows.Forms.RadioButton();
            this.timeRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.Location = new System.Drawing.Point(12, 406);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(395, 108);
            this.teacherListBox.TabIndex = 8;
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Location = new System.Drawing.Point(15, 347);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(395, 31);
            this.buttonAddTeacher.TabIndex = 7;
            this.buttonAddTeacher.Text = "SAVE THIS AND ADD ANOTHER TEACHER";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddProfessor_Click);
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(225, 143);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.subjectListBox.Size = new System.Drawing.Size(185, 121);
            this.subjectListBox.TabIndex = 3;
            // 
            // facultyListBox
            // 
            this.facultyListBox.FormattingEnabled = true;
            this.facultyListBox.Location = new System.Drawing.Point(15, 143);
            this.facultyListBox.Name = "facultyListBox";
            this.facultyListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.facultyListBox.Size = new System.Drawing.Size(185, 121);
            this.facultyListBox.TabIndex = 2;
            this.facultyListBox.SelectedIndexChanged += new System.EventHandler(this.facultyListBox_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Subjects";
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(59, 97);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(351, 21);
            this.schoolComboBox.TabIndex = 1;
            this.schoolComboBox.SelectedIndexChanged += new System.EventHandler(this.schoolComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Current teachers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Faculties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "School";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(59, 71);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(351, 20);
            this.nameText.TabIndex = 0;
            // 
            // labelInstituteName
            // 
            this.labelInstituteName.AutoSize = true;
            this.labelInstituteName.Location = new System.Drawing.Point(12, 49);
            this.labelInstituteName.Name = "labelInstituteName";
            this.labelInstituteName.Size = new System.Drawing.Size(50, 13);
            this.labelInstituteName.TabIndex = 24;
            this.labelInstituteName.Text = "Institute: ";
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.Orange;
            this.buttonCloseWindow.Location = new System.Drawing.Point(12, 526);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(152, 31);
            this.buttonCloseWindow.TabIndex = 10;
            this.buttonCloseWindow.Text = "CANCEL";
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonSaveSubject
            // 
            this.buttonSaveSubject.BackColor = System.Drawing.Color.Lime;
            this.buttonSaveSubject.Location = new System.Drawing.Point(170, 526);
            this.buttonSaveSubject.Name = "buttonSaveSubject";
            this.buttonSaveSubject.Size = new System.Drawing.Size(240, 31);
            this.buttonSaveSubject.TabIndex = 9;
            this.buttonSaveSubject.Text = "OK";
            this.buttonSaveSubject.UseVisualStyleBackColor = false;
            this.buttonSaveSubject.Click += new System.EventHandler(this.buttonSaveProfessor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Teacher prefers to teach sometime around: ";
            // 
            // timePreferenceComboBox
            // 
            this.timePreferenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timePreferenceComboBox.FormattingEnabled = true;
            this.timePreferenceComboBox.Location = new System.Drawing.Point(231, 270);
            this.timePreferenceComboBox.Name = "timePreferenceComboBox";
            this.timePreferenceComboBox.Size = new System.Drawing.Size(179, 21);
            this.timePreferenceComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Indicate how long this professor can teach in one day";
            // 
            // hoursComboBox
            // 
            this.hoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursComboBox.FormattingEnabled = true;
            this.hoursComboBox.Items.AddRange(new object[] {
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours",
            "9 hours",
            "10 hours",
            "11 hours",
            "12 hours"});
            this.hoursComboBox.Location = new System.Drawing.Point(276, 297);
            this.hoursComboBox.Name = "hoursComboBox";
            this.hoursComboBox.Size = new System.Drawing.Size(134, 21);
            this.hoursComboBox.TabIndex = 5;
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Checked = true;
            this.freeRadioButton.Location = new System.Drawing.Point(132, 324);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.freeRadioButton.TabIndex = 6;
            this.freeRadioButton.TabStop = true;
            this.freeRadioButton.Text = "Always free";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeRadioButton
            // 
            this.timeRadioButton.AutoSize = true;
            this.timeRadioButton.Location = new System.Drawing.Point(217, 324);
            this.timeRadioButton.Name = "timeRadioButton";
            this.timeRadioButton.Size = new System.Drawing.Size(93, 17);
            this.timeRadioButton.TabIndex = 6;
            this.timeRadioButton.Text = "Set up time off";
            this.timeRadioButton.UseVisualStyleBackColor = true;
            this.timeRadioButton.CheckedChanged += new System.EventHandler(this.timeRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Availability";
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
            this.buttonExit.Location = new System.Drawing.Point(393, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "x";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(164, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "New teacher";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label9);
            this.panelToolBar.ForeColor = System.Drawing.Color.White;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(426, 40);
            this.panelToolBar.TabIndex = 42;
            this.panelToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.panelToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.panelToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // TeacherManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 569);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.freeRadioButton);
            this.Controls.Add(this.timeRadioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.hoursComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.facultyListBox);
            this.Controls.Add(this.timePreferenceComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelInstituteName);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.buttonSaveSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Teacher";
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label labelInstituteName;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonSaveSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox timePreferenceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hoursComboBox;
        private System.Windows.Forms.RadioButton freeRadioButton;
        private System.Windows.Forms.RadioButton timeRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelToolBar;
    }
}