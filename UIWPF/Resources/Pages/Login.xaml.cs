using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Data;

namespace RecordingProject.Resources.Pages
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void regist_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
