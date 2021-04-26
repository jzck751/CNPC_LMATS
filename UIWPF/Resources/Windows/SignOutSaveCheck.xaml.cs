using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UIWPF.Resources.Windows
{
    /// <summary>
    /// SignOutSaveCheck.xaml 的交互逻辑
    /// </summary>
    public partial class SignOutSaveCheck : Window
    {
        public SignOutSaveCheck()
        {
            InitializeComponent();
            this.Owner = Application.Current.MainWindow;
        }

        private void closeWithSave(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cancel_Click(object sender,RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
