using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼迟到时间测量记录
    public class Form_A_2
    {
        public string data { get; set; }//时间
        public double drill_Location{ get; set; }//钻头位置
        public string theoretical_late_time { get; set; }//理论迟到时间
        public string cycle_time { get; set; }//循环一周时间
        public string downside_time { get; set; }//下行时间
        public string Line_delay_time { get; set; }//管路延迟时间
        public string measured_lateness_time { get; set; }//实测时间
        public string Adopt_late_time { get; set; }//采用迟到时间
        public string adopt_well_depth { get; set; }//采用井深
        public string measurePerson { get; set; }//测量人
        public string verifyPerson { get; set; }//审核人
        public string remark { get; set; }//备注

    }
}
