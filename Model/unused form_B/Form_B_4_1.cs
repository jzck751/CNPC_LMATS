using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //有效缝
    public class Form_B_4_1
    {
        public int number_of_branches { get; set; }//有效条数
        public double density { get; set; }//密度
        public string degree_of_filling { get; set; }//填充程度
        public string filling_thing { get; set; }//填充物

        //宽度
        public bool more_than_five { get; set; }//大于5
        public bool one_to_five { get; set; }//1-5
        public bool less_than_one { get; set; }//小于1

        //产况
        public string vertical_seam { get; set; }//立缝
        public string inclined_seam { get; set; }//斜缝
        public string flat_seaming { get; set; }//平缝

    }
}
