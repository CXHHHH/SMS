using kobe.Common;
using kobe.DataAccess;
using kobe.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;

namespace kobe.ViewModel
{
    public class StudentAttendanceViewModel : NotifyBase
    {
        public ObservableCollection<CategoryItemModel> CategoryWorkTime { get; set; }
        public ObservableCollection<CategoryItemModel> CategoryTeacher { get; set; }

        string tempteacher="全部";
        public ObservableCollection<CourseStudentModel> coursestudentlist { get; set; }
        private List<CourseStudentModel> coursestudentall;

        public ObservableCollection<CourseStudentModel> attendstudentlist { get; set; }
        private List<CourseStudentModel> attendstudentall;

        public CourseStudentModel CourseStudentModel { get; set; } = new CourseStudentModel();
        

        public CommandBase AddStudentAttendCommand { get; set; }
        public void initCourseStudentInfo(string teacher, string weektime)
        {
            coursestudentall = LocalDataAccess.GetInstance().GetStuTeaCourseInfo(teacher, weektime);
            coursestudentlist = new ObservableCollection<CourseStudentModel>(coursestudentall);
        }

        public void initAttendStudentInfo(string teacher)
        {
            attendstudentall = LocalDataAccess.GetInstance().GetStuAttendInfo(teacher);
            attendstudentlist = new ObservableCollection<CourseStudentModel>(attendstudentall);
        }

        public void filterCourseStudentInfo(string teacher, string weektime)
        {
            tempteacher = teacher;

            var cslist = LocalDataAccess.GetInstance().GetStuTeaCourseInfo(teacher, weektime).ToList();
            coursestudentlist.Clear();
            foreach (var item in cslist)
                coursestudentlist.Add(item);

            var aslist = LocalDataAccess.GetInstance().GetStuAttendInfo(teacher).ToList();
            attendstudentlist.Clear();
            foreach (var item in aslist)
                attendstudentlist.Add(item);
        }
        public StudentAttendanceViewModel()
        {
            this.InitCategory();
            this.initCourseStudentInfo("全部","全部");
            this.initAttendStudentInfo("全部");

            this.AddStudentAttendCommand = new CommandBase();
            this.AddStudentAttendCommand.DoExecute = new Action<object>(AddStudentAttendInfo);
            this.AddStudentAttendCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

        }

        public void AddStudentAttendInfo(object o)
        {


            JavaScriptSerializer jsonser = new JavaScriptSerializer();
            string myJson = jsonser.Serialize(o);
            //到上面步骤已经完成了object转化json，接下来由json转化自定model
            CourseStudentModel = JsonConvert.DeserializeObject<CourseStudentModel>(myJson);

            var IsAdd=LocalDataAccess.GetInstance().AddStudentAttendInfo(CourseStudentModel);

            if (IsAdd)
            {
                var aslist = LocalDataAccess.GetInstance().GetStuAttendInfo(tempteacher).ToList();
                attendstudentlist.Clear();
                foreach (var item in aslist)
                    attendstudentlist.Add(item);
            }


        }

        private void DoNavChanged(object obj)
        {
            string teacher= obj.ToString();
        }

        private void InitCategory()
        {

            this.CategoryWorkTime = new ObservableCollection<CategoryItemModel>();
            this.CategoryWorkTime.Add(new CategoryItemModel("全部", true));
            this.CategoryWorkTime.Add(new CategoryItemModel("周一"));
            this.CategoryWorkTime.Add(new CategoryItemModel("周二"));
            this.CategoryWorkTime.Add(new CategoryItemModel("周三"));
            this.CategoryWorkTime.Add(new CategoryItemModel("周四"));
            this.CategoryWorkTime.Add(new CategoryItemModel("周五"));
            this.CategoryWorkTime.Add(new CategoryItemModel("周六"));
            this.CategoryWorkTime.Add(new CategoryItemModel("周日"));


            this.CategoryTeacher = new ObservableCollection<CategoryItemModel>();
            this.CategoryTeacher.Add(new CategoryItemModel("全部", true));
            foreach (var item in LocalDataAccess.GetInstance().GetTeacherName())
                this.CategoryTeacher.Add(new CategoryItemModel(item));
        }


    }
}
