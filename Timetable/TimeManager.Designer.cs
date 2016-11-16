namespace Timetable
{
    partial class TimeManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.table);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 413);
            this.panel1.TabIndex = 0;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.GridColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(551, 413);
            this.table.TabIndex = 0;
            this.table.Click += new System.EventHandler(this.table_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.Location = new System.Drawing.Point(273, 492);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(290, 26);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "OK";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Orange;
            this.buttonCancel.Location = new System.Drawing.Point(12, 492);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(255, 26);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panelToolBar.Controls.Add(this.buttonExit);
            this.panelToolBar.Controls.Add(this.label9);
            this.panelToolBar.ForeColor = System.Drawing.Color.White;
            this.panelToolBar.Location = new System.Drawing.Point(0, 0);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(577, 50);
            this.panelToolBar.TabIndex = 43;
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
            this.buttonExit.Location = new System.Drawing.Point(544, 3);
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
            this.label9.Location = new System.Drawing.Point(192, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Please choose TIME-OFF";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveYes);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveDo);
            this.label9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveNo);
            // 
            // TimeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose off-time for: ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label9;
    }
}