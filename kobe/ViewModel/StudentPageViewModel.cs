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
    public class StudentPageViewModel : NotifyBase
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

        public StudentModel StudentModel { get; set; } = new StudentModel();

        public CommandBase AddStudentInfoCommand { get; set; }

        public CommandBase DeleteStudentInfoCommand { get; set; }

        public ObservableCollection<StudentModel> studentlist { get; set; }
        public List<StudentModel> studentall;

        public StudentPageViewModel()
        {
            this.initStudentInfo();

            this.AddStudentInfoCommand = new CommandBase();
            this.AddStudentInfoCommand.DoExecute = new Action<object>(AddStudentInfo);
            this.AddStudentInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            this.DeleteStudentInfoCommand = new CommandBase();
            this.DeleteStudentInfoCommand.DoExecute = new Action<object>(DeleteStudentInfo);
            this.DeleteStudentInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initStudentInfo()
        {
            studentall = LocalDataAccess.GetInstance().GetStudentInfo();
            studentlist = new ObservableCollection<StudentModel>(studentall);
        }

        public void AddStudentInfo(object o)
        {
            this.ErrorMessage = "";
            StudentModel.StuClass = StudentModel.StuClass.Replace("System.Windows.Controls.ComboBoxItem: ", "");
            var IsAdd = LocalDataAccess.GetInstance().AddStudentInfo(StudentModel);
            if (IsAdd)
            {
                this.ErrorMessage = "新增成功";
            }
            else
            {
                this.ErrorMessage = "新增失败";
            }
            var slist = LocalDataAccess.GetInstance().GetStudentInfo().ToList();
            studentlist.Clear();
            foreach (var item in slist)
                studentlist.Add(item);
        }


        public void DeleteStudentInfo(object o)
        {
            this.ErrorMessage = "";

            var IsDel = LocalDataAccess.GetInstance().DeleteStudentInfo(o.ToString());
            if (IsDel)
            {
                this.ErrorMessage = "删除成功";
            }
            else
            {
                this.ErrorMessage = "删除失败";
            }
            var slist = LocalDataAccess.GetInstance().GetStudentInfo().ToList();
            studentlist.Clear();
            foreach (var item in slist)
                studentlist.Add(item);
        }

    }
}
