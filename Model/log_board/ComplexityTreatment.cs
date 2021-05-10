using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    public class ComplexityTreatment
    {
        //钻井复杂或事故处理过程
        public double well_depth { get; set; }//井深
        public string time { get; set; }//时间
        public string stratum { get; set; }//地层
        public string accident_type { get; set; }//复杂事故类型
        public string tream_process { get; set; }//处理过程
        public string release_time { get; set; }//解除时间
        public string remarks { get; set; }//备注
    }
}
