using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base_Class
{
    //三峰法和五峰法的父类
    public class Form_B_threePeak_and_fivePeak
    {
        public int serial_number { get; set; }//序号
        public double well_depth { get; set; }//井深
        public string the_lithology_named { get; set; }//岩心定名
        public string samplr_type { get; set; }//样品类型
        public double S0 { get; set; }//S0
    }
}
