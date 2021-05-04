using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩石热蒸发烃气相色谱分析记录
    public class Form_B_14
    {
        public double well_depth { get; set; }//丼深
        public string position { get; set; }//层位
        public string the_lithology_named { get; set; }//岩性定名
        public int sample_no { get; set; }//样品编号
        public string sample_type { get; set; }//样品类别
        public double sample_mass { get; set; }//样品质量

        //分析参数
        public string ingredients { get; set; }//组分
        public double peakAreas { get; set; }//峰面积

    }
}
