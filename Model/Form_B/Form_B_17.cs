using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //X射线衍射矿物录井分析记录
    public class Form_B_17
    {
        public int serial_number { get; set; }//序号
        public double well_depth { get; set; }//井深
        public string the_lithology_named { get; set; }//岩性定名

        //矿物含量
        public double mineral_1_content { get; set; }//矿物1含量
        public double mineral_2_content { get; set; }//矿物2含量
        public double mineral_3_content { get; set; }//矿物3含量
        public double mineral_4_content { get; set; }//矿物4含量
        public double mineral_5_content { get; set; }//矿物5含量
        public double mineral_6_content { get; set; }//矿物6含量
        public double mineral_7_content { get; set; }//矿物7含量
        public double mineral_8_content { get; set; }//矿物8含量


    }
}
