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
    public class StudentGradeViewModel : NotifyBase
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

        public CommandBase AddStudentGradeInfoCommand { get; set; }

        public CommandBase DeleteStudentGradeInfoCommand { get; set; }

        public GradeModel GradeModel { get; set; } = new GradeModel();

        public ObservableCollection<CourseModel> courselist { get; set; }

        public ObservableCollection<StudentModel> studentlist { get; set; }

        public ObservableCollection<GradeModel> studentgradelist { get; set; }
        private List<GradeModel> studentgradeall;

        public StudentGradeViewModel()
        {
            this.initStudentGradeInfo();

            this.initCourseInfo();

            this.initStudentInfo();


            this.AddStudentGradeInfoCommand = new CommandBase();
            this.AddStudentGradeInfoCommand.DoExecute = new Action<object>(AddStudentGradeInfo);
            this.AddStudentGradeInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            this.DeleteStudentGradeInfoCommand = new CommandBase();
            this.DeleteStudentGradeInfoCommand.DoExecute = new Action<object>(DeleteGradeInfo);
            this.DeleteStudentGradeInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initStudentGradeInfo()
        {
            studentgradeall = LocalDataAccess.GetInstance().GetStudentGradeInfo();
            studentgradelist = new ObservableCollection<GradeModel>(studentgradeall);
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

        public void AddStudentGradeInfo(object o)
        {
            this.ErrorMessage = "";

            var IsAdd = LocalDataAccess.GetInstance().AddStudentGradeInfo(GradeModel);
            if (IsAdd)
            {
                this.ErrorMessage = "新增成功";
            }
            else
            {
                this.ErrorMessage = "新增失败";
            }
            var glist = LocalDataAccess.GetInstance().GetStudentGradeInfo().ToList();
            studentgradelist.Clear();
            foreach (var item in glist)
                studentgradelist.Add(item);
        }

        public void DeleteGradeInfo(object o)
        {
            this.ErrorMessage = "";

            var IsDel = LocalDataAccess.GetInstance().DeleteGradeInfo(o.ToString());
            if (IsDel)
            {
                this.ErrorMessage = "删除成功";
            }
            else
            {
                this.ErrorMessage = "删除失败";
            }
            var glist = LocalDataAccess.GetInstance().GetStudentGradeInfo().ToList();
            studentgradelist.Clear();
            foreach (var item in glist)
                studentgradelist.Add(item);
        }
    }
}
