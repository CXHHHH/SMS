using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.Model
{
    public class StudentModel : NotifyBase
    {
        private string stuid;

        public string StuID
        {
            get { return stuid; }
            set { stuid = value; this.Donotify(); }
        }

        private string stuname;

        public string StuName
        {
            get { return stuname; }
            set { stuname = value; this.Donotify(); }
        }

        private string stusex;

        public string StuSex
        {
            get { return stusex; }
            set { stusex = value; this.Donotify(); }
        }


        private int stuage;

        public int StuAge
        {
            get { return stuage; }
            set { stuage = value; this.Donotify(); }
        }

        private string stuclass;

        public string StuClass
        {
            get { return stuclass; }
            set { stuclass = value;  }
        }

        private string stuidcard;

        public string StuIDcard
        {
            get { return stuidcard; }
            set { stuidcard = value; this.Donotify(); }
        }

        private string stuphone;

        public string StuPhone
        {
            get { return stuphone; }
            set { stuphone = value; this.Donotify(); }
        }

    }
}
