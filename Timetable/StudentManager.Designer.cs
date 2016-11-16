namespace Timetable
{
    partial class StudentManager
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
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.labelInstituteName = new System.Windows.Forms.Label();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonSaveStudent = new System.Windows.Forms.Button();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.studentIdText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(14, 399);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(402, 108);
            this.studentListBox.TabIndex = 9;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(14, 349);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(402, 31);
            this.buttonAddStudent.TabIndex = 8;
            this.buttonAddStudent.Text = "SAVE THIS AND ADD ANOTHER STUDENT";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(14, 218);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.subjectListBox.Size = new System.Drawing.Size(402, 121);
            this.subjectListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Subjects";
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(200, 150);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(215, 21);
            this.schoolComboBox.TabIndex = 5;
            this.schoolComboBox.SelectedIndexChanged += new System.EventHandler(this.schoolComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Current students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "School";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "First name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(75, 72);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(340, 20);
            this.firstNameText.TabIndex = 0;
            // 
            // labelInstituteName
            // 
            this.labelInstituteName.AutoSize = true;
            this.labelInstituteName.Location = new System.Drawing.Point(17, 50);
            this.labelInstituteName.Name = "labelInstituteName";
            this.labelInstituteName.Size = new System.Drawing.Size(50, 13);
            this.labelInstituteName.TabIndex = 54;
            this.labelInstituteName.Text = "Institute: ";
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.Orange;
            this.buttonCloseWindow.Location = new System.Drawing.Point(17, 526);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(152, 31);
            this.buttonCloseWindow.TabIndex = 11;
            this.buttonCloseWindow.Text = "CANCEL";
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonSaveStudent
            // 
            this.buttonSaveStudent.BackColor = System.Drawing.Color.Lime;
            this.buttonSaveStudent.Location = new System.Drawing.Point(175, 526);
            this.buttonSaveStudent.Name = "buttonSaveStudent";
            this.buttonSaveStudent.Size = new System.Drawing.Size(240, 31);
            this.buttonSaveStudent.TabIndex = 10;
            this.buttonSaveStudent.Text = "OK";
            this.buttonSaveStudent.UseVisualStyleBackColor = false;
            this.buttonSaveStudent.Click += new System.EventHandler(this.buttonSaveStudent_Click);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(75, 98);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(340, 20);
            this.lastNameText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Faculty";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(76, 177);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(339, 21);
            this.facultyComboBox.TabIndex = 6;
            this.facultyComboBox.SelectedIndexChanged += new System.EventHandler(this.facultyComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Year";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(75, 150);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(73, 21);
            this.yearComboBox.TabIndex = 4;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.schoolComboBox_SelectedIndexChanged);
            // 
            // studentIdText
            // 
            this.studentIdText.Location = new System.Drawing.Point(76, 124);
            this.studentIdText.Name = "studentIdText";
            this.studentIdText.Size = new System.Drawing.Size(340, 20);
            this.studentIdText.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Student Id";
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label9);
            this.panelToolBar.ForeColor = System.Drawing.Color.White;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(431, 40);
            this.panelToolBar.TabIndex = 61;
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
            this.buttonExit.Location = new System.Drawing.Point(398, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 63;
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
            this.label9.Location = new System.Drawing.Point(166, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "New student";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 569);
            this.ControlBox = false;
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentIdText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.labelInstituteName);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.buttonSaveStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentManager";
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label labelInstituteName;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonSaveStudent;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.TextBox studentIdText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label9;
    }
}