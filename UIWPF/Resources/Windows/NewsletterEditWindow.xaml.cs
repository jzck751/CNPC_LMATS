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
    /// NewsletterEditWindow.xaml 的交互逻辑
    /// </summary>
    public partial class NewsletterEditWindow : Window
    {
        public NewsletterEditWindow()
        {
            InitializeComponent();
            Page1.Navigate(new Pages.ShiftNewsletter());
            Page2.Navigate(new Pages.ShiftNewsletterB());
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
