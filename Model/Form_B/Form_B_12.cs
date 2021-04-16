using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩石热分解分析记录(三峰法)
    public class Form_B_12
    {
        public int serial_number { get; set; }//序号
        public double well_depth { get; set; }//井深
        public string the_lithology_named { get; set; }//岩性定名
        public double sample_type { get; set; }//样品类型
        public double S0 { get; set; }//S0
        public double S1 { get; set; }//S0
        public double S2 { get; set; }//S0
        public double S4 { get; set; }//S0
        public double max_temperature { get; set; }//最大温度
    }
}
