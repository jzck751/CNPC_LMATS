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
    }
}
