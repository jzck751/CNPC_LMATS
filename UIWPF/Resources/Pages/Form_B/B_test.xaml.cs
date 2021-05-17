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
using DAL.DBUtils;
namespace UIWPF.Resources.Pages.Form_B
{
    /// <summary>
    /// B_test.xaml 的交互逻辑 tr
    /// </summary>
    public partial class B_test : Page
    {
        private object comboType;
        private object cbLang;

        public B_test()
        {
            InitializeComponent();
            loadData();
        }

        private void dataGrid_test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Console.WriteLine("3487564895748975238947593824759842");
            string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'cnpc_lmats1';";
            DataTable dtable = DbManager.Ins.ExcuteDataTable(sql);
            foreach (DataRow dr2 in dtable.Rows)
            {
                Console.WriteLine(dr2["TABLE_NAME"].ToString());
            }
            dataGrid_test.ItemsSource = dtable.DefaultView;
        }

        private void loadData() {

            Console.WriteLine("3487564895748975238947593824759842");
            string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'cnpc_lmats';";
            DataTable dtable = DbManager.Ins.ExcuteDataTable(sql);
            foreach (DataRow dr2 in dtable.Rows)
            {
                Console.WriteLine(dr2["TABLE_NAME"].ToString());
            }
            dataGrid_test.ItemsSource = dtable.DefaultView;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string sql = "select * from mc_rock_describe_record";
            //DataTable dt = DbManager.Ins.ExcuteDataTable(sql);
            //combMainBrand.ItemsSource = dt.DefaultView;
            BindCombox();
            Console.WriteLine(combMainBrand.SelectedValue);

        }

        //绑定下拉控件1
        private void BindCombox()
        {
            string sql = "select * from mc_rock_describe_record";
            DataTable dt = DbManager.Ins.ExcuteDataTable(sql);
            if (dt != null)
            {
                dt = new DataTable();
                DataColumn dc1 = new DataColumn("tablename");
                dt.Columns.Add(dc1);
                DataRow row = dt.NewRow();
                row["tablename"] = "表名";
                dt.Rows.Add(row);
            }
            DataView dv = dt.DefaultView;
            combMainBrand.ItemsSource = dv;
            this.combMainBrand.DisplayMemberPath = "Title";

        }

    }
}
