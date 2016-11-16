using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class TimeManager : Form
    {
        public TimeManager(string name, string type)
        {
            InitializeComponent();

            Text += type + " " + name;
            this.name = name;

            foreach (string col in BuildingManager.columns)
            {
                table.Columns.Add(col, col);
                table.Columns[table.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                table.Columns[table.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            string[] rowData = new string[BuildingManager.columns.Length];
            for (int n = 0; n < rowData.Length; n++)
                rowData[n] = "X";
            foreach (string row in BuildingManager.rows)
            {
                table.Rows.Add(rowData);
                table.Rows[table.Rows.Count - 1].HeaderCell.Value = row;
                table.Rows[table.Rows.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                table.Rows[table.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            }

            int width = (table.Width-100) / (table.Columns.Count);
            int height = table.Height / (table.Rows.Count + 1);

            table.RowHeadersWidth = 95;
            table.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in table.Columns)
            {
                col.Width = width;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewRow row in table.Rows)
            {
                row.Height = height;
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public Table timetable;
        private string name;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CourseSession[][] data = new CourseSession[table.Rows.Count][];
            string[] rows = new string[table.Rows.Count];
            string[] cols = new string[table.Columns.Count];

            for (int c = 0; c < table.Columns.Count; c++)
                cols[c] = (string)table.Columns[c].HeaderCell.Value;

            for (int r = 0; r < table.Rows.Count; r++)
            {
                data[r] = new CourseSession[table.Columns.Count];
                rows[r] = (string)table.Rows[r].HeaderCell.Value;
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    if (table.Rows[r].Cells[c].Style.BackColor == Color.Red)
                        data[r][c] = CourseSession.Excluded;
                    else data[r][c] = null;
                }
            }

            timetable = new Table(name, cols, rows, data);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void table_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in table.SelectedCells)
            {
                if (cell.Style.BackColor == Color.Red)
                {
                    cell.Style.BackColor = Color.White;
                }
                else
                {
                    cell.Style.BackColor = Color.Red;
                }
            }
            table.ClearSelection();
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
