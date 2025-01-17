﻿using kobe.Common;
using kobe.ViewModel;
using System;
using System.Collections.Generic;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            MainViewModel model = new MainViewModel();
            this.DataContext = model;

            model.UserInfo.Avatar = GlobalValues.UserInfo.Avatar;
            model.UserInfo.UserName = GlobalValues.UserInfo.RealName;
            model.UserInfo.Gender = GlobalValues.UserInfo.Gender;

            this.MaxHeight = SystemParameters.PrimaryScreenHeight;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btn_minCilck(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_maxCilck(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? 
                WindowState.Normal : WindowState.Maximized;
        }

        private void btn_closeCilck(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
