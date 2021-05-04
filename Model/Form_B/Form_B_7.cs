using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //后效气体检测记录
    public class Form_B_7
    {
        public string date { get; set; }//日期
        public double well_depth { get; set; }//井深
        public string drill_location { get; set; }//钻头位置
        public string standstill_time_of_oakbowl { get; set; }//丼筒静止时间
        public string time_lag { get; set; }//迟到时间
        public double replace_the_interval { get; set; }//归位井段
        public double the_hight_of_up { get; set; }//上窜高度
        public double the_speed_of_up { get; set; }//上窜速度

        //钻井液情况
        public string groove_face_shows { get; set; }//槽面显示
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度

        //全烃出峰情况
        public string begin_time { get; set; }//开始时间
        public string peak_time { get; set; }//高峰时间
        public string over_time { get; set; }//结束时间
        public double begin_value { get; set; }//开始值
        public double peak_value { get; set; }//高峰值
        public double over_value { get; set; }//结束值
    }
}
