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
    /// DataCollection_EditPanel.xaml 的交互逻辑
    /// </summary>
    public partial class DataCollection_EditPanel : Window
    {
        public DataCollection_EditPanel()
        {
            InitializeComponent();
            this.testFrame.Navigate(new Resources.Pages.Form_B.B_test());
        }
    }
}
