using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //定量荧光分析记录
    public class Form_B_11
    {
        public int serial_number { get; set; }//序号
        public int well_no { get; set; }//丼号
        public double well_depth { get; set; }//井深
        public double sample_type { get; set; }//样品类型
        public string the_lithology_named { get; set; }//岩性定名

        //分析参数
        public double excitation_wavelength { get; set; }//激发波长
        public double fluorescence_wavelength { get; set; }//荧光波长
        public double fluorescence_intensity { get; set; }//荧光强度
        public double equivalent_oil_content { get; set; }//相当油含量
        public string contrast_level { get; set; }//对比级别
        public double oil_index { get; set; }//含油指数
    }
}
