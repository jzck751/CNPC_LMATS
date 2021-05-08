using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace UIWPF.Resources.Pages.Form_B
{
    /// <summary>
    /// B_2.xaml 的交互逻辑
    /// </summary>
    public partial class B_2 : Page
    {
        

        public B_2()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "localhost";
            connectionString.UserID = "root";
            connectionString.Password = "123456";
            connectionString.Database = "cnpc_lmats";
            connectionString.AllowUserVariables = true;
            //Using DbHelper
            //DbHelper.DbUtility dbUtility = new DbHelper.DbUtility(connectionString.ToString(), DbHelper.DbProviderType.MySql);
            //DataTable dt = dbUtility.ExecuteDataTable("",)
            MySqlConnection connection = new MySqlConnection(connectionString.ToString());
            MySqlCommand cmd = new MySqlCommand("select * from mc_rock_describe_record", connection);
            connection.Open();
            DataTable dt = new DataTable();
            
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            dataGrid.ItemsSource = dt.DefaultView;
        }
    }
}
