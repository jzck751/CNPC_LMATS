using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //轻烃录井分析记录
    public class Form_B_15
    {
        public double well_depth { get; set; }//井深
        public string position { get; set; }//层位
        public string the_lithology_named { get; set; }//岩性定名

        //分析参数
        public string ingredient { get; set; }//组分
        public double peak_area { get; set; }//峰面积
    }
}
