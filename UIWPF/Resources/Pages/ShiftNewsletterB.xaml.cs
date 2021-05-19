using DAL.DBUtils;
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
    /// ShiftNewsletterB.xaml 的交互逻辑
    /// </summary>
    public partial class ShiftNewsletterB : Page
    {
        public ShiftNewsletterB()
        {
            InitializeComponent();
            read_B16();

        }

        public void read_B16()
        {
            try
            {
                string sql = "select * from aftereffect_gas_dete_b1";
                DataTable dt = DbManager.Ins.ExcuteDataTable(sql);
                DataRow[] dtrows = dt.Select();
                //MessageBox.Show(table + ": ");
                //string test = dtrows[0][1].ToString();
                //MessageBox.Show(test);
                aftGasTimeBox.Text = dtrows[0][0].ToString();
                drillLocBox.Text = dtrows[0][1].ToString();
                PeakTtlHydroBox.Text = dtrows[0][2].ToString();
                upSpdBox.Text = dtrows[0][3].ToString();
                gasDensityBox.Text = dtrows[0][4].ToString();
                gasVisBox.Text = dtrows[0][5].ToString();
                slotSfcDisBox.Text = dtrows[0][6].ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
