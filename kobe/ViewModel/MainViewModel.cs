using kobe.Common;
using kobe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kobe.ViewModel
{
    public class MainViewModel:NotifyBase
    {
        public UserModel UserInfo { get; set; }

        private string _searchtext;

        public string SearchText
        {
            get { return _searchtext; }
            set { _searchtext = value; this.Donotify(); }
        }

        private FrameworkElement _maincontent;

        public FrameworkElement MainContent
        {
            get { return _maincontent; }
            set { _maincontent = value; this.Donotify(); }
        }

        public CommandBase NavChangedCommand { get; set; }

        public MainViewModel()
        {
            UserInfo = new UserModel();
            this.NavChangedCommand = new CommandBase();
            this.NavChangedCommand.DoExecute = new Action<object>(DoNavChanged);
            this.NavChangedCommand.DoCanExecute = new Func<object, bool>((o) => true);

            DoNavChanged("FirstPageView");
        }

        private void DoNavChanged(object obj)
        {
            Type type = Type.GetType("kobe.View." + obj.ToString());
            ConstructorInfo cti = type.GetConstructor(System.Type.EmptyTypes);
            this.MainContent = (FrameworkElement)cti.Invoke(null);
        }
    }
}
