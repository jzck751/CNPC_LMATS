using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class ChlorideTiDrilling
    {
        public string num { get; set; }//编号
        public double samp_well_dep { get; set; }//取样井深
        public double silver_ni_c { get; set; }//硝酸银浓度当量
        public double samp_v { get; set; }//取样体积
        public double chlo_con  { get; set; }//氯根含量
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public string examiner { get; set; }//检验人

        //取样时间
        public string samp_time { get; set; }//日/月
        public string samp_month { get; set; }//时/分

        //硝酸银用量
        public string silv_ni_q { get; set; }//滴定前
        public string silv_ni_l { get; set; }//滴定后
        public string silv_ni_co { get; set; }//消耗量
    }
}
