using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩屑描述记录
    public class Form_B_2:Form_A.Form_A_3
    {
        public int serial_number { get; set; }//序号
        public double position { get; set; }//层位

        //井段
        public double top_depth { get; set; }//顶深
        public double botton_depth { get; set; }//底深
    }
}
