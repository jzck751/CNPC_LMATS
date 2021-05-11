using DAL.DBUtils;
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

namespace UIWPF.Resources.Pages
{
    /// <summary>
    /// FormPage.xaml 的交互逻辑
    /// </summary>
    public partial class FormPage : Page
    {
        //the key of the current form
        string formKey = null;
        public FormPage()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        public void loadData()
        {
            
            //dtGrid = new DataGrid();
            
            string sql = "select * from ";
            string formName = null;
            if (Model.Form_B.FormKeyValuePairB.formBDIc.TryGetValue(formKey, out formName))
                sql += formName;
            else
            {
                MessageBox.Show(formKey + " access failure.");
                return;
            }

            //dt = DbManager.Ins.ExcuteDataTable(sql);

            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "localhost";
            connectionString.UserID = "root";
            connectionString.Password = "123456";
            connectionString.Database = "cnpc_lmats";
            connectionString.AllowUserVariables = true;
            MySqlConnection connection = new MySqlConnection(connectionString.ToString());
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            dtGrid.ItemsSource = dt.DefaultView;

        }

        public DataTable GetData()
        {
            return dt;
        }

        public void setFormKey(string btnKey)
        {
            formKey = btnKey;
            return;
        }
    }
}
