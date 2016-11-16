using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Timetable
{
    class Tools
    {
        public const string delimiter = "■";
        public const string acadYearFolderName = "Academic Year ";

        public static string delimiter_rep2 = delimiter + delimiter;
        public static string delimiter_rep3 = delimiter + delimiter + delimiter;
        public static string delimiter_rep4 = delimiter + delimiter + delimiter + delimiter;
        public static string delimiter_rep5 = delimiter + delimiter + delimiter + delimiter + delimiter;

        public static string inputFolder = "";
        public static string outputFolder = "";
        public static string projectFilePath = "";
        public static string projectFolderPath = "";
        public static string buildFolderPath = "";
        public static string separator = ",";

        #region BUILDING INFORMATION
        public static Building building;
        #endregion

        #region TEACHER INFORMATION
        public static Teacher[] teachers;
        #endregion

        #region SUBJECTS INFORMATION
        public static Subject[] subjects;
        #endregion

        #region STUDENTS INFORMATION
        public static Student[] students;
        #endregion

        public static string prototypeTableFile = @AppDomain.CurrentDomain.BaseDirectory + @"\Templates\Table.xlsx";
        public static string templateFile = @Path.GetTempPath() + Environment.TickCount + ".xlsx";

        public static Teacher[] getTeachers(Subject subject)
        {
            List<Teacher> res = new List<Teacher>();
            foreach (Teacher tc in teachers)
                foreach(Subject sb in tc.Subjects)
                    if (sb.Name.Equals(subject.Name))
                    {
                        res.Add(tc);
                        break;
                    }
            return res.ToArray();
        }

        public static void writeToFile(string path, string content, bool scramble)
        {
            StreamWriter wr = new StreamWriter(path, false);
            wr.Write(scramble ? encode(content) : content);
            wr.Close();
        }

        public static int getIntFromString(string data)
        {
            int res = 0;
            MatchCollection matches = Regex.Matches(data, "[0-9]");
            foreach (Match match in matches)
                res = res * 10 + int.Parse(match.Value);
            return res;
        }

        private static string encode(string data)
        {
            string res = "";
            return res;
        }

        private static string decode(string data)
        {
            string res = "";
            return res;
        }

        public static string concat(string sep, params string[] values)
        {
            if (values.Length == 0)
                return "";
            string res = values[0];
            for (int n = 1; n < values.Length; n++)
                res += sep + values[n];
            return res;
        }

        public static string readFromFile(string path)
        {
            StreamReader rd = new StreamReader(path);
            string res = "";
            res = rd.ReadToEnd().Replace("\0", "");
            rd.Close();
            return res;
        }

        public static string getTimeFromMinutes(int minutes)
        {
            int hours = minutes / 60;
            minutes %= 60;

            string res = hours == 0 ? "" : (hours + " Hours");
            res += minutes == 0 ? "" : res.Equals("") ? (minutes + " Minutes") : (", " + minutes + " Minutes");
            return res;
        }

        public static int getMinutesFromString(string data)
        {
            int res = 0;
            string hrs = Regex.Match(data, "[0-9]* Hours").Value;
            string min = Regex.Match(data, "[0-9]* Minutes").Value;
            if (!hrs.Equals(""))
                res += Tools.getIntFromString(hrs) * 60;
            if (!min.Equals(""))
                res += Tools.getIntFromString(min);
            return res;
        }

        internal static void initializeBackend()
        {
            //TODO: 
        }
    }
}
