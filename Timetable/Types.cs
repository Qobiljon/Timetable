using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Timetable
{
    // Enter Names of students in a text file and the app fill automatically allocate each students in a specific timetable
    public class Base
    {
        public Base(string nam)
        {
            name = nam;

            bool add = true;
            foreach (Base obj in objects)
                if (obj.name.Equals(name))
                {
                    add = false;
                    break;
                }
            if (add)
                objects.Add(this);
        }

        ~Base()
        {
            objects.Remove(this);
        }

        protected int index;
        protected string name;
        public string Name { get { return name; } }
        public int Index { get { return index; } set { index = value; } }

        public static T find<T>(string name) where T : Base
        {
            foreach (Base obj in objects)
                if (obj.name.Equals(name))
                    return (T)obj;
            return null;
        }

        public static void releaseObjects()
        {
            objects.Clear();
        }

        protected static List<Base> objects = new List<Base>();
    }

    public class TimeBase : Base
    {
        public TimeBase(string name, Table timetable) : base(name)
        {
            this.timetable = timetable;
            FreeCells = timetable.countCells();
        }

        public Table Timetable { get { return timetable; } }

        protected Table timetable;
        public int FreeCells;
    }
    
    public class Building : Base
    {
        public Building(string name, int years, int periodCount, int periodLength, int height, int standardLessonDuration, bool contiguous, string[] rows, string[] cols, string[] schools, Faculty[] faculties, Room[] facilities) : base(name)
        {
            this.years = years;
            this.periodCount = periodCount;
            this.periodLength = periodLength;
            this.height = height;
            this.standardLessonDuration = standardLessonDuration;
            this.contiguous = contiguous;
            this.rows = rows;
            this.cols = cols;
            this.schools = schools;
            this.faculties = faculties;
            this.facilities = facilities;
        }

        public static Building fromFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(stream);
            string data = rd.ReadToEnd();
            rd.Close();
            stream.Close();

            return parse(data);
        }

        public static Building parse(string data)
        {
            string[] parts = Regex.Split(data, Tools.delimiter_rep4);
            string[] temp = Regex.Split(parts[0], Tools.delimiter);

            string type, name;
            type = temp[0];
            if(!type.Equals("Building"))
                throw new TypeLoadException("Not a BUILDING type of file is passed!");

            name = temp[1];
            int years = int.Parse(temp[2]);
            int periodCount = int.Parse(temp[3]);
            int periodLength = int.Parse(temp[4]);
            int height = int.Parse(temp[5]);
            int standardLessonDuration = int.Parse(temp[6]);
            bool contiguous = bool.Parse(temp[7]);
            string[] rows = Regex.Split(parts[1], Tools.delimiter);
            string[] columns = Regex.Split(parts[2], Tools.delimiter);
            string[] schools = Regex.Split(parts[3], Tools.delimiter);

            Faculty[] faculties = new Faculty[(temp = Regex.Split(parts[4], Tools.delimiter_rep2)).Length];
            for (int n = 0; n < faculties.Length; n++)
            {
                faculties[n] = Faculty.parse(temp[n]);
                faculties[n].Index = n;
            }

            Room[] facilities = new Room[(temp = Regex.Split(parts[5], Tools.delimiter_rep2)).Length];
            for (int n = 0; n < facilities.Length; n++)
            {
                facilities[n] = Room.parse(temp[n]);
                facilities[n].Index = n;
            }

            return new Building(name, years, periodCount, periodLength, height, standardLessonDuration, contiguous, rows, columns, schools, faculties, facilities);
        }

        public string toString()
        {
            string res = "Building" + Tools.delimiter + 
                name + Tools.delimiter + 
                years + Tools.delimiter +
                periodCount + Tools.delimiter +
                periodLength + Tools.delimiter +
                height + Tools.delimiter +
                standardLessonDuration + Tools.delimiter +
                contiguous + Tools.delimiter_rep4 + 
                Tools.concat("" + Tools.delimiter, rows) +
                Tools.delimiter_rep4 + Tools.concat("" + Tools.delimiter, cols) +
                Tools.delimiter_rep3;

            foreach (string sc in schools)
                res += Tools.delimiter + sc;
            res += Tools.delimiter_rep2;
            foreach (Faculty fc in faculties)
                res += Tools.delimiter_rep2 + fc.toString();
            res += Tools.delimiter_rep2;
            foreach (Room rm in facilities)
                res += Tools.delimiter_rep2 + rm.toString();

            return res;
        }

        public int Years { get { return years; } }
        public int PeriodCount { get { return periodCount; } }
        public int PeriodLength { get { return periodLength; } }
        public string[] Rows { get { return rows; } }
        public string[] Columns { get { return cols; } }
        public string[] Schools { get { return schools; } }
        public Faculty[] Faculties { get { return faculties; } }
        public Room[] Facilities { get { return facilities; } }
        public int Height { get { return height; } }
        public int StandardLessonDuration { get { return standardLessonDuration; } }
        public bool Contiguous { get { return contiguous; } }

        private int years;
        private int periodCount;
        private int periodLength;
        private int height;
        private int standardLessonDuration;
        private bool contiguous;
        private string[] rows;
        private string[] cols;
        private string[] schools;
        private Faculty[] faculties;
        private Room[] facilities;
    }

    public class Faculty : Base
    {
        public Faculty(string name, string school, List<int> studentCount) : base(name)
        {
            this.school = school;
            this.studentCount = studentCount;
        }

        public static Faculty fromFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(stream);
            string data = rd.ReadToEnd();
            rd.Close();
            stream.Close();

            return parse(data);
        }

        public static Faculty parse(string data)
        {
            string name = "", type = "";
            List<int> studentCount = new List<int>();
            string school;
            int index;

            type = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            if (!type.Equals("Faculty"))
                throw new TypeLoadException("Not a FACULTY type of file is passed!");
            data = data.Substring(index + 1);
            name = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            data = data.Substring(index + 1);
            school = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            data = data.Substring(index + 1);

            while (data.Length > 0){
                index = data.IndexOf(Tools.delimiter);
                if (index == -1)
                    break;
                studentCount.Add(int.Parse(data.Substring(0, index)));
                data = data.Substring(index + 1);
            }
            if (data != "")
                studentCount.Add(int.Parse(data));

            return new Faculty(name, school, studentCount);
        }

        public string toString()
        {
            if (studentCount.Count == 0)
                throw new ApplicationException("Student count for faculties are not typed in!");

            string res = "Faculty" + Tools.delimiter + name + Tools.delimiter + school;
            foreach (int sc in studentCount)
                res += Tools.delimiter + sc;
            return res;
        }

        public List<int> Students { get { return studentCount; } }
        public string School { get { return school; } }

        private string school;
        private List<int> studentCount;
    }

    public class Subject : Base
    {
        public Subject(string name, string school, int year, int minutesPerWeek, Color legend, Room[] facilities, Faculty[] faculties)
            : base(name)
        {
            // PREVENT THE EXCEPTION: DUPLICATE NAME (PRIMARY KEY IS THE NAME PROPERTY OF THE OBJECT)!
            this.name = name;
            this.school = school;
            this.year = year;
            this.minutesPerWeek = minutesPerWeek;
            this.legend = legend;
            this.facilities = facilities;
            this.faculties = faculties;
            teachers = new List<Teacher>();
        }

        public static Subject fromFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(stream);
            string data = rd.ReadToEnd();
            rd.Close();
            stream.Close();

            return parse(data);
        }

        public static Subject parse(string data)
        {
            string name, school, type;
            Room[] rooms;
            Faculty[] faculties;
            int year = 0;
            int hour = 0;
            Color legend;

            string[] parts = Regex.Split(data, Tools.delimiter_rep2);
            string[] temp = Regex.Split(parts[0], Tools.delimiter);
            type = temp[0];

            if (!type.Equals("Subject"))
                throw new TypeLoadException("Not a SUBJECT type of file is passed!");
            name = temp[1];
            school = temp[2];
            hour = int.Parse(temp[3]);
            year = int.Parse(temp[4]);
            legend = Color.FromArgb(int.Parse(temp[5]));

            
            temp = Regex.Split(parts[1], Tools.delimiter);
            rooms = new Room[temp.Length];
            for (int n = 0; n < rooms.Length; n++)
                rooms[n] = Room.find<Room>(temp[n]);
            
            temp = Regex.Split(parts[2], Tools.delimiter);
            faculties = new Faculty[temp.Length];
            for (int n = 0; n < faculties.Length; n++)
                faculties[n] = Faculty.find<Faculty>(temp[n]);

            return new Subject(name, school, year, hour, legend, rooms, faculties);
        }

        public string toString()
        {
            string res = "Subject" + 
                Tools.delimiter + name + 
                Tools.delimiter + school + 
                Tools.delimiter + minutesPerWeek + 
                Tools.delimiter + year + 
                Tools.delimiter + legend.ToArgb();
            res += Tools.delimiter;
            foreach (Room rm in facilities)
                res += Tools.delimiter + rm.Name;
            res += Tools.delimiter;
            foreach (Faculty fc in faculties)
                res += Tools.delimiter + fc.Name;
            return res;
        }

        public int Minutes { get { return minutesPerWeek; } }
        public int Year { get { return year;} }
        public string School { get { return school; } }
        public Faculty[] Faculties { get { return faculties; } }
        public Room[] Facilities { get { return facilities; } }
        public List<Teacher> Teachers { get { return teachers; } }
        public Color Legend { get { return legend; } }

        private int minutesPerWeek;
        private int year;
        private string school;
        private Faculty[] faculties;
        private Room[] facilities;
        private List<Teacher> teachers;
        private Color legend;
    }

    public class Teacher : TimeBase
    {
        public Teacher(string name, string school, string timePreference, Faculty[] faculties, Subject[] subjects, int hoursPerDay, Table timetable)
            : base(name, timetable)
        {
            this.school = school;
            this.timePreference = timePreference;
            this.faculties = faculties;
            this.subjects = subjects;
            this.hoursPerDay = hoursPerDay;
            this.timetable = timetable;
        }

        public static Teacher fromFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(stream);
            string data = rd.ReadToEnd();
            rd.Close();
            stream.Close();

            return parse(data);
        }

        public static Teacher parse(string data)
        {
            string name, school, timepreference, type;
            int hoursperday;
            string[] parts = Regex.Split(data, Tools.delimiter_rep2);
            string[] temp = Regex.Split(parts[0], Tools.delimiter);
            Faculty[] faculties;
            Subject[] subjects;
            Table timetable;

            type = temp[0];
            if (!type.Equals("Teacher"))
                throw new TypeLoadException("Not a TEACHER type of file is passed!");
            name = temp[1];
            school = temp[2];
            timepreference = temp[3];
            hoursperday = int.Parse(temp[4]);

            temp = Regex.Split(parts[1], Tools.delimiter);
            subjects = new Subject[temp.Length];
            for (int n = 0; n < subjects.Length; n++)
                subjects[n] = Subject.find<Subject>(temp[n]);

            temp = Regex.Split(parts[2], Tools.delimiter);
            faculties = new Faculty[temp.Length];
            for (int n = 0; n < faculties.Length; n++)
                faculties[n] = Faculty.find<Faculty>(temp[n]);

            timetable = Table.parse(parts[3], Tools.separator);

            return new Teacher(name, school, timepreference, faculties, subjects, hoursperday, timetable);
        }

        public string toString()
        {
            string res = "Teacher" + 
                Tools.delimiter + name + 
                Tools.delimiter + school + 
                Tools.delimiter + timePreference + 
                Tools.delimiter + hoursPerDay;
            res += Tools.delimiter;
            foreach (Subject sb in subjects)
                res += Tools.delimiter + sb.Name;
            res += Tools.delimiter;
            foreach (Faculty fc in faculties)
                res += Tools.delimiter + fc.Name;
            res += Tools.delimiter_rep2 + timetable.toString(Tools.separator);
            return res;
        }

        public int Hours { get { return hoursPerDay; } }
        
        public string School { get { return school; } }
        public Subject[] Subjects { get { return subjects; } }
        public string TimePreference { get { return timePreference; } }

        private string school;
        private string timePreference;
        private int hoursPerDay;
        private Subject[] subjects;
        private Faculty[] faculties;

        public const string MORNING = "morning", EVENING = "evening", NOON = "noon", ANYTIME = "anytime";
    }
    
    public class Room : TimeBase
    {
        public Room(string name, string type, string school, int fullCapacity, int allowPercentage, Table timetable)
            : base(name, timetable)
        {
            this.school = school;
            this.type = type;
            this.timetable = timetable;
            this.fullCapacity = fullCapacity;
            this.allowPercentage = allowPercentage;
        }

        public static Room parse(string data)
        {
            string name = "", type = "";
            string school;
            int fullCapacity;
            int allowPercentage;
            Table timetable;
            int index;

            type = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            if (!type.Equals("Room"))
                throw new TypeLoadException("Not a ROOM type of file is passed!");
            data = data.Substring(index + 1);
            name = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            data = data.Substring(index + 1);
            type = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            data = data.Substring(index + 1);
            school = data.Substring(0, index = data.IndexOf(Tools.delimiter));
            data = data.Substring(index + 1);
            fullCapacity = int.Parse(data.Substring(0, index = data.IndexOf(Tools.delimiter)));
            data = data.Substring(index + 1);
            allowPercentage = int.Parse(data.Substring(0, index = data.IndexOf(Tools.delimiter)));  
            data = data.Substring(index + 1);
            timetable = Table.parse(data, Tools.separator);
            
            return new Room(name, type, school, fullCapacity, allowPercentage, timetable);
        }

        public string toString()
        {
            string res = "Room" + 
                Tools.delimiter + name +
                Tools.delimiter + type + 
                Tools.delimiter + school + 
                Tools.delimiter + fullCapacity + 
                Tools.delimiter + allowPercentage;
            
            res += Tools.delimiter + timetable.toString(Tools.separator);
            return res;
        }

        public int AllowCapacity { get { return (allowPercentage * fullCapacity / 100); } }
        public int FullCapacity { get { return fullCapacity; } }
        public string School { get { return school; } }
        public string Type { get { return type;} }


        private int fullCapacity;
        private int allowPercentage;
        private string school;
        private string type;
    }

    public class Student : Base
    {
        public Student(string firstName, string lastName, string id, string school, int year, Faculty faculty, Subject[] subjects)
            : base(firstName + " " + lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.school = school;
            this.faculty = faculty;
            this.year = year;
            this.subjects = subjects;
        }

        public static Student fromFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader rd = new StreamReader(stream);
            string data = rd.ReadToEnd();
            rd.Close();
            stream.Close();

            return parse(data);
        }

        public static Student parse(string data)
        {
            string type;
            string firstName, lastName, id, school;
            int year;
            Faculty faculty;
            Subject[] subjects;

            string[] parts = Regex.Split(data, Tools.delimiter_rep2);
            string[] temp = Regex.Split(parts[0], Tools.delimiter);

            type = temp[0];
            if(!type.Equals("Student"))
                throw new TypeLoadException("Not a STUDENT type of file is passed!");
            firstName = temp[1];
            lastName = temp[2];
            id = temp[3];
            school = temp[4];
            year = int.Parse(temp[5]);
            faculty = Faculty.parse(parts[1]);

            temp = Regex.Split(parts[2], Tools.delimiter);
            subjects = new Subject[temp.Length];
            for (int n = 0; n < subjects.Length; n++)
                subjects[n] = Subject.find<Subject>(temp[n]);

            return new Student(firstName, lastName, id, school, year, faculty, subjects);
        }

        public string toString()
        {
            string res = "Student" +
                Tools.delimiter + firstName +
                Tools.delimiter + lastName +
                Tools.delimiter + id +
                Tools.delimiter + school +
                Tools.delimiter + year +
                Tools.delimiter_rep2 + faculty.toString();

            res += Tools.delimiter;
            foreach (Subject sb in subjects)
                res += Tools.delimiter + sb.Name;

            return res;
        }

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string Id { get { return id; } }
        public string School { get { return school; } }
        public Faculty Faculty { get { return faculty; } }
        public int Year { get { return year; } }
        public Subject[] Subjects { get { return subjects; } }

        private string firstName;
        private string lastName;
        private string id;
        private string school;
        private Faculty faculty;
        private int year;
        private Subject[] subjects;
    }

    public class Group
    {
        public Group(Faculty faculty, int year, int size, int groupNumber)
        {
            this.faculty = faculty;
            this.year = year;
            this.size = size;
            this.groupNumber = groupNumber;

            timetable = new Table("table", Tools.building.Columns, Tools.building.Rows);
        }

        public Faculty Faculty { get { return faculty; } }
        public int Year { get { return year; } }
        public int Size { get { return size; } }
        public Table Timetable { get { return timetable; } }
        public int GroupNumber { get { return groupNumber; } }

        private Faculty faculty;
        private Table timetable;
        private int year;
        private int size;
        private int groupNumber;
    }

    public class CourseSession
    {
        private CourseSession(int mode)
        {
            switch (mode)
            {
                case MODE_EXCLUDE_SESSION:
                    isExcluded = true;
                    break;
                default:
                    break;
            }
        }

        public CourseSession(Teacher teacher, Subject subject, Room room, Group[] groups)
        {
            isExcluded = false;
            this.teacher = teacher;
            this.subject = subject;
            this.room = room;
            this.groups = groups;
        }

        public static CourseSession Excluded { get { return new CourseSession(MODE_EXCLUDE_SESSION); } }
        public bool IsExcluded { get { return isExcluded; } }
        public Teacher Teacher { get { return teacher; } }
        public Subject Subject { get { return subject; } }
        public Room Room { get { return room; } }
        public Group[] Groups { get { return groups; } }


        public string getStringName(int mode)
        {
            switch (mode)
            {
                case MODE_STUDENTS:
                    return subject.Name + Environment.NewLine + room.Name + Environment.NewLine + teacher.Name;
                case MODE_TEACHERS:
                    {
                        string res = subject.Name + Environment.NewLine + room.Name + Environment.NewLine + Environment.NewLine + "Groups:";
                        foreach (Group group in groups)
                            res += Environment.NewLine + group.Faculty.Name + group.Year + group.GroupNumber;
                        return res;
                    }
                default:
                    {
                        string res = subject.Name + Environment.NewLine + room.Name + Environment.NewLine + teacher.Name + Environment.NewLine + Environment.NewLine + "Groups:";
                        foreach (Group group in groups)
                            res += Environment.NewLine + group.Faculty.Name + group.Year + group.GroupNumber;
                        return res;
                    }
            }
        }
        public static int getCellWidthFor(int mode)
        {
            switch (mode)
            {
                case MODE_STUDENTS:
                    return 18;
                case MODE_TEACHERS:
                    return 20;
                default:
                    return 22;
            }
        }
        public static int getCellHeightFor(int mode)
        {
            switch (mode)
            {
                case MODE_STUDENTS:
                    return 60;
                case MODE_TEACHERS:
                    return 130;
                default:
                    return 140;
            }
        }



        private bool isExcluded;
        private const int MODE_EXCLUDE_SESSION = 0;

        private Teacher teacher;
        private Subject subject;
        private Room room;
        private Group[] groups;

        public const int MODE_STUDENTS = 0;
        public const int MODE_TEACHERS = 1;
    }

    public class Time{
        public Time(int hour, int minute){
            this.hour = hour;
            this.minute = minute;
        }

        public static Time parse(string str)
        {
            int index = str.IndexOf(':');
            int hr = int.Parse(str.Substring(0, index));
            int mn = int.Parse(str.Substring(index + 1));
            return new Time(hr, mn);
        }

        public string toString()
        {
            return hour + ":" + minute;
        }

        int hour, minute;
        public int Hour { get{return hour; } }
        public int Minute { get{return minute; } }
    }

    public class TimeSlice{
        public TimeSlice(Time start, Time end){
            this.start = start;
            this.end = end;
        }

        public static TimeSlice parse(string str)
        {
            int index = str.IndexOf('-');
            Time st = Time.parse(str.Substring(0, index));
            Time en = Time.parse(str.Substring(index + 1));
            return new TimeSlice(st, en);
        }

        public string toString()
        {
            return start.toString() + '-' + end.toString();
        }

        public Time Start { get { return start; } }
        public Time End { get { return end; } }

        private Time start;
        private Time end;
    }

    public class NameValuePair<T>
    {
        public NameValuePair(string name, T value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name { get { return name; } set { name = value; } }
        public T Value { get { return value; } set { this.value = value; } }

        private string name;
        T value;
    }

    public class Pair<T1, T2>
    {
        public Pair(T1 object1, T2 object2)
        {
            a = object1;
            b = object2;
        }

        public T1 A { get { return a; } set { a = value; } }
        public T2 B { get { return b; } set { b = value; } }

        private T1 a;
        private T2 b;
    }

    public class Triple<T1, T2, T3>
    {
        public Triple(T1 object1, T2 object2, T3 object3)
        {
            a = object1;
            b = object2;
            c = object3;
        }

        public T1 A { get { return a; } }
        public T2 B { get { return b; } }
        public T3 C { get { return c; } }

        private T1 a;
        private T2 b;
        private T3 c;
    }
}
