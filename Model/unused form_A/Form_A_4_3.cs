using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //钻井取心
    public class Form_A_4_3
    {
        public double well_depth_to_depth { get; set; }//井段（深）
        public double core_diameter{ get; set; }//岩心直径
        public int coring_coefficient { get; set; }//取心此数
        public double the_length_of_the_core { get; set; }//岩心长度
        public int box_number { get; set; }//盒数
    }
}
