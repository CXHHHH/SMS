using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kobe.Common;

namespace kobe.Model
{
    public class LoginModel:NotifyBase
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set 
            {
                _userName = value;
                this.Donotify();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                this.Donotify();
            }
        }

        private string _validationCode;

        public string VaildationCode
        {
            get { return _validationCode; }
            set 
            { 
                _validationCode = value;
                this.Donotify();
            }
        }



    }
}
