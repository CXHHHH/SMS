using kobe.Common;
using kobe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.ViewModel
{
    public class FirstPageViewModel : NotifyBase
    {
        private string _searchtext;
        public string SearchText
        {
            get { return _searchtext; }
            set { _searchtext = value; this.Donotify(); }
        }



        public FirstPageViewModel()
        {
           
        }


    }
}
