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
    public class TeacherDataViewModel: NotifyBase
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

        public TeacherModel TeacherModel { get; set; } = new TeacherModel();

        public CommandBase AddTeacherInfoCommand { get; set; }

        public CommandBase DeleteTeacherInfoCommand { get; set; }

        public ObservableCollection<TeacherModel> teacherlist { get; set; }

        private List<TeacherModel> teacherall;
        public TeacherDataViewModel()
        {
            this.initTeacherInfo();

            this.AddTeacherInfoCommand = new CommandBase();
            this.AddTeacherInfoCommand.DoExecute = new Action<object>(AddTeacherInfo);
            this.AddTeacherInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });


            this.DeleteTeacherInfoCommand = new CommandBase();
            this.DeleteTeacherInfoCommand.DoExecute = new Action<object>(DeleteTeacherInfo);
            this.DeleteTeacherInfoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        public void initTeacherInfo()
        {
            teacherall = LocalDataAccess.GetInstance().GetTeacherInfo();
            teacherlist = new ObservableCollection<TeacherModel>(teacherall);
        }

        public void AddTeacherInfo(object o)
        {
            this.ErrorMessage = "";
            var IsAdd = LocalDataAccess.GetInstance().AddTeacherInfo(TeacherModel);
            if (IsAdd)
            {
                this.ErrorMessage = "新增成功";
            }
            else
            {
                this.ErrorMessage = "新增失败";
            }
            var tlist = LocalDataAccess.GetInstance().GetTeacherInfo().ToList();
            teacherlist.Clear();
            foreach (var item in tlist)
                teacherlist.Add(item);

        }
        public void DeleteTeacherInfo(object o)
        {
            this.ErrorMessage = "";
            var IsDel = LocalDataAccess.GetInstance().DeleteTeacherInfo(o.ToString());
            if (IsDel)
            {
                this.ErrorMessage = "删除成功";
            }
            else
            {
                this.ErrorMessage = "删除失败";
            }
            var tlist = LocalDataAccess.GetInstance().GetTeacherInfo().ToList();
            teacherlist.Clear();
            foreach (var item in tlist)
                teacherlist.Add(item);

        }

    }
}
