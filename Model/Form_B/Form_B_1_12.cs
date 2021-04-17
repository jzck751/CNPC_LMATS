using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻井复杂或事故及处理过程
    public class Form_B_1_12
    {
        public double well_depth { get; set; }//井深
        public string date_time { get; set; }//时间
        public string stratum { get; set; }//地层
        public string circumstance_type { get; set; }//复杂事故类型
        public string handle_process { get; set; }//处理过程
        public string relieve_time { get; set; }//解除时间
        public string remark { get; set; }//备注

    }
}
