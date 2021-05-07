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
        public double parameter_S11 { get; set; }//S11
        public double parameter_S21 { get; set; }//S21
        public double parameter_S22 { get; set; }//S22
        public double parameter_S23 { get; set; }//S23
        public double parameter_S4 { get; set; }//S4

    }
}
