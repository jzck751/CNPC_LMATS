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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIWPF.Resources.Pages
{
    /// <summary>
    /// DataCollection.xaml 的交互逻辑
    /// </summary>
    public partial class DataCollection : Page
    {
        public DataCollection()
        {
            InitializeComponent();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            numSearchPopup.IsOpen = true;
        }

        private void datePicker_DateChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void duty_TextChanged(object sender, TextChangedEventArgs e)
        {
            dutySearchPopup.IsOpen = true;
        }

        private void editPanel_Click(object sender, RoutedEventArgs e)
        {
            Window editPanelWindow = new Resources.Windows.DataCollection_EditPanel();
            editPanelWindow.Show();
        }

        private void alledit_Click(object sender, RoutedEventArgs e)
        {
            Window editPanelWindow = new Resources.Windows.DataCollection_EditPanel();
            editPanelWindow.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
