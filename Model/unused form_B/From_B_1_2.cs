using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻头
    public class From_B_1_2
    {
        public string serialNum { get; set; }//序号
        public string size { get; set; }//尺寸
        public string type { get; set; }//类型
        public string the_cumulative_penetration { get; set; }//累计进尺
        public string accumulated_net_drilling_time { get; set; }//累计纯钻时间
    }
}
