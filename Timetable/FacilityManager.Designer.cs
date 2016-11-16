namespace Timetable
{
    partial class FacilityManager
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeText = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.capacityText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.timeRadioButton = new System.Windows.Forms.RadioButton();
            this.freeRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.allowCapacityTrackBar = new System.Windows.Forms.TrackBar();
            this.capacityPercentageLabel = new System.Windows.Forms.Label();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allowCapacityTrackBar)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name/ID/Number";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(111, 38);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(161, 20);
            this.nameText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // typeText
            // 
            this.typeText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeText.FormattingEnabled = true;
            this.typeText.Items.AddRange(new object[] {
            "Lab",
            "Lecture",
            "Data center",
            "Maintenance",
            "Other"});
            this.typeText.Location = new System.Drawing.Point(111, 64);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(161, 21);
            this.typeText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Location = new System.Drawing.Point(127, 221);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 28);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Orange;
            this.buttonCancel.Location = new System.Drawing.Point(15, 221);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // capacityText
            // 
            this.capacityText.Location = new System.Drawing.Point(111, 91);
            this.capacityText.Name = "capacityText";
            this.capacityText.Size = new System.Drawing.Size(161, 20);
            this.capacityText.TabIndex = 2;
            this.capacityText.TextChanged += new System.EventHandler(this.capacityText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "School";
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(111, 149);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(161, 21);
            this.schoolComboBox.TabIndex = 4;
            // 
            // timeRadioButton
            // 
            this.timeRadioButton.AutoSize = true;
            this.timeRadioButton.Location = new System.Drawing.Point(179, 176);
            this.timeRadioButton.Name = "timeRadioButton";
            this.timeRadioButton.Size = new System.Drawing.Size(93, 17);
            this.timeRadioButton.TabIndex = 5;
            this.timeRadioButton.Text = "Set up time off";
            this.timeRadioButton.UseVisualStyleBackColor = true;
            this.timeRadioButton.CheckedChanged += new System.EventHandler(this.timeRadioButton_CheckedChanged);
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Checked = true;
            this.freeRadioButton.Location = new System.Drawing.Point(94, 176);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.freeRadioButton.TabIndex = 5;
            this.freeRadioButton.TabStop = true;
            this.freeRadioButton.Text = "Always free";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Availability";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fill Room";
            // 
            // allowCapacityTrackBar
            // 
            this.allowCapacityTrackBar.Location = new System.Drawing.Point(111, 117);
            this.allowCapacityTrackBar.Minimum = 5;
            this.allowCapacityTrackBar.Name = "allowCapacityTrackBar";
            this.allowCapacityTrackBar.Size = new System.Drawing.Size(122, 45);
            this.allowCapacityTrackBar.TabIndex = 3;
            this.allowCapacityTrackBar.Value = 10;
            this.allowCapacityTrackBar.Scroll += new System.EventHandler(this.allowCapacityTrackBar_Scroll);
            // 
            // capacityPercentageLabel
            // 
            this.capacityPercentageLabel.AutoSize = true;
            this.capacityPercentageLabel.Location = new System.Drawing.Point(239, 122);
            this.capacityPercentageLabel.Name = "capacityPercentageLabel";
            this.capacityPercentageLabel.Size = new System.Drawing.Size(33, 13);
            this.capacityPercentageLabel.TabIndex = 8;
            this.capacityPercentageLabel.Text = "100%";
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label7);
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(287, 32);
            this.panelToolBar.TabIndex = 9;
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
            this.buttonExit.Location = new System.Drawing.Point(254, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 26);
            this.buttonExit.TabIndex = 11;
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(94, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "New building";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // FacilityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.capacityPercentageLabel);
            this.Controls.Add(this.freeRadioButton);
            this.Controls.Add(this.timeRadioButton);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capacityText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allowCapacityTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacilityManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Facility";
            ((System.ComponentModel.ISupportInitialize)(this.allowCapacityTrackBar)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox capacityText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.RadioButton timeRadioButton;
        private System.Windows.Forms.RadioButton freeRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar allowCapacityTrackBar;
        private System.Windows.Forms.Label capacityPercentageLabel;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label7;
    }
}