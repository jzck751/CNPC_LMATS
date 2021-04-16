using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //核磁共振录井分析记录
    public class Form_B_16:Form_B_9
    {
        public double porosity { get; set; }//孔隙度
        public double permeability { get; set; }//渗透率
        public double oil_saturation { get; set; }//含油饱和度
        public double the_movable_fluid { get; set; }//可动流体
        public double bound_fluid{ get; set; }//束缚流体
        public double movable_water_saturation { get; set; }//可动水饱和度
    }
}
