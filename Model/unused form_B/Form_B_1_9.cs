using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻井取心
    public class Form_B_1_9
    {
        public int cylinder_number { get; set; }//筒次
        public double position { get; set; }//层位
        public double coring_well_depth_to_depth { get; set; }//取心井段
        public double footage { get; set; }//进尺
        public double crock_coring_length { get; set; }//岩心长度
        public double yield_rate { get; set; }//收获率

    }
}
