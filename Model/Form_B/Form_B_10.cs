using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //碳酸盐岩含量分析记录
    public class Form_B_10
    {
        public int serial_number { get; set; }//序号
        public double well_depth { get; set; }//井深
        public double sample_type { get; set; }//样品类型
        public double caCO3_content{ get; set; }//碳酸钙含量
        public double magnesium_and_calcium_carbonate_content { get; set; }//碳酸镁钙含量
        public double other_mineral_substance{ get; set; }//其他矿物质含量
    }
}
