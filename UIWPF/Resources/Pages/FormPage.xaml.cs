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
        string formName = null;
        string formTitle = null;
        
        public FormPage()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        public void clear()
        {
            dtGrid.Items.Clear();
        }

        public void loadData()
        {

            //dtGrid = new DataGrid();

            string sql = "select * from ";
            
            if (Model.Form_B.FormKeyValuePairB.formBDIc.TryGetValue(formKey, out formName))
                sql += formName;
            else
            {
                MessageBox.Show(formKey + " access failure.");
                return;
            }

            //dt = DbManager.Ins.ExcuteDataTable(sql);

            //MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            //connectionString.Server = "localhost";
            //connectionString.UserID = "root";
            //connectionString.Password = "123456";
            //connectionString.Database = "cnpc_lmats";
            //connectionString.AllowUserVariables = true;
            //MySqlConnection connection = new MySqlConnection(connectionString.ToString());
            //MySqlCommand cmd = new MySqlCommand(sql, connection);
            //connection.Open();
            ////dt.Load(cmd.ExecuteReader());
            //connection.Close();

            dt = DbManager.Ins.ExcuteDataTable(sql);

            dtGrid.ItemsSource = null;
            //dtGrid.Items.Clear();
            dtGrid.ItemsSource = dt.DefaultView;

            string headerName = null;
            
            //update the commented form name
            //Change the header
            if (Model.Form_B.FormKeyValuePairB.formBNameDIc.TryGetValue(formName, out formTitle))
            {

            }
            foreach (var items in dtGrid.Columns)
            {
                if (Model.Form_B.FormKeyValuePairB.formBNameDIc.TryGetValue(items.Header.ToString(), out headerName))
                {
                    items.Header = headerName;
                }
            }

        }

        public DataTable GetData()
        {
            return dt;
        }

        public int UpdateTable()
        {
            int rows = 0;
            //MySqlCommandBuilder buider = new MySqlCommandBuilder(adapter);

            //rows = adapter.Update(data, table);
            return rows;

        }

        public void setFormKey(string btnKey)
        {
            formKey = btnKey;
            return;
        }

        public string getFormName()
        {
            return formName;
        }

        public string getFormTitle()
        {
            if (formTitle == null)
                return "Name Not Found";
            return formTitle;
        }
    }
}
