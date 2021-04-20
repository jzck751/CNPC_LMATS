using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //丼壁取心描述记录
    public class Form_B_6:Base_Class.lithology_and_oil_gas_water_fluorescence
    {
        public int serial_number { get; set; }//序号
        public double position { get; set; }//层位
        public double well_depth { get; set; }//丼深

    }
}
