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
    public class StudentAttendDetailViewModel : NotifyBase
    {
        public CourseStudentModel CourseStudentModel { get; set; } = new CourseStudentModel();

        public ObservableCollection<CourseStudentModel> studentattendlist { get; set; }
        private List<CourseStudentModel> studentattendall;

        public StudentAttendDetailViewModel()
        {
            this.initStudentAttendInfo();




            //this.DeleteStudentGradeInfoCommand = new CommandBase();
            //this.DeleteStudentGradeInfoCommand.DoExecute = new Action<object>(DeleteGradeInfo);
            //this.DeleteStudentGradeInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initStudentAttendInfo()
        {
            studentattendall = LocalDataAccess.GetInstance().GetStudetailAttendInfo();
            studentattendlist = new ObservableCollection<CourseStudentModel>(studentattendall);
        }


        //public void DeleteGradeInfo(object o)
        //{
        //    this.ErrorMessage = "";

        //    var IsDel = LocalDataAccess.GetInstance().DeleteGradeInfo(o.ToString());
        //    if (IsDel)
        //    {
        //        this.ErrorMessage = "删除成功";
        //    }
        //    else
        //    {
        //        this.ErrorMessage = "删除失败";
        //    }
        //    var glist = LocalDataAccess.GetInstance().GetStudentGradeInfo().ToList();
        //    studentgradelist.Clear();
        //    foreach (var item in glist)
        //        studentgradelist.Add(item);
        //}
    }
}
