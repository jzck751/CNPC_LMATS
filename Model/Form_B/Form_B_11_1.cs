using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //分析参数
    public class Form_B_11_1
    {
        public double excitation_wavelength { get; set; }//激发波长
        public double fluorescence_wavelength { get; set; }//荧光波长
        public double fluorescence_intensity { get; set; }//荧光强度
        public double equivalent_oil_content { get; set; }//相当油含量
        public string contrast_level { get; set; }//对比级别
        public double oil_index { get; set; }//含油指数
    }
}
