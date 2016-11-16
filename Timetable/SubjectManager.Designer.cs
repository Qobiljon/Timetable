namespace Timetable
{
    partial class SubjectManager
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
            this.buttonSaveSubject = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.labelInstituteName = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.facilityListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hoursComboBox = new System.Windows.Forms.ComboBox();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonLegend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelFacilities = new System.Windows.Forms.Panel();
            this.panelToolBar.SuspendLayout();
            this.panelFacilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveSubject
            // 
            this.buttonSaveSubject.BackColor = System.Drawing.Color.Lime;
            this.buttonSaveSubject.Location = new System.Drawing.Point(170, 544);
            this.buttonSaveSubject.Name = "buttonSaveSubject";
            this.buttonSaveSubject.Size = new System.Drawing.Size(240, 31);
            this.buttonSaveSubject.TabIndex = 20;
            this.buttonSaveSubject.Text = "OK";
            this.buttonSaveSubject.UseVisualStyleBackColor = false;
            this.buttonSaveSubject.Click += new System.EventHandler(this.buttonSaveSubject_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.Orange;
            this.buttonCloseWindow.Location = new System.Drawing.Point(12, 544);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(152, 31);
            this.buttonCloseWindow.TabIndex = 21;
            this.buttonCloseWindow.Text = "CANCEL";
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // labelInstituteName
            // 
            this.labelInstituteName.AutoSize = true;
            this.labelInstituteName.Location = new System.Drawing.Point(12, 49);
            this.labelInstituteName.Name = "labelInstituteName";
            this.labelInstituteName.Size = new System.Drawing.Size(50, 13);
            this.labelInstituteName.TabIndex = 1;
            this.labelInstituteName.Text = "Institute: ";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(59, 71);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(351, 20);
            this.nameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "School";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Faculties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Facilities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "This Subject is For Students of Academic Year: ";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(244, 270);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(166, 21);
            this.yearComboBox.TabIndex = 4;
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
            // facilityListBox
            // 
            this.facilityListBox.FormattingEnabled = true;
            this.facilityListBox.Location = new System.Drawing.Point(9, 19);
            this.facilityListBox.Name = "facilityListBox";
            this.facilityListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.facilityListBox.Size = new System.Drawing.Size(185, 121);
            this.facilityListBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "How much time per week this subject should be taught?";
            // 
            // hoursComboBox
            // 
            this.hoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursComboBox.FormattingEnabled = true;
            this.hoursComboBox.Location = new System.Drawing.Point(285, 297);
            this.hoursComboBox.Name = "hoursComboBox";
            this.hoursComboBox.Size = new System.Drawing.Size(125, 21);
            this.hoursComboBox.TabIndex = 5;
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Location = new System.Drawing.Point(15, 369);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(395, 31);
            this.buttonAddSubject.TabIndex = 7;
            this.buttonAddSubject.Text = "SAVE THIS AND ADD ANOTHER SUBJECT";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(12, 419);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(395, 108);
            this.subjectListBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Current subjects";
            // 
            // buttonLegend
            // 
            this.buttonLegend.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonLegend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLegend.Location = new System.Drawing.Point(300, 324);
            this.buttonLegend.Name = "buttonLegend";
            this.buttonLegend.Size = new System.Drawing.Size(110, 23);
            this.buttonLegend.TabIndex = 6;
            this.buttonLegend.UseVisualStyleBackColor = false;
            this.buttonLegend.Click += new System.EventHandler(this.buttonLegend_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "What color should this subject have in excel file? (Legend)";
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.LightSeaGreen;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label9);
            this.panelToolBar.ForeColor = System.Drawing.Color.White;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(430, 40);
            this.panelToolBar.TabIndex = 25;
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
            this.buttonExit.Location = new System.Drawing.Point(397, 3);
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
            this.label9.Location = new System.Drawing.Point(167, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "New subject";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // panelFacilities
            // 
            this.panelFacilities.Controls.Add(this.facilityListBox);
            this.panelFacilities.Controls.Add(this.label4);
            this.panelFacilities.Location = new System.Drawing.Point(216, 124);
            this.panelFacilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFacilities.Name = "panelFacilities";
            this.panelFacilities.Size = new System.Drawing.Size(199, 142);
            this.panelFacilities.TabIndex = 3;
            // 
            // SubjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 587);
            this.ControlBox = false;
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLegend);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.hoursComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.facultyListBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelInstituteName);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.buttonSaveSubject);
            this.Controls.Add(this.panelFacilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Subject";
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.panelFacilities.ResumeLayout(false);
            this.panelFacilities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveSubject;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Label labelInstituteName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.ListBox facilityListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hoursComboBox;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLegend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelFacilities;
    }
}