using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩石热分解分析记录(三峰法)
    public class Form_B_12:Base_Class.Form_B_threePeak_and_fivePeak
    {
        public double S1 { get; set; }//S1
        public double S2 { get; set; }//S2
        public double S4 { get; set; }//S3
        public double max_temperature { get; set; }//最大温度
    }
}
