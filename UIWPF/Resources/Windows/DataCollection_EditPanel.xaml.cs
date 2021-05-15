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
        string table = null;
        public DataCollection_EditPanel()
        {
            InitializeComponent();

            this.testFrame.Navigate(FormPage);
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string select = "select * from " + table;
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "localhost";
            connectionString.UserID = "root";
            connectionString.Password = "123456";
            connectionString.Database = "cnpc_lmats";
            connectionString.AllowUserVariables = true;
            MySqlConnection connection = new MySqlConnection(connectionString.ToString());
            MySqlCommand cmd = new MySqlCommand("select * from " + table, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            connection.Open();
            if (adapter.Update(FormPage.GetData()) != 0)
                MessageBox.Show(table + "表，保存成功，更新：" + adapter.Update(FormPage.GetData()));
            else
                MessageBox.Show("失败");
            connection.Close();


        }

        private void formSwitch_Click(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuItem;
            if (item != null)
            {
                FormPage.setFormKey(item.Name);
                Model.Form_B.FormKeyValuePairB.formBDIc.TryGetValue(item.Name, out table);

                //MessageBox.Show(table + '表');
                FormPage.loadData();
            }

        }

    }
}
