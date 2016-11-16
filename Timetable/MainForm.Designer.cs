namespace Timetable
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildButton = new System.Windows.Forms.ToolStripMenuItem();
            this.generate = new System.Windows.Forms.ToolStripMenuItem();
            this.generateAcademic = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.generateStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englisjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ozbekchaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spainishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koreanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processProgress = new System.Windows.Forms.ProgressBar();
            this.processLabel = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelBuildingName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelToolBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(158, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.loadProjectToolStripMenuItem.Text = "Open Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildButton,
            this.generate});
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.runToolStripMenuItem.Text = "Process";
            // 
            // buildButton
            // 
            this.buildButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buildButton.Enabled = false;
            this.buildButton.ForeColor = System.Drawing.Color.White;
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(214, 22);
            this.buildButton.Text = "Build a timetable";
            this.buildButton.Click += new System.EventHandler(this.build_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.generate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateAcademic,
            this.generateTeacher,
            this.generateStudent});
            this.generate.Enabled = false;
            this.generate.ForeColor = System.Drawing.Color.White;
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(214, 22);
            this.generate.Text = "Generate this timetable for";
            // 
            // generateAcademic
            // 
            this.generateAcademic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.generateAcademic.ForeColor = System.Drawing.Color.White;
            this.generateAcademic.Name = "generateAcademic";
            this.generateAcademic.Size = new System.Drawing.Size(169, 22);
            this.generateAcademic.Text = "Academic Staff";
            this.generateAcademic.Click += new System.EventHandler(this.generateAcademic_Click);
            // 
            // generateTeacher
            // 
            this.generateTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.generateTeacher.ForeColor = System.Drawing.Color.White;
            this.generateTeacher.Name = "generateTeacher";
            this.generateTeacher.Size = new System.Drawing.Size(169, 22);
            this.generateTeacher.Text = "Teachers";
            this.generateTeacher.Click += new System.EventHandler(this.generateTeacher_Click);
            // 
            // generateStudent
            // 
            this.generateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.generateStudent.ForeColor = System.Drawing.Color.White;
            this.generateStudent.Name = "generateStudent";
            this.generateStudent.Size = new System.Drawing.Size(169, 22);
            this.generateStudent.Text = "Students (Groups)";
            this.generateStudent.Click += new System.EventHandler(this.generateStudent_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.othersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englisjToolStripMenuItem,
            this.russianToolStripMenuItem,
            this.ozbekchaToolStripMenuItem,
            this.spainishToolStripMenuItem,
            this.koreanToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.deutchToolStripMenuItem});
            this.languageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englisjToolStripMenuItem
            // 
            this.englisjToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.englisjToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.englisjToolStripMenuItem.Name = "englisjToolStripMenuItem";
            this.englisjToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.englisjToolStripMenuItem.Text = "English";
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.russianToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.russianToolStripMenuItem.Text = "Русский";
            // 
            // ozbekchaToolStripMenuItem
            // 
            this.ozbekchaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ozbekchaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ozbekchaToolStripMenuItem.Name = "ozbekchaToolStripMenuItem";
            this.ozbekchaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ozbekchaToolStripMenuItem.Text = "O\'zbekcha";
            // 
            // spainishToolStripMenuItem
            // 
            this.spainishToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.spainishToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.spainishToolStripMenuItem.Name = "spainishToolStripMenuItem";
            this.spainishToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.spainishToolStripMenuItem.Text = "Español";
            // 
            // koreanToolStripMenuItem
            // 
            this.koreanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.koreanToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.koreanToolStripMenuItem.Name = "koreanToolStripMenuItem";
            this.koreanToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.koreanToolStripMenuItem.Text = "한국어";
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.italianToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.italianToolStripMenuItem.Text = "Italiano";
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.frenchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.frenchToolStripMenuItem.Text = "Français";
            // 
            // deutchToolStripMenuItem
            // 
            this.deutchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.deutchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deutchToolStripMenuItem.Name = "deutchToolStripMenuItem";
            this.deutchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deutchToolStripMenuItem.Text = "Deutsche";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.helpToolStripMenuItem.Text = "Help (html)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // processProgress
            // 
            this.processProgress.Location = new System.Drawing.Point(12, 27);
            this.processProgress.Name = "processProgress";
            this.processProgress.Size = new System.Drawing.Size(601, 23);
            this.processProgress.TabIndex = 3;
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Font = new System.Drawing.Font("Consolas", 12F);
            this.processLabel.ForeColor = System.Drawing.Color.White;
            this.processLabel.Location = new System.Drawing.Point(12, 5);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(180, 19);
            this.processLabel.TabIndex = 4;
            this.processLabel.Text = "Process: waiting...";
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.container.Location = new System.Drawing.Point(0, 41);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(625, 297);
            this.container.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelBuildingName);
            this.panel1.Controls.Add(this.container);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 344);
            this.panel1.TabIndex = 6;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.label1);
            this.panelToolBar.Controls.Add(this.buttonMinimize);
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.menuStrip1);
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(625, 60);
            this.panelToolBar.TabIndex = 0;
            this.panelToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.panelToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.panelToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timest Engine";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Consolas", 12F);
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(556, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(592, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "x";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.panel3.Controls.Add(this.processLabel);
            this.panel3.Controls.Add(this.processProgress);
            this.panel3.Location = new System.Drawing.Point(0, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 62);
            this.panel3.TabIndex = 7;
            // 
            // labelBuildingName
            // 
            this.labelBuildingName.AutoSize = true;
            this.labelBuildingName.Location = new System.Drawing.Point(9, 9);
            this.labelBuildingName.Name = "labelBuildingName";
            this.labelBuildingName.Size = new System.Drawing.Size(41, 13);
            this.labelBuildingName.TabIndex = 6;
            this.labelBuildingName.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Groups:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(166)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(625, 472);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timest Engine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generate;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englisjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ozbekchaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spainishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koreanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateAcademic;
        private System.Windows.Forms.ToolStripMenuItem generateTeacher;
        private System.Windows.Forms.ToolStripMenuItem generateStudent;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ProgressBar processProgress;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem buildButton;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBuildingName;
        private System.Windows.Forms.Label label2;
    }
}

