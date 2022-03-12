using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.Model
{
    public class CourseModel: NotifyBase
    {

        private string courseid;
        public string CourseID
        {
            get { return courseid; }
            set { courseid = value; this.Donotify(); }
        }

        private string coursename;

        public string CourseName
        {
            get { return coursename; }
            set { coursename = value; this.Donotify(); }
        }

        private int coursehour;

        public int CourseHour
        {
            get { return coursehour; }
            set { coursehour = value; this.Donotify(); }
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

        private string coursetype;

        public string CourseType
        {
            get { return coursetype; }
            set { coursetype = value; }
        }

        private string courseteaid;

        public string CourseTeaId
        {
            get { return courseteaid; }
            set { courseteaid = value; }
        }

    }
}
