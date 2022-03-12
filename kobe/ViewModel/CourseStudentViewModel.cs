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
    public class CourseStudentViewModel : NotifyBase
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

        public CommandBase AddCourseStudentInfoCommand { get; set; }

        public CommandBase DeleteCourseStudentInfoCommand { get; set; }

        public ObservableCollection<CourseModel> courselist { get; set; }

        public ObservableCollection<StudentModel> studentlist { get; set; }

        public ObservableCollection<CourseStudentModel> coursestudentlist { get; set; }
        private List<CourseStudentModel> coursestudentall;

        public CourseStudentViewModel()
        {
            this.initCourseStudentInfo();

            this.initCourseInfo();

            this.initStudentInfo();


            this.AddCourseStudentInfoCommand = new CommandBase();
            this.AddCourseStudentInfoCommand.DoExecute = new Action<object>(AddCourseStudentInfo);
            this.AddCourseStudentInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //this.DeleteCourseTeacherInfoCommand = new CommandBase();
            //this.DeleteCourseTeacherInfoCommand.DoExecute = new Action<object>(DeleteCourseInfo);
            //this.DeleteCourseTeacherInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initCourseStudentInfo()
        {
            coursestudentall = LocalDataAccess.GetInstance().GetCourseStudentInfo();
            coursestudentlist = new ObservableCollection<CourseStudentModel>(coursestudentall);
        }

        public void initCourseInfo()
        {
            courselist = new ObservableCollection<CourseModel>();
            var clist = LocalDataAccess.GetInstance().GetCourseInfo();
            foreach (var item in clist)
                courselist.Add(item);
        }

        public void initStudentInfo()
        {
            studentlist = new ObservableCollection<StudentModel>();
            var slist = LocalDataAccess.GetInstance().GetStudentInfo();
            foreach (var item in slist)
                studentlist.Add(item);
        }

        public void AddCourseStudentInfo(object o)
        {
            this.ErrorMessage = "";

            var IsAdd = LocalDataAccess.GetInstance().AddCourseStudentInfo(CourseStudentModel);
            if (IsAdd)
            {
                this.ErrorMessage = "新增成功";
            }
            else
            {
                this.ErrorMessage = "新增失败";
            }
            var cslist = LocalDataAccess.GetInstance().GetCourseStudentInfo().ToList();
            coursestudentlist.Clear();
            foreach (var item in cslist)
                coursestudentlist.Add(item);
        }


    }
}
