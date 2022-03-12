using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.Model
{
    public class TeacherModel: NotifyBase
    {
        private string teaid;

        public string TeaID
        {
            get { return teaid; }
            set { teaid = value; this.Donotify(); }
        }

        private string teaname;

        public string TeaName
        {
            get { return teaname; }
            set { teaname = value; this.Donotify(); }
        }

        private string teasex;

        public string TeaSex
        {
            get { return teasex; }
            set { teasex = value; this.Donotify(); }
        }


        private int teaage;

        public int TeaAge
        {
            get { return teaage; }
            set { teaage = value; this.Donotify(); }
        }



        private string teaidcard;

        public string TeaIDcard
        {
            get { return teaidcard; }
            set { teaidcard = value; this.Donotify(); }
        }

        private string teaphone;

        public string TeaPhone
        {
            get { return teaphone; }
            set { teaphone = value; this.Donotify(); }
        }
    }
}
