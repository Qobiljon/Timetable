namespace Timetable
{
    partial class BuildingManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.buttonAddFacility = new System.Windows.Forms.Button();
            this.buttonClearFacility = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveBuilding = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddSchool = new System.Windows.Forms.Button();
            this.buttonClearSchool = new System.Windows.Forms.Button();
            this.yearTrackBar = new System.Windows.Forms.TrackBar();
            this.yearLabel = new System.Windows.Forms.Label();
            this.schoolText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddFaculty = new System.Windows.Forms.Button();
            this.buttonClearFaculty = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDefaultWeekdays = new System.Windows.Forms.Button();
            this.buttonSetColumns = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.finishHour = new System.Windows.Forms.DomainUpDown();
            this.finishMinute = new System.Windows.Forms.DomainUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.startHour = new System.Windows.Forms.DomainUpDown();
            this.startMinute = new System.Windows.Forms.DomainUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.schoolListBox = new System.Windows.Forms.ListBox();
            this.facultyListBox = new System.Windows.Forms.ListBox();
            this.facilityListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.contiguousCheckBox = new System.Windows.Forms.RadioButton();
            this.nonContiguousCheckBox = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Facilities of the building (rooms, pitch, ...)";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(53, 59);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(320, 20);
            this.nameText.TabIndex = 0;
            // 
            // buttonAddFacility
            // 
            this.buttonAddFacility.Location = new System.Drawing.Point(304, 577);
            this.buttonAddFacility.Name = "buttonAddFacility";
            this.buttonAddFacility.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFacility.TabIndex = 18;
            this.buttonAddFacility.Text = "ADD";
            this.buttonAddFacility.UseVisualStyleBackColor = true;
            this.buttonAddFacility.Click += new System.EventHandler(this.buttonAddFacility_Click);
            // 
            // buttonClearFacility
            // 
            this.buttonClearFacility.Location = new System.Drawing.Point(304, 606);
            this.buttonClearFacility.Name = "buttonClearFacility";
            this.buttonClearFacility.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFacility.TabIndex = 20;
            this.buttonClearFacility.Text = "REMOVE";
            this.buttonClearFacility.UseVisualStyleBackColor = true;
            this.buttonClearFacility.Click += new System.EventHandler(this.buttonClearFacility_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Orange;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(15, 684);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(157, 31);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveBuilding
            // 
            this.buttonSaveBuilding.BackColor = System.Drawing.Color.Lime;
            this.buttonSaveBuilding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveBuilding.Location = new System.Drawing.Point(178, 684);
            this.buttonSaveBuilding.Name = "buttonSaveBuilding";
            this.buttonSaveBuilding.Size = new System.Drawing.Size(201, 31);
            this.buttonSaveBuilding.TabIndex = 22;
            this.buttonSaveBuilding.Text = "SAVE";
            this.buttonSaveBuilding.UseVisualStyleBackColor = false;
            this.buttonSaveBuilding.Click += new System.EventHandler(this.buttonSaveBuilding_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(144, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "New building";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Divisions (Schools, ...)";
            // 
            // buttonAddSchool
            // 
            this.buttonAddSchool.Location = new System.Drawing.Point(148, 302);
            this.buttonAddSchool.Name = "buttonAddSchool";
            this.buttonAddSchool.Size = new System.Drawing.Size(46, 23);
            this.buttonAddSchool.TabIndex = 12;
            this.buttonAddSchool.Text = "ADD";
            this.buttonAddSchool.UseVisualStyleBackColor = true;
            this.buttonAddSchool.Click += new System.EventHandler(this.buttonAddSchool_Click);
            // 
            // buttonClearSchool
            // 
            this.buttonClearSchool.Location = new System.Drawing.Point(119, 427);
            this.buttonClearSchool.Name = "buttonClearSchool";
            this.buttonClearSchool.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSchool.TabIndex = 14;
            this.buttonClearSchool.Text = "REMOVE";
            this.buttonClearSchool.UseVisualStyleBackColor = true;
            this.buttonClearSchool.Click += new System.EventHandler(this.buttonClearSchool_Click);
            // 
            // yearTrackBar
            // 
            this.yearTrackBar.Location = new System.Drawing.Point(119, 87);
            this.yearTrackBar.Maximum = 12;
            this.yearTrackBar.Minimum = 1;
            this.yearTrackBar.Name = "yearTrackBar";
            this.yearTrackBar.Size = new System.Drawing.Size(254, 45);
            this.yearTrackBar.TabIndex = 2;
            this.yearTrackBar.Value = 1;
            this.yearTrackBar.Scroll += new System.EventHandler(this.yearTrackBar_Scroll);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 91);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(86, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Years of study: 1";
            // 
            // schoolText
            // 
            this.schoolText.Location = new System.Drawing.Point(15, 304);
            this.schoolText.Name = "schoolText";
            this.schoolText.Size = new System.Drawing.Size(127, 20);
            this.schoolText.TabIndex = 11;
            this.schoolText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.schoolText_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Faculties";
            // 
            // buttonAddFaculty
            // 
            this.buttonAddFaculty.Location = new System.Drawing.Point(304, 398);
            this.buttonAddFaculty.Name = "buttonAddFaculty";
            this.buttonAddFaculty.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFaculty.TabIndex = 15;
            this.buttonAddFaculty.Text = "ADD";
            this.buttonAddFaculty.UseVisualStyleBackColor = true;
            this.buttonAddFaculty.Click += new System.EventHandler(this.buttonAddFaculty_Click);
            // 
            // buttonClearFaculty
            // 
            this.buttonClearFaculty.Location = new System.Drawing.Point(304, 427);
            this.buttonClearFaculty.Name = "buttonClearFaculty";
            this.buttonClearFaculty.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFaculty.TabIndex = 17;
            this.buttonClearFaculty.Text = "REMOVE";
            this.buttonClearFaculty.UseVisualStyleBackColor = true;
            this.buttonClearFaculty.Click += new System.EventHandler(this.buttonClearFaculty_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Weekdays";
            // 
            // buttonDefaultWeekdays
            // 
            this.buttonDefaultWeekdays.Location = new System.Drawing.Point(148, 135);
            this.buttonDefaultWeekdays.Name = "buttonDefaultWeekdays";
            this.buttonDefaultWeekdays.Size = new System.Drawing.Size(75, 23);
            this.buttonDefaultWeekdays.TabIndex = 3;
            this.buttonDefaultWeekdays.Text = "DEFAULT";
            this.buttonDefaultWeekdays.UseVisualStyleBackColor = true;
            this.buttonDefaultWeekdays.Click += new System.EventHandler(this.buttonDefaultWeekdays_Click);
            // 
            // buttonSetColumns
            // 
            this.buttonSetColumns.Location = new System.Drawing.Point(247, 135);
            this.buttonSetColumns.Name = "buttonSetColumns";
            this.buttonSetColumns.Size = new System.Drawing.Size(75, 23);
            this.buttonSetColumns.TabIndex = 4;
            this.buttonSetColumns.Text = "SET";
            this.buttonSetColumns.UseVisualStyleBackColor = true;
            this.buttonSetColumns.Click += new System.EventHandler(this.buttonSetColumns_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "PERIOD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "FINISH:";
            // 
            // finishHour
            // 
            this.finishHour.Items.Add("18");
            this.finishHour.Items.Add("17");
            this.finishHour.Items.Add("16");
            this.finishHour.Items.Add("15");
            this.finishHour.Items.Add("14");
            this.finishHour.Items.Add("13");
            this.finishHour.Items.Add("12");
            this.finishHour.Items.Add("11");
            this.finishHour.Items.Add("10");
            this.finishHour.Items.Add("9");
            this.finishHour.Items.Add("8");
            this.finishHour.Items.Add("7");
            this.finishHour.Location = new System.Drawing.Point(133, 196);
            this.finishHour.Name = "finishHour";
            this.finishHour.ReadOnly = true;
            this.finishHour.Size = new System.Drawing.Size(46, 20);
            this.finishHour.TabIndex = 7;
            this.finishHour.Text = "7";
            this.finishHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // finishMinute
            // 
            this.finishMinute.Items.Add("30");
            this.finishMinute.Items.Add("00");
            this.finishMinute.Location = new System.Drawing.Point(226, 196);
            this.finishMinute.Name = "finishMinute";
            this.finishMinute.ReadOnly = true;
            this.finishMinute.Size = new System.Drawing.Size(46, 20);
            this.finishMinute.TabIndex = 8;
            this.finishMinute.Text = "0";
            this.finishMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(185, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Hours";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Minutes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(81, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "START:";
            // 
            // startHour
            // 
            this.startHour.Items.Add("18");
            this.startHour.Items.Add("17");
            this.startHour.Items.Add("16");
            this.startHour.Items.Add("15");
            this.startHour.Items.Add("14");
            this.startHour.Items.Add("13");
            this.startHour.Items.Add("12");
            this.startHour.Items.Add("11");
            this.startHour.Items.Add("10");
            this.startHour.Items.Add("9");
            this.startHour.Items.Add("8");
            this.startHour.Items.Add("7");
            this.startHour.Location = new System.Drawing.Point(133, 170);
            this.startHour.Name = "startHour";
            this.startHour.ReadOnly = true;
            this.startHour.Size = new System.Drawing.Size(46, 20);
            this.startHour.TabIndex = 5;
            this.startHour.Text = "7";
            this.startHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startMinute
            // 
            this.startMinute.Items.Add("30");
            this.startMinute.Items.Add("00");
            this.startMinute.Location = new System.Drawing.Point(226, 170);
            this.startMinute.Name = "startMinute";
            this.startMinute.ReadOnly = true;
            this.startMinute.Size = new System.Drawing.Size(46, 20);
            this.startMinute.TabIndex = 6;
            this.startMinute.Text = "0";
            this.startMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Hours";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Minutes";
            // 
            // periodComboBox
            // 
            this.periodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "30 Minutes",
            "45 Minutes",
            "60 Minutes"});
            this.periodComboBox.Location = new System.Drawing.Point(133, 221);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(139, 21);
            this.periodComboBox.TabIndex = 9;
            this.periodComboBox.SelectedIndexChanged += new System.EventHandler(this.periodComboBox_SelectedIndexChanged);
            // 
            // schoolListBox
            // 
            this.schoolListBox.FormattingEnabled = true;
            this.schoolListBox.Location = new System.Drawing.Point(15, 329);
            this.schoolListBox.Name = "schoolListBox";
            this.schoolListBox.Size = new System.Drawing.Size(179, 121);
            this.schoolListBox.TabIndex = 13;
            // 
            // facultyListBox
            // 
            this.facultyListBox.FormattingEnabled = true;
            this.facultyListBox.Location = new System.Drawing.Point(200, 303);
            this.facultyListBox.Name = "facultyListBox";
            this.facultyListBox.Size = new System.Drawing.Size(179, 147);
            this.facultyListBox.TabIndex = 16;
            // 
            // facilityListBox
            // 
            this.facilityListBox.FormattingEnabled = true;
            this.facilityListBox.Location = new System.Drawing.Point(15, 469);
            this.facilityListBox.Name = "facilityListBox";
            this.facilityListBox.Size = new System.Drawing.Size(364, 160);
            this.facilityListBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "STANDARD LESSON DURATION:";
            // 
            // durationComboBox
            // 
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Location = new System.Drawing.Point(194, 253);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(179, 21);
            this.durationComboBox.TabIndex = 10;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label5);
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(386, 50);
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
            this.buttonExit.Location = new System.Drawing.Point(353, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "x";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // contiguousCheckBox
            // 
            this.contiguousCheckBox.AutoSize = true;
            this.contiguousCheckBox.Checked = true;
            this.contiguousCheckBox.Location = new System.Drawing.Point(4, 17);
            this.contiguousCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.contiguousCheckBox.Name = "contiguousCheckBox";
            this.contiguousCheckBox.Size = new System.Drawing.Size(78, 17);
            this.contiguousCheckBox.TabIndex = 0;
            this.contiguousCheckBox.TabStop = true;
            this.contiguousCheckBox.Text = "Contiguous";
            this.contiguousCheckBox.UseVisualStyleBackColor = true;
            // 
            // nonContiguousCheckBox
            // 
            this.nonContiguousCheckBox.AutoSize = true;
            this.nonContiguousCheckBox.Location = new System.Drawing.Point(180, 17);
            this.nonContiguousCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.nonContiguousCheckBox.Name = "nonContiguousCheckBox";
            this.nonContiguousCheckBox.Size = new System.Drawing.Size(100, 17);
            this.nonContiguousCheckBox.TabIndex = 0;
            this.nonContiguousCheckBox.Text = "Non-contiguous";
            this.nonContiguousCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nonContiguousCheckBox);
            this.groupBox1.Controls.Add(this.contiguousCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 634);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(363, 45);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of timetable";
            // 
            // BuildingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 724);
            this.ControlBox = false;
            this.Controls.Add(this.durationComboBox);
            this.Controls.Add(this.periodComboBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.startMinute);
            this.Controls.Add(this.finishMinute);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.finishHour);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSetColumns);
            this.Controls.Add(this.buttonDefaultWeekdays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.schoolText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTrackBar);
            this.Controls.Add(this.buttonClearFaculty);
            this.Controls.Add(this.buttonClearSchool);
            this.Controls.Add(this.buttonAddFaculty);
            this.Controls.Add(this.buttonAddSchool);
            this.Controls.Add(this.buttonClearFacility);
            this.Controls.Add(this.buttonAddFacility);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveBuilding);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.facilityListBox);
            this.Controls.Add(this.facultyListBox);
            this.Controls.Add(this.schoolListBox);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildingManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Building";
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button buttonAddFacility;
        private System.Windows.Forms.Button buttonClearFacility;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveBuilding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddSchool;
        private System.Windows.Forms.Button buttonClearSchool;
        private System.Windows.Forms.TrackBar yearTrackBar;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox schoolText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddFaculty;
        private System.Windows.Forms.Button buttonClearFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDefaultWeekdays;
        private System.Windows.Forms.Button buttonSetColumns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown finishHour;
        private System.Windows.Forms.DomainUpDown finishMinute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DomainUpDown startHour;
        private System.Windows.Forms.DomainUpDown startMinute;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.ListBox schoolListBox;
        private System.Windows.Forms.ListBox facultyListBox;
        private System.Windows.Forms.ListBox facilityListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton contiguousCheckBox;
        private System.Windows.Forms.RadioButton nonContiguousCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}