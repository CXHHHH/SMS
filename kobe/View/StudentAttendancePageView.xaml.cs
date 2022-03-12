using kobe.Model;
using kobe.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kobe.View
{
    /// <summary>
    /// StudentAttendancePageView.xaml 的交互逻辑
    /// </summary>
    /// 
    public partial class StudentAttendancePageView : UserControl
    {
        string teacher = "全部";
        string weektime = "全部";

        StudentAttendanceViewModel ss = new StudentAttendanceViewModel();
        public StudentAttendancePageView()
        {
            InitializeComponent();

            this.DataContext = ss;
        }

        private void Teacher_Click(object sender, RoutedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            teacher = button.Content.ToString();

            ss.filterCourseStudentInfo(teacher, weektime);

        }

        private void Weektime_Click(object sender, RoutedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            weektime = button.Content.ToString();

            ss.filterCourseStudentInfo(teacher, weektime);
        }

    }
}
