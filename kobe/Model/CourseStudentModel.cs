using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.Model
{
    public class CourseStudentModel : NotifyBase
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string courseid;
        public string CourseID
        {
            get { return courseid; }
            set { courseid = value; }
        }

        private string stuid;

        public string StuID
        {
            get { return stuid; }
            set { stuid = value;  }
        }

        private string stuname;

        public string StuName
        {
            get { return stuname; }
            set { stuname = value; }
        }

        private string coursename;

        public string CourseName
        {
            get { return coursename; }
            set { coursename = value; }
        }

        private string teaid;

        public string TeaId
        {
            get { return teaid; }
            set { teaid = value; }
        }

        private string teaname;

        public string TeaName
        {
            get { return teaname; }
            set { teaname = value; }
        }

        private string courseweek;

        public string CourseWeek
        {
            get { return courseweek; }
            set { courseweek = value; }
        }

        private string courseclass;

        public string CourseClass
        {
            get { return courseclass; }
            set { courseclass = value; }
        }

        private string attendtime;

        public string AttendTime
        {
            get { return attendtime; }
            set { attendtime = value; }
        }
    }
}
