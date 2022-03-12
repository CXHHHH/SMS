using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.Model
{
    public class UserModel:NotifyBase
    {
        private string _avatar;

        public string Avatar
        {
            get { return _avatar; }
            set { _avatar = value; this.Donotify(); }
        }

        private string _username;

        public string UserName
        {
            get { return _username; }
            set { _username = value; this.Donotify(); }
        }

        private int _gender;

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; this.Donotify(); }
        }
    }
}
