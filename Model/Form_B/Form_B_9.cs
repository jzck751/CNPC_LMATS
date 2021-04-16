using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //泥(页)岩密度分析记录
    public class Form_B_9
    {
        public int serial_number { get; set; }//序号
        public double position { get; set; }//层位
        public double well_depth { get; set; }//井深
        public string the_lithology_named { get; set; }//岩性定名
    }
}
