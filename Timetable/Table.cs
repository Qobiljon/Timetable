using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Timetable
{
    public class Table
    {
        public Table(string tableName, string[] columns, string[] rows, CourseSession[][] data = null) 
        {
            // has to avoid similar column values or similar row values
            // has to check if data[,] dimensions match columns[] and rows[] dimensions
            name = tableName;
            cols = columns;
            this.rows = rows;
            if (data == null)
            {
                this.data = new CourseSession[rows.Length, cols.Length];
                for (int r = 0; r < rows.Length; r++)
                    for (int c = 0; c < cols.Length; c++)
                        this.data[r, c] = null;
            }
            else
            {
                this.data = new CourseSession[rows.Length, cols.Length];
                for (int r = 0; r < rows.Length; r++)
                    for (int c = 0; c < cols.Length; c++)
                        this.data[r, c] = data[r][c];
            }
        }



        //private string path;
        private string name;
        private string[] rows, cols;
        private CourseSession[,] data;

        // constants
        public static string DEF_ROW = "value";
        public static char DEF_SEP_CHAR = ',';
        public static char DEF_DELIMITER = (char)8;



        public string Name { get { return name; } set { name = value; } }
        public int Width { get { return cols.Length; } }
        public int Height { get { return rows.Length; } }



        public CourseSession[,] Data { get { return data; } }

        public CourseSession getValue(string row, string col)
        {
            for (int r = 0; r < rows.Length; r++)
                for (int c = 0; c < cols.Length; c++)
                    if (rows[r] == row)
                    {
                        if (cols[c] == col)
                            return data[r, c];
                    }
                    else break;
            return null;
        }

        public bool setValue(string row, string col, CourseSession value)
        {
            for (int r = 0; r < rows.Length; r++)
                for (int c = 0; c < cols.Length; c++)
                    if (rows[r] == row)
                    {
                        if (cols[c] == col){
                            data[r, c] = value;
                            return true;
                        }
                    }
                    else break;
            return false;
        }

        public bool setValue(int x, int y, CourseSession value)
        {
            if (x < cols.Length && y < rows.Length)
            {
                data[y, x] = value;
                return true;
            }
            return false;
        }

        // will not contain any sep chars in the element strings
        public void save(string filePath, string sep)
        {
            FileStream stream;
            StreamWriter wr;
            stream = new FileStream(filePath, FileMode.Create);
            wr = new StreamWriter(stream);
            wr.Write(toString(sep));
            wr.Close();
            stream.Close();
        }

        // must not contain any sep chars in the element strings
        public string toString(string sep)
        {
            string res = name;
            for (int c = 0; c < cols.Length; c++)
                res += sep + cols[c];
            res += "\n";

            for (int r = 0; r < rows.Length; r++)
            {
                for (int c = 0; c < cols.Length; c++)
                {
                    if (c == 0)
                        res += rows[r];

                    res += sep + (data[r, c] != null);
                }
                res += "\n";
            }
            return res;
        }

        // in data string not allowed as parts of string elements: ' , " \n 
        public static Table parse(string data, string sep)
        {
            string name = null;

            List<string> lines = new List<string>(Regex.Split(data, "\n"));
            List<string> rows = new List<string>();
            string[] cols = null;
            List<CourseSession[]> elems = new List<CourseSession[]>();
            List<string> temp;

            for (int n = 0; !lines[n].Equals("") && n < lines.Count; n++)
            {
                if (n == 0){
                    temp = new List<string>(Regex.Split(lines[n], sep));
                    name = temp[0]; temp.RemoveAt(0);
                    cols = temp.ToArray();
                }
                else
                {
                    temp = new List<string>(Regex.Split(lines[n], sep));
                    rows.Add(temp[0]); temp.RemoveAt(0);
                    string[] read = temp.ToArray();
                    elems.Add(new CourseSession[read.Length]);
                    for (int m = 0, i = elems.Count - 1; m < read.Length; m++)
                    {
                        if (bool.Parse(read[m]))
                            elems[i][m] = CourseSession.Excluded;
                        else
                            elems[i][m] = null;
                    }
                }
            }

            return new Table(name, cols, rows.ToArray(), elems.ToArray());
        }

        public int countCells(CourseSession session = null)
        {
            int count = 0;
            for (int r = 0; r < rows.Length; r++)
                for (int c = 0; c < cols.Length; c++)
                    if (data[r, c] == session)
                        count++;
            return count;
        }

        public Point[] getCells(CourseSession session = null)
        {
            List<Point> res = new List<Point>();
            for (int r = 0; r < rows.Length; r++)
                for (int c = 0; c < cols.Length; c++)
                    if (data[r, c] == session)
                        res.Add(new Point(c, r));
            return res.ToArray();
        }
    }
}
