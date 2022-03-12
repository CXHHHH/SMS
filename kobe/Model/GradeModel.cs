using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.Model
{
    public class GradeModel : NotifyBase
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
            set { stuid = value; }
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

        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private string testlevel;

        public string TestLevel
        {
            get { return testlevel; }
            set { testlevel = value; }
        }



    }
}
