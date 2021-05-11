
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class StaticDrillCo
    {
        //钻井取心统计表
        public int time_core { get; set; }//取心筒次
        public string horizon { get; set; }//层位
        public double well_sec { get; set; }//井段
        public double footage { get; set; }//进尺
        public double core_len { get; set; }//心长
        public double harve_rate { get; set; }//收获率
        public double h_oill_b_len { get; set; }//饱含油岩心长度
        public double h_oill_f_len { get; set; }//富含油岩心长度
        public double oil_in { get; set; }//油浸岩心长度
        public double oil_b { get; set; }//油斑岩心长度
        public double oil_j { get; set; }//油迹岩心长度
        public double fl_len { get; set; }//荧光岩心长度
        public double h_air { get; set; }//含气岩心长度
        public double c_h_oil_le { get; set; }//储蓄层不含油气岩心长度
        public double f_d_oil_le { get; set; }//非储蓄层不含油气岩心长度
        public string remarks { get; set; }//备注

    }
}
