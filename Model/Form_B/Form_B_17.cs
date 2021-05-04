using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //X射线衍射矿物录井分析记录
    public class Form_B_17:Form_B_9
    {
        public int serial_no { get; set; }//序号
                                          //public double well_depth { get; set; }//井深
                                          //public string the_lithology_named { get; set; }//岩性定名

        //矿物含量
        public double mineral_1_content { get; set; }//矿物1含量


    }
}
