using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //岩屑草描记录
    public class Form_A_3:Form_A_3_1
    {
        public double well_depth { get; set; }//井深
        public string drilling_time { get; set; }//钻时
        public string lithology_and_description_of_hydrocarbon_and_water { get; set; }//岩性及含油气水描述
        public double designated_cuttings_of_cuttings { get; set; }//定名岩屑占岩屑
        public double oil_bearing_cuttings_are_named_cuttings { get; set; }//含油岩屑占定名岩屑
    }
}
