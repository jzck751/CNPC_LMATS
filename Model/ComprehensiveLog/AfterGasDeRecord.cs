using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ComprehensiveLog
{
    public class AfterGasDeRecord
    {
        public string date { get; set; }//日期
        public double well_dep { get; set; }//井深
        public double dill_loca { get; set; }//钻头位置
        public string well_sta_time { get; set; }//丼筒静止时间
        public string late_time { get; set; }//迟到时间
        public double home_sec { get; set; }//归位井段
        public double up_high { get; set; }//上窜高度
        public double up_speed { get; set; }//上窜速度

        //钻井液情况
        public string fil_cm { get; set; }//槽面显示
        public double fil_den { get; set; }//密度
        public double fil_vis { get; set; }//粘度

        //全烃出峰情况
        public string q_t_s_time { get; set; }//开始时间
        public string q_t_g_time { get; set; }//高峰时间
        public string q_t_l_time { get; set; }//结束时间
        public double q_t_s_val { get; set; }//开始值
        public double q_t_g_val { get; set; }//高峰值
        public double q_t_l_val { get; set; }//结束值
    }
}
