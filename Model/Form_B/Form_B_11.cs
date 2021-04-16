using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //定量荧光分析记录
    public class Form_B_11
    {
        public int serial_number { get; set; }//序号
        public int well_no { get; set; }//丼号
        public double well_depth { get; set; }//井深
        public double sample_type { get; set; }//样品类型
        public string the_lithology_named { get; set; }//岩性定名
    }
}
