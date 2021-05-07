using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //全烃出峰情况
    public class Form_B_7_2
    {
        public string begin_time { get; set; }//开始时间
        public string peak_time { get; set; }//高峰时间
        public string over_time {get; set; }//结束时间
        public double begin_value { get; set; }//开始值
        public double peak_value { get; set; }//高峰值
        public double over_value { get; set; }//结束值
    }
}
