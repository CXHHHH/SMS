using kobe.Common;
using kobe.DataAccess;
using kobe.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kobe.ViewModel
{
    public class CourseTeacherViewModel : NotifyBase
    {
        private string _searchtext;
        public string SearchText
        {
            get { return _searchtext; }
            set { _searchtext = value; this.Donotify(); }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; this.Donotify(); }
        }

        public CourseStudentModel CourseStudentModel { get; set; } = new CourseStudentModel();

        public CommandBase AddCourseTeacherInfoCommand { get; set; }

        public CommandBase DeleteCourseTeacherInfoCommand { get; set; }

        public ObservableCollection<CourseModel> courselist { get; set; }
        public ObservableCollection<TeacherModel> teacherlist { get; set; }

        public ObservableCollection<CourseStudentModel> courseteacherlist { get; set; }
        private List<CourseStudentModel> courseteacherall;

        public CourseTeacherViewModel()
        {
            this.initCourseTeacherInfo();

            this.initCourseInfo();

            this.initTeacherInfo();



            this.AddCourseTeacherInfoCommand = new CommandBase();
            this.AddCourseTeacherInfoCommand.DoExecute = new Action<object>(AddCourseTeacherInfo);
            this.AddCourseTeacherInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //this.DeleteCourseTeacherInfoCommand = new CommandBase();
            //this.DeleteCourseTeacherInfoCommand.DoExecute = new Action<object>(DeleteCourseInfo);
            //this.DeleteCourseTeacherInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initCourseTeacherInfo()
        {
            courseteacherall = LocalDataAccess.GetInstance().GetCourseTeacherInfo();
            courseteacherlist = new ObservableCollection<CourseStudentModel>(courseteacherall);
        }

        public void initCourseInfo()
        {
            courselist = new ObservableCollection<CourseModel>();
            var clist = LocalDataAccess.GetInstance().GetCourseInfo();
            foreach (var item in clist)
                courselist.Add(item);
        }

        public void initTeacherInfo()
        {
            teacherlist = new ObservableCollection<TeacherModel>();
            var tlist = LocalDataAccess.GetInstance().GetTeacherInfo();
            foreach (var item in tlist)
                teacherlist.Add(item);
        }

        public void AddCourseTeacherInfo(object o)
        {
            this.ErrorMessage = "";

            CourseStudentModel.CourseWeek = CourseStudentModel.CourseWeek.Replace("System.Windows.Controls.ComboBoxItem: ", "");
            CourseStudentModel.CourseClass = CourseStudentModel.CourseClass.Replace("System.Windows.Controls.ComboBoxItem: ", "");
            var IsAdd = LocalDataAccess.GetInstance().AddCourseTeacherInfo(CourseStudentModel);
            if (IsAdd)
            {
                this.ErrorMessage = "新增成功";
            }
            else
            {
                this.ErrorMessage = "新增失败";
            }
            var ctlist = LocalDataAccess.GetInstance().GetCourseTeacherInfo().ToList();
            courseteacherlist.Clear();
            foreach (var item in ctlist)
                courseteacherlist.Add(item);
        }

    }
}
