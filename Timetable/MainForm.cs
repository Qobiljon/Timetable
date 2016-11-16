using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using Protool;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Diagnostics;

namespace Timetable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        #region Variables
        private Group[] groupsAll;
        private List<Table> final = new List<Table>();
        private ExcelFile templateFile = null;

        private DirectoryInfo studentsDirectory;
        DirectoryInfo rootDirectory;
        DirectoryInfo academicDirectory;
        DirectoryInfo teachersDirectory;
        #endregion

        

        private void log(string process, int percentage)
        {
            processLabel.Invoke(new Action(() =>
            {
                processLabel.Text = "Process: " + process;
                if (percentage == 0)
                    processProgress.Style = ProgressBarStyle.Marquee;
                else
                {
                    if (processProgress.Style == ProgressBarStyle.Marquee)
                        processProgress.Style = ProgressBarStyle.Continuous;

                    processProgress.Value = percentage < processProgress.Maximum ? percentage : processProgress.Maximum;
                    processProgress.Update();
                    processProgress.Refresh();
                    processProgress.Invalidate();
                }
            }));
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buildButton.Enabled = false;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Project file|*.prtf";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (dialog.ShowDialog(this) == DialogResult.OK)
                loadProject(dialog.FileName);
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buildButton.Enabled = false;

            ProjectManager form = new ProjectManager();
            Opacity = 0.3;
            form.ShowDialog(this);
            Opacity = 1;
            if (form.projectFile != null)
                loadProject(form.projectFile);
        }



        public void loadProject(string projectFilePath)
        {
            Base.releaseObjects();

            Tools.projectFilePath = projectFilePath;
            Tools.projectFolderPath = Tools.projectFilePath.Substring(0, Tools.projectFilePath.LastIndexOf('\\'));
            if (Directory.Exists(Tools.projectFolderPath + @"\Build"))
            {
                try
                {
                    Directory.Delete(Tools.projectFolderPath + @"\Build", true);
                }
                catch
                {
                    //System.Threading.Thread.Sleep(100);
                    //Directory.Delete(Tools.projectFolderPath + @"\Build", true);
                }
            }
            Directory.CreateDirectory(Tools.projectFolderPath + @"\Build");

            log("Loading the project...", 50);
            try
            {
                string data = Tools.readFromFile(projectFilePath);

                string building;
                string[] subjects, professors, students;

                string[] parts = Regex.Split(data, Tools.delimiter_rep2);
                building = parts[0];
                subjects = Regex.Split(parts[1], Tools.delimiter);
                professors = Regex.Split(parts[2], Tools.delimiter);

                loadBuilding(building);
                loadSubjects(subjects);
                loadProfessors(professors);

                if (!parts[3].Equals(""))
                {
                    students = Regex.Split(parts[3], Tools.delimiter);
                    loadStudents(students);
                }

                buildButton.Enabled = true;

                labelBuildingName.Text = "Name: " + Tools.building.Name;
                log("Project loaded successfully", 100);
            }
            catch
            {
                log("Couldn't load the project! (file must be broken)", 0);
            }


            //if (MessageBox.Show("Divide students into groups automatically (recommended)?", "Use automatized best configurations", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    string temp = Microsoft.VisualBasic.Interaction.InputBox("", "");
            //    int count = int.Parse(Regex.Match(temp, "[0-9]+").Value);
            //}
            //else
            {
                prepareGroupSetupScreen(groupsAll = calculateGroups(calculateCurrentMinimums()));
            }
        }

        private void prepareGroupSetupScreen(Group[] groups)
        {
            int margin = 20, padding = 10;
            Point nextLocation = new Point(margin, margin);

            Panel group = null;
            for (int n = 0; n < groups.Length; n++)
            {
                group = new Panel();
                group.BackColor = Color.DarkRed;
                group.Location = nextLocation;
                group.Cursor = Cursors.Hand;
                //group.Tag = n;
                Label[] labels = new Label[4];
                for (int m = 0; m < labels.Length; m++)
                    labels[m] = new Label();

                labels[0].Text = string.Format("Group no:  {0}", groups[n].GroupNumber);
                labels[1].Text = string.Format("Year:      {0}", groups[n].Year);
                labels[2].Text = string.Format("Faculty:   {0}", groups[n].Faculty.Name);
                labels[3].Text = string.Format("Size:      {0}", groups[n].Size);

                for (int m = 0; m < labels.Length; m++)
                {
                    labels[m].Location = new Point(padding, padding + m * (labels[m].Height));
                    labels[m].TextAlign = ContentAlignment.MiddleLeft;
                    labels[m].ForeColor = Color.White;
                }
                group.Height = padding + labels[labels.Length - 1].Location.Y + labels[labels.Length - 1].Height;
                group.Width = 2 * padding + labels[labels.Length - 1].Width;

                if (group.Location.Y + 2 * (group.Height + margin) < container.Height)
                    nextLocation.Y = group.Location.Y + group.Height + margin;
                else
                {
                    nextLocation.Y = margin;
                    nextLocation.X = group.Location.X + group.Width + margin;
                }

                foreach (Label label in labels)
                    group.Controls.Add(label);

                Invoke(new Action(() => { container.Controls.Add(group); }));
            }
            Invoke(new Action(() => { container.Width = group.Location.X + group.Width + margin; }));
        }

        public static void loadBuilding(string filePath)
        {
            string data = Tools.readFromFile(filePath);
            Tools.building = Building.fromFile(filePath);

            BuildingManager.columns = Tools.building.Columns;
            BuildingManager.rows = Tools.building.Rows;

            BuildingManager.schools = Tools.building.Schools;
            BuildingManager.faculties = Tools.building.Faculties;
            BuildingManager.facilities = Tools.building.Facilities;
            BuildingManager.years = Tools.building.Years;
            BuildingManager.periodLength = Tools.building.PeriodLength;
            BuildingManager.periodCount = Tools.building.PeriodCount;
            BuildingManager.standardLessonDuration = Tools.building.StandardLessonDuration;
            BuildingManager.buildingName = Tools.building.Name;
            BuildingManager.height = Tools.building.Height;
        }

        public static void loadSubjects(string[] filePaths)
        {
            Tools.subjects = new Subject[filePaths.Length];
            for (int n = 0; n < filePaths.Length; n++)
            {
                Tools.subjects[n] = Subject.fromFile(filePaths[n]);
                Tools.subjects[n].Index = n;
            }
        }

        public static void loadProfessors(string[] filePaths)
        {
            Tools.teachers = new Teacher[filePaths.Length];

            for (int n = 0; n < filePaths.Length; n++)
            {
                Tools.teachers[n] = Teacher.fromFile(filePaths[n]);
                Tools.teachers[n].Index = n;

                foreach (Subject subject in Tools.teachers[n].Subjects)
                    subject.Teachers.Add(Tools.teachers[n]);
            }
        }

        public static void loadStudents(string[] filePaths)
        {
            Tools.students = new Student[filePaths.Length];

            for (int n = 0; n < filePaths.Length; n++)
            {
                Tools.students[n] = Student.fromFile(filePaths[n]);
                Tools.students[n].Index = n;
            }
        }



        private static int[,] calculateCurrentMinimums()
        {
            int[,] minSize = new int[Tools.building.Years, Tools.building.Faculties.Length];

            for (int yr = 0; yr < Tools.building.Years; yr++)
                for (int fc = 0; fc < Tools.building.Faculties.Length; fc++)
                    minSize[yr, fc] = -1;

            foreach (Subject sb in Tools.subjects)
            {
                foreach (Room rm in sb.Facilities)
                    foreach (Faculty fc in sb.Faculties)
                        if (minSize[sb.Year - 1, fc.Index] == -1 || rm.AllowCapacity < minSize[sb.Year - 1, fc.Index])
                            minSize[sb.Year - 1, fc.Index] = rm.AllowCapacity;
            }

            return minSize;
        }

        private static Group[] calculateGroups(int[,] minSize)
        {
            int[,] count = new int[Tools.building.Years, Tools.building.Faculties.Length];
            List<Group> groups = new List<Group>();

            for (int year = 0; year < Tools.building.Years; year++)
            {
                for (int faculty = 0, temp, size; faculty < Tools.building.Faculties.Length; faculty++)
                {
                    if (minSize[year, faculty] == 0)
                    {
                        groups.Add(new Group(Tools.building.Faculties[faculty], (year + 1), minSize[year, faculty], count[year, faculty]++));
                    }
                    else if (Tools.building.Faculties[faculty].Students[year] % minSize[year, faculty] == 0)
                    {
                        temp = Tools.building.Faculties[faculty].Students[year] / minSize[year, faculty];
                        for (int m = 0; m < temp; m++)
                            groups.Add(new Group(Tools.building.Faculties[faculty], (year + 1), minSize[year, faculty], count[year, faculty]++));
                    }
                    else
                    {
                        temp = Tools.building.Faculties[faculty].Students[year] / minSize[year, faculty] + 1;
                        size = Tools.building.Faculties[faculty].Students[year] / temp;
                        for (int m = 0, delta = Tools.building.Faculties[faculty].Students[year] % size; m < temp; m++, delta--)
                            groups.Add(new Group(Tools.building.Faculties[faculty], (year + 1), size + (delta > 0 ? 1 : 0), count[year, faculty]++));
                    }
                }
            }

            return groups.ToArray();
        }



        private void build_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object send, DoWorkEventArgs ev) =>
            {
                log("Creating directories...", 0);
                Tools.buildFolderPath = Tools.projectFolderPath + @"\Build\" + Tools.building.Name;

                if (Directory.Exists(Tools.buildFolderPath))
                {
                    Directory.Delete(Tools.buildFolderPath, true);

                    loadProject(Tools.projectFilePath);
                }

                rootDirectory = Directory.CreateDirectory(Tools.buildFolderPath);
                academicDirectory = rootDirectory.CreateSubdirectory("Academic Staff");
                teachersDirectory = rootDirectory.CreateSubdirectory("Teachers");
                studentsDirectory = rootDirectory.CreateSubdirectory("Students");
                
                log("Creating directories...", 10);
                for (int n = 1; n <= Tools.building.Years; n++)
                    studentsDirectory.CreateSubdirectory(Tools.acadYearFolderName + n);

                log("Creating directories...", 25);

                for (int n = 1; n <= Tools.building.Years; n++)
                    foreach (string sc in Tools.building.Schools)
                    {
                        //teacDir.CreateSubdirectory(sc);
                        studentsDirectory.CreateSubdirectory(Tools.acadYearFolderName + n + @"\" + sc);
                    }
                log("Creating directories...", 60);

                for (int n = 1; n <= Tools.building.Years; n++)
                    foreach (Faculty fc in Tools.building.Faculties)
                        studentsDirectory.CreateSubdirectory(Tools.acadYearFolderName + n + @"\" + fc.School + @"\" + fc.Name);
                log("Creating directories...", 90);

                // now start building and if build successfully, make a saving button available

                if (build(Tools.building.Contiguous))
                {
                    Invoke(new Action(() =>
                    {
                        generate.Enabled = true;
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        generate.Enabled = false;
                    }));
                }
                

                log("Loading template files...", 0);
                createTemplateFile(Tools.building.Columns.Length, Tools.building.Rows.Length, new ExcelFile(Tools.prototypeTableFile));
                System.Threading.Thread.Sleep(500);

                log("Built successfully!", 100);
            };
            worker.RunWorkerAsync();
        }

        private bool build(bool contiguous)
        {
            // object from Random for generating random numbers
            Random random = new Random();

            // sort subjects by years in ascending order
            for (int n = 0; n < Tools.subjects.Length - 1; n++)
            {
                // set the first minimum to n
                int min = n;
                // find the real minimum between all lenghes
                for (int m = n + 1; m < Tools.subjects.Length; m++)
                    if (Tools.subjects[m].Year < Tools.subjects[n].Year)
                        min = m;

                // swap [min] with [n] if needed
                if (min != n)
                {
                    Subject temp = Tools.subjects[n];
                    Tools.subjects[n] = Tools.subjects[min];
                    Tools.subjects[min] = temp;
                }
                log("Preparing for calculations...", n * 100 / (Tools.subjects.Length - 1));
            }

            // calculate timetables for groups
            // go over all subjects
            int percentage = 0;
            foreach (Subject subject in Tools.subjects)
            {
                percentage += 100 / Tools.subjects.Length;
                log("Building...", percentage);

                Faculty[] faculties = subject.Faculties; // all faculties that the subject is taught to
                Room[] rooms = subject.Facilities; // all rooms that the subject can be taught in
                Teacher[] teachers = subject.Teachers.ToArray(); // all teachers that can teach the subject
                
                // go over all faculties
                foreach (Faculty faculty in faculties)
                {
                    Group[] foundGroups = findGroups(faculty.Name, subject.Year); // find all groups of the matching academic year and faculty
                    sortByFreeCells(teachers); // sort available teachers by their free time (so that the free one is more first to teach)
                    sortByFreeCells(rooms); // sort available rooms by their free time (so that the free one is more first to be occupied)

                    if (teachers.Length == 0)
                        throw new ApplicationException("Please add teachers to teach a subject: " + subject.Name + ", because there are no!");

                    Pair<Teacher, Pair<Room, Group[]>>[] teacherGroups = matchUpData(teachers, foundGroups, rooms); // logically match teachers with groups

                    // go over all teacher knowing the groups that the teacher teaches the subject to
                    // TODO: logically match up groups with rooms
                    foreach (Pair<Teacher, Pair<Room, Group[]>> teacherGroup in teacherGroups)
                    {
                        Teacher teacher = teacherGroup.A;
                        Room room = teacherGroup.B.A;
                        Group[] groups = teacherGroup.B.B;

                        // find all points where the subject can be put in timetable (depending on the standart subject hours and free time of both room and teacher)
                        List<Point> locations = getValidCrossPoints(teacher, room, Tools.building.Height);

                        // warn if there's no available time matched
                        if (locations.Count == 0)
                        {
                            throw new ApplicationException("Cannot find a free cell for subject: " + subject.Name + ", teacher: " + teacher.Name + ", room: " + room.Name);
                            //MessageBox.Show("Cannot find a free cell for subject: " + subject.Name + ", teacher: " + teacher.Name + ", room: " + room.Name, "Error!");
                            //return false;
                        }
                        else
                        {
                            if (!contiguous)
                                shuffleLocations(locations); // shuffle locations so that it would become random
                            int height = subject.Minutes / Tools.building.PeriodLength; // calculate how many minutes the subject must be taught in one week
                            int count = height / Tools.building.Height; // calculate how many positions it should take from available ones
                            height %= Tools.building.Height; // find remaining part

                            if (count == 0 && height == 0)
                                throw new ApplicationException("Building's period length: " + Tools.building.PeriodLength + " and subject's hours: " + subject.Minutes + " don't match");

                            // warn if there's no enough time in a week to teach the subject by those teacher and room
                            if (locations.Count < count + (height == 0 ? 0 : 1))
                            {
                                throw new ApplicationException("Cannot fit the subject: " + subject.Name + ", teacher: " + teacher.Name + ", room: " + room.Name);
                                //MessageBox.Show("Cannot fit the subject: " + subject.Name + ", teacher: " + teacher.Name + ", room: " + room.Name, "Error!");
                                //return false;
                            }
                            else
                            {
                                Point location;
                                CourseSession session = new CourseSession(teacher, subject, room, groups);

                                for (int cnt = 0; cnt < count; cnt++)
                                {
                                    // put the whole parts
                                    location = locations[0];
                                    for (int h = 0; h < Tools.building.Height; h++)
                                    {
                                        foreach (Group group in groups)
                                            group.Timetable.Data[location.Y + h, location.X] = session;
                                        teacher.Timetable.Data[location.Y + h, location.X] = session;
                                        room.Timetable.Data[location.Y + h, location.X] = session;
                                    }
                                    locations.RemoveAt(0);
                                }

                                // put the remaining parts
                                if (height > 0)
                                {
                                    location = locations[0];
                                    for (int h = 0; h < height; h++)
                                    {
                                        foreach (Group group in groups)
                                            group.Timetable.Data[location.Y + h, location.X] = session;
                                        teacher.Timetable.Data[location.Y + h, location.X] = session;
                                        room.Timetable.Data[location.Y + h, location.X] = session;
                                    }
                                    removeColumnFromList(locations, location.X);
                                    locations.RemoveAt(0);
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        

        private Pair<Teacher, Pair<Room, Group[]>>[] matchUpData(Teacher[] teachers, Group[] groups, Room[] rooms)
        {
            List<Pair<Teacher, Group[]>> tempPairs = new List<Pair<Teacher, Group[]>>();

            if(teachers.Length == 1)
            {
                tempPairs.Add(new Pair<Teacher, Group[]>(teachers[0], groups));
            }
            else if (groups.Length % teachers.Length == 0)
            {
                int group = groups.Length / teachers.Length;
                int groupIndex = 0;

                foreach (Teacher teacher in teachers)
                {
                    Group[] temp = new Group[group];
                    for (int n = groupIndex; n < groupIndex + group; n++)
                        temp[n - groupIndex] = groups[groupIndex];

                    tempPairs.Add(new Pair<Teacher, Group[]>(teacher, temp));
                    groupIndex += group;
                }
            }
            else
            {
                int group = groups.Length / teachers.Length;
                int delta = groups.Length % teachers.Length;
                int groupIndex = 0;

                foreach (Teacher teacher in teachers)
                {
                    Group[] temp = new Group[group + (delta > 0 ? 1 : 0)];
                    for (int n = groupIndex; n < groupIndex + group + (delta > 0 ? 1 : 0); n++)
                        temp[n - groupIndex] = groups[groupIndex + (n - groupIndex)];

                    tempPairs.Add(new Pair<Teacher, Group[]>(teacher, temp));
                    groupIndex += group + (delta > 0 ? 1 : 0);
                    delta--;
                }
            }

            List<Pair<Teacher, Pair<Room, Group[]>>> res = new List<Pair<Teacher, Pair<Room, Group[]>>>();

            foreach (Pair<Teacher, Group[]> pair in tempPairs)
            {
                Teacher tempTeacher = pair.A;
                List<Group> allGroups = new List<Group>(pair.B);

                for (int r = 0; r < rooms.Length && allGroups.Count > 0; r++)
                {
                    int capacity = rooms[r].AllowCapacity;
                    int[] indices = bestMatchIndexes(allGroups, capacity);
                    Group[] tempGroups = new Group[indices.Length];
                    for (int n = indices.Length - 1; n > -1; n--)
                    {
                        tempGroups[indices.Length - 1 - n] = allGroups[indices[n]];
                        allGroups.RemoveAt(indices[n]);
                    }

                    res.Add(new Pair<Teacher, Pair<Room, Group[]>>(tempTeacher, new Pair<Room, Group[]>(rooms[r], tempGroups)));
                }
            }

            return res.ToArray();
        }

        private Group[] findGroups(string facultyName, int year)
        {
            List<Group> res = new List<Group>();
            foreach (Group group in groupsAll)
                if (group.Faculty.Name.Equals(facultyName) && group.Year == year)
                    res.Add(group);
            return res.ToArray();
        }

        private Group findGroup(string facultyName, int year, int groupNo)
        {
            foreach (Group group in groupsAll)
                if (group.Faculty.Name.Equals(facultyName) && group.Year == year && group.GroupNumber == groupNo)
                    return group;
            return null;
        }

        private void sortByFreeCells(TimeBase[] objects)
        {
            // sort teachers depending on their free time in descending order
            for (int n = 0; n < objects.Length - 1; n++)
            {
                int max = n;
                for (int m = n + 1; m < objects.Length; m++)
                    if (objects[m].FreeCells > objects[n].FreeCells)
                        max = m;

                if (max != n)
                {
                    TimeBase temp = objects[n];
                    objects[n] = objects[max];
                    objects[max] = temp;
                }
            }
        }

        private List<Point> getValidCrossPoints(TimeBase obj_a, TimeBase obj_b, int height)
        {
            Point[] points_a = obj_a.Timetable.getCells(), points_b = obj_b.Timetable.getCells();

            List<Point> res = new List<Point>();
            foreach (Point a in points_a)
                foreach (Point b in points_b)
                    if (a.X == b.X && a.Y == b.Y)
                        res.Add(a);

            if (height > 1)
                for (int n = 0; n < res.Count; n++)
                {
                    bool delete = false;
                    for (int h = 1; !delete && h < height; h++)
                        delete = findElementIndex(res, new Point(res[n].X, res[n].Y + h)) == -1;
                    if (delete)
                        res.RemoveAt(n--);
                }

            return res;
        }

        private void removeColumnFromList(List<Point> locs, int X)
        {
            for (int n = 0; n < locs.Count; n++)
            {
                if (locs[n].X == X)
                    locs.RemoveAt(n--);
            }
        }

        private int findElementIndex(List<Point> array, Point element)
        {
            for (int n = 0; n < array.Count; n++)
                if (array[n].Equals(element))
                    return n;
            return -1;
        }

        private void shuffleLocations<T> (List<T> array)
        {
            Random rand = new Random();

            T temp;
            for(int n = 0, index; n < array.Count; n++)
            {
                index = n + rand.Next(array.Count - n);

                temp = array[index];
                array[index] = array[n];
                array[n] = temp;
            }
        }

        private int[] bestMatchIndexes(List<Group> groupArr, int matchNum)
        {
            int count = (int)Math.Pow(2, groupArr.Count);
            int max = 0;

            List<int> temp = new List<int>();
            List<int> res = new List<int>();
            for (uint n = 1; n < count; n++)
            {
                int sum = 0;
                bool[] data = binary(n);
                temp.Clear();

                for (int m = 0; m < data.Length; m++)
                    if (data[m] && groupArr[m].Size != 0)
                    {
                        sum += groupArr[m].Size;
                        temp.Add(m);
                    }
                if (sum > max && sum <= matchNum)
                {
                    res.Clear();
                    foreach (int num in temp)
                        res.Add(num);
                    max = sum;
                }
            }

            return res.ToArray();
        }

        private bool[] binary(uint number)
        {
            List<bool> res = new List<bool>();
            while (number > 0)
            {
                res.Add(number % 2 == 1);
                number /= 2;
            }
            return res.ToArray();
        }

        private void loadTimetableToExcel(string name, int startRow, int startCol, Excel.Worksheet sheet, Table timetable, int CourseMode)
        {
            sheet.Cells[startRow, startCol].Value = name;

            for (int col = 0; col < Tools.building.Columns.Length; col++)
                sheet.Cells[startRow, col + startCol + 1].Value = Tools.building.Columns[col];

            for (int row = 0; row < Tools.building.Rows.Length; row++)
                sheet.Cells[row + startRow + 1, startCol].Value = Tools.building.Rows[row];

            // first set texts on cells
            CourseSession session;
            Excel.Range cell;
            for (int col = 0; col < Tools.building.Columns.Length; col++)
                for (int row = 0; row < Tools.building.Rows.Length; row++)
                {
                    session = timetable.Data[row, col];
                    if (session != null && !session.IsExcluded)
                    {
                        cell = sheet.Cells[row + startRow + 1, col + startCol + 1];
                        cell.Value = session.getStringName(CourseMode);
                        cell.Interior.Color = ColorTranslator.ToOle(session.Subject.Legend);
                        cell.RowHeight = CourseSession.getCellHeightFor(CourseMode);
                        cell.ColumnWidth = CourseSession.getCellWidthFor(CourseMode);
                        cell.WrapText = true;
                    }
                }
        }


        
        private void generateAcademic_Click(object sender, EventArgs e)
        {
            
        }

        private void generateTeacher_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object send, DoWorkEventArgs ev) =>
            {
                try
                {
                    for (int n = 0; n < Tools.teachers.Length; n++)
                    {
                        log("Generating timetables for teachers...", (int)(((double)n / (groupsAll.Length - 1)) * 100));

                        templateFile = new ExcelFile(Tools.templateFile);
                        Excel.Worksheet sheet = templateFile.Book.Worksheets[1];

                        loadTimetableToExcel(Tools.teachers[n].Name, 2, 2, sheet, Tools.teachers[n].Timetable, CourseSession.MODE_TEACHERS);

                        // save the file and clear out the template
                        templateFile.saveAs(teachersDirectory.FullName + @"\" + Tools.teachers[n].Name + ".xlsx");
                        templateFile.close();
                    }

                    log("Teachers' timetables have been successfully generated!", 100);

                    System.Threading.Thread.Sleep(500);
                    Process.Start("explorer.exe", teachersDirectory.FullName);
                }
                catch
                {
                    log("Failed to generate", 0);
                }
            };
            worker.RunWorkerAsync();
        }

        private void generateStudent_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object send, DoWorkEventArgs ev) =>
            {
                try
                {
                    for (int n = 0; n < groupsAll.Length; n++)
                    {
                        log("Generating timetables for students...", (int)(((double)n / (groupsAll.Length - 1)) * 100));

                        templateFile = new ExcelFile(Tools.templateFile);
                        Excel.Worksheet sheet = templateFile.Book.Worksheets[1];
                        string name = groupsAll[n].Faculty.Name + groupsAll[n].Year + groupsAll[n].GroupNumber;
                        loadTimetableToExcel(name, 2, 2, sheet, groupsAll[n].Timetable, CourseSession.MODE_STUDENTS);

                        // save the file and clear out the template
                        templateFile.saveAs(studentsDirectory.FullName + @"\" + Tools.acadYearFolderName + groupsAll[n].Year + @"\" + groupsAll[n].Faculty.School + @"\" + groupsAll[n].Faculty.Name + @"\" + name + ".xlsx");
                        templateFile.close();
                    }

                    log("Student timetables have been successfully generated!", 100);

                    System.Threading.Thread.Sleep(500);
                    Process.Start("explorer.exe", studentsDirectory.FullName);
                }
                catch
                {
                    log("Failed to generate", 0);
                }
            };
            worker.RunWorkerAsync();
        }



        private void createTemplateFile(int width, int height, ExcelFile template)
        {
            if (width < 3 || height < 3)
                throw new ApplicationException("Cannot set a width or height which is less than the size of template Excel File!");
            else if (width == 3 && height == 3)
            {
                template.saveAs(Tools.templateFile);
                templateFile.close();
                return;
            }

            ExcelFile res = new ExcelFile();

            Excel.Worksheet fromSheet = template.Book.Worksheets[1];
            Excel.Worksheet toSheet = res.Book.Worksheets[1];

            Excel.Range last = fromSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);

            log("Working with output template...", 0);

            const int startRow = 2, startCol = 2;
            const int endRow = 5, endCol = 5;
            int resEndRow, resEndCol;
            const int midRow = 4, midCol = 4;

            float add;

            // first fully copy the template
            float percent = 0;
            add = 20f / (endRow - startRow + 1);
            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                    cloneStyle(fromSheet.Cells[row, col], toSheet.Cells[row, col]);
                percent += add;
                log("Working with output template...", (int)percent);
            }

            log("Learning template patterns...", 20);

            // move the bottom edge (set the bottom row)
            add = 10f / (endCol - startCol + 1);
            resEndRow = startRow + height;
            for (int col = startCol; col <= endCol; col++)
            {
                cloneStyle(toSheet.Cells[endRow, col], toSheet.Cells[resEndRow, col]);
                percent += add;
                log("Learning template patterns...", (int)percent);
            }

            log("Working on table patterns...", 30);

            // copy out the middle to resulting file's middle rows
            add = 30f / (resEndRow - midRow);
            for (int row = midRow; row < resEndRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                    cloneStyle(toSheet.Cells[midRow, col], toSheet.Cells[row, col]);
                percent += add;
                log("Working on table patterns...", (int)percent);
            }

            log("Verifying the tables...", 60);

            // move the right edge (set the rightmost column)
            add = 10f / (resEndRow - startRow + 1);
            resEndCol = startCol + width;
            for (int row = startRow; row <= resEndRow; row++)
            {
                cloneStyle(toSheet.Cells[row, endCol], toSheet.Cells[row, resEndCol]);
                percent += add;
                log("Verifying the tables...", (int)percent);
            }

            log("Verifying the tables...", 70);

            // copy out the middle to resulting file's middle rows
            add = 20f / (resEndCol - midCol + 1);
            for (int col = midCol; col < resEndCol; col++)
            {
                for (int row = startRow; row <= resEndRow; row++)
                    cloneStyle(toSheet.Cells[row, midCol], toSheet.Cells[row, col]);
                percent += add;
                log("Verifying the tables...", (int)percent);
            }

            log("Finishing loading...", 90);

            cloneBorders(
                fromSheet.Range[fromSheet.Cells[startRow, startCol], fromSheet.Cells[endRow, endCol]], 
                toSheet.Range[toSheet.Cells[startRow, startCol], toSheet.Cells[resEndRow, resEndCol]]);
            template.close();

            res.saveAs(Tools.templateFile);
            res.close();
            log("Finished loading data!", 100);
        }
        private void cloneStyle(Excel.Range from, Excel.Range to)
        {
            cloneBorders(from, to);
            cloneColorsAndFonts(from, to);
            cloneSize(from, to);
            cloneAlignments(from, to);
        }
        private void cloneBorders(Excel.Range from, Excel.Range to)
        {
            to.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = from.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle;
            to.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = from.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle;
            to.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = from.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle;
            to.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = from.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle;

            to.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = from.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight;
            to.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = from.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight;
            to.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = from.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight;
            to.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = from.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight;
        }
        private void cloneColorsAndFonts(Excel.Range from, Excel.Range to)
        {
            to.Interior.Color = from.Interior.Color;

            to.Font.Color = from.Font.Color;
            to.Font.Name = from.Font.Name;
            to.Font.Size = from.Font.Size;
            to.Font.FontStyle = from.Font.FontStyle;
        }
        private void cloneSize(Excel.Range from, Excel.Range to)
        {
            to.ColumnWidth = from.ColumnWidth;
            to.RowHeight = from.RowHeight;
        }
        private void cloneAlignments(Excel.Range from, Excel.Range to)
        {
            to.HorizontalAlignment = from.HorizontalAlignment;
            to.VerticalAlignment = from.VerticalAlignment;
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to quit?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }
    }
}
