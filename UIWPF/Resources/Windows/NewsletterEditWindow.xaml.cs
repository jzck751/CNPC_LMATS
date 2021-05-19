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
        Pages.ShiftNewsletter PageA = new Pages.ShiftNewsletter();
        Pages.ShiftNewsletterB PageB = new Pages.ShiftNewsletterB();
        public NewsletterEditWindow()
        {
            InitializeComponent();
            Page1.Navigate(PageA);
            Page2.Navigate(PageB);
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PageA.IsEnabled = false;
                PageB.IsEnabled = false;
                PrintDialog dialog = new PrintDialog();
                Visual visual = PageA;
            
                if (dialog.ShowDialog() == true)
                {
                    dialog.PrintVisual(PageA.printA, "Shift newsletter第一页");
                    dialog.PrintVisual(PageB.printB, "Shift newsletter第二页");
                
                }
            }
            finally
            {
                PageA.IsEnabled = true;
                PageB.IsEnabled = true;
            }

        }
    }
}
