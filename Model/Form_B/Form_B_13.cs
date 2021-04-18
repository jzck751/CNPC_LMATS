using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩石热分解分析记录(五峰法)
    public class Form_B_13:Base_Class.Form_B_threePeak_and_fivePeak
    {
        public double S11 { get; set; }//S11
        public double S21 { get; set; }//S21
        public double S22 { get; set; }//S22
        public double S23 { get; set; }//S23
        public double S4 { get; set; }//S4

    }
}
