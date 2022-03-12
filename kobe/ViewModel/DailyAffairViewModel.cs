using kobe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kobe.ViewModel
{
    public class DailyAffairViewModel: NotifyBase
    {
        private FrameworkElement _datacontent;

        public FrameworkElement DataContent
        {
            get { return _datacontent; }
            set { _datacontent = value; this.Donotify(); }
        }

        public CommandBase NavChangedCommand { get; set; }

        public DailyAffairViewModel()
        {
            this.NavChangedCommand = new CommandBase();
            this.NavChangedCommand.DoExecute = new Action<object>(DoNavChanged);
            this.NavChangedCommand.DoCanExecute = new Func<object, bool>((o) => true);

            DoNavChanged("StudentAttendancePageView");
        }

        private void DoNavChanged(object obj)
        {
            Type type = Type.GetType("kobe.View." + obj.ToString());
            ConstructorInfo cti = type.GetConstructor(System.Type.EmptyTypes);
            this.DataContent = (FrameworkElement)cti.Invoke(null);
        }

    }
}
