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
    public class CourseDataViewModel: NotifyBase
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

        public CourseModel CourseModel { get; set; } = new CourseModel();

        public CommandBase AddCourseInfoCommand { get; set; }

        public CommandBase DeleteCourseInfoCommand { get; set; }

        public ObservableCollection<CourseModel> courselist { get; set; }
        private List<CourseModel> courseall;


        public CourseDataViewModel()
        {
            this.initCourseInfo();

            this.AddCourseInfoCommand = new CommandBase();
            this.AddCourseInfoCommand.DoExecute = new Action<object>(AddCourseInfo);
            this.AddCourseInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            this.DeleteCourseInfoCommand = new CommandBase();
            this.DeleteCourseInfoCommand.DoExecute = new Action<object>(DeleteCourseInfo);
            this.DeleteCourseInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initCourseInfo()
        {
            courseall = LocalDataAccess.GetInstance().GetCourseInfo();
            courselist = new ObservableCollection<CourseModel>(courseall);
        }



        public void AddCourseInfo(object o)
        {
            this.ErrorMessage = "";
            var IsAdd = LocalDataAccess.GetInstance().AddCourseInfo(CourseModel);
            if (IsAdd)
            {
                this.ErrorMessage = "新增成功";
            }
            else
            {
                this.ErrorMessage = "新增失败";
            }
            var clist = LocalDataAccess.GetInstance().GetCourseInfo().ToList();
            courselist.Clear();
            foreach (var item in clist)
                courselist.Add(item);
        }

        public void DeleteCourseInfo(object o)
        {
            this.ErrorMessage = "";
            var IsDel = LocalDataAccess.GetInstance().DeleteCourseInfo(o.ToString());
            if (IsDel)
            {
                this.ErrorMessage = "删除成功";
            }
            else
            {
                this.ErrorMessage = "删除失败";
            }
            var clist = LocalDataAccess.GetInstance().GetCourseInfo().ToList();
            courselist.Clear();
            foreach (var item in clist)
                courselist.Add(item);
        }
    }
}
