using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻井取心描述记录
    public class Form_B_3:Base_Class.lithology_and_oil_gas_water_fluorescence
    {
        public int core_number { get; set; }//岩心编号
        public string wear_pattern { get; set; }//磨损情况
        public double the_cumulative_length { get; set; }//累计长度
        public int sample_number { get; set; }//岩样编号
    }
}
