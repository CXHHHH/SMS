using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using kobe.Common;
using kobe.DataAccess;
using kobe.Model;

namespace kobe.ViewModel
{
    public class LoginViewModel:NotifyBase
    {
        public LoginModel LoginModel { get; set; } = new LoginModel();
        public CommandBase CloseWindowCommand { get; set; }

        public CommandBase LoginCommand { get; set; }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; this.Donotify(); }
        }

        private Visibility _showProgress = Visibility.Collapsed;

        public Visibility ShowProgress
        {
            get { return _showProgress; }
            set
            {
                _showProgress = value; this.Donotify();
                LoginCommand.RaiseCanExecuteChanged();
            }
        }



        public LoginViewModel()
        {
            this.CloseWindowCommand = new CommandBase();
            this.CloseWindowCommand.DoExecute = new Action<object>((o) =>
            {
                (o as Window).Close();
            });
            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            this.LoginCommand = new CommandBase();
            this.LoginCommand.DoExecute = new Action<object>(DoLogin);
            this.LoginCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }

        private void DoLogin(object o)
        {
            this.ShowProgress = Visibility.Visible;
            this.ErrorMessage = "";

            if(string.IsNullOrEmpty(LoginModel.UserName))
            {
                this.ErrorMessage = "用户名不能为空！";
                this.ShowProgress = Visibility.Collapsed;
                return;
            }
            if (string.IsNullOrEmpty(LoginModel.Password))
            {
                this.ErrorMessage = "密码不能为空！";
                this.ShowProgress = Visibility.Collapsed;
                return;
            }


            Task.Run(new Action(async () =>
            {
                await Task.Delay(2000);
                try
                {
                    var user = LocalDataAccess.GetInstance().CheckUserInfo(LoginModel.UserName, LoginModel.Password);
                    if (user == null)
                    {
                        throw new Exception("登陆失败！用户名或密码错误！");
                    }

                    GlobalValues.UserInfo = user;

                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        (o as Window).DialogResult = true;

                    }));
                }
                catch (Exception ex)
                {
                    this.ErrorMessage = ex.Message;
                }
                finally
                {
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        this.ShowProgress = Visibility.Collapsed;
                    }));
                }
            }));


        }
    }
}
