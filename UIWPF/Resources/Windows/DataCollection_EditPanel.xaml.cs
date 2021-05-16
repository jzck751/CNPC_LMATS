using MySql.Data.MySqlClient;
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
        //Pages.Form_B.B_2 b_2 = new Pages.Form_B.B_2();
        Pages.FormPage FormPage = new Pages.FormPage();

        public DataCollection_EditPanel()
        {
            InitializeComponent();
            
            this.testFrame.Navigate(new Pages.WelcomePage());
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string select = "select * from ";
            select += FormPage.getFormName();
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "localhost";
            connectionString.UserID = "root";
            connectionString.Password = "123456";
            connectionString.Database = "cnpc_lmats";
            connectionString.AllowUserVariables = true;
            MySqlConnection connection = new MySqlConnection(connectionString.ToString());
            MySqlCommand cmd = new MySqlCommand("select * from mc_rock_describe_record", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            connection.Open();
            adapter.Update(FormPage.GetData());
            connection.Close();
            
        }

        private void formSwitch_Click(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuItem;
            if(item!=null)
            {
                this.testFrame.Navigate(FormPage);
                FormPage.setFormKey(item.Name);
                FormPage.loadData();
                ShowTab.Header = FormPage.getFormTitle();
            }
            
            

        }

    }
}
