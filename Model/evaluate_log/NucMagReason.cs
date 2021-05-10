using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class NucMagReason
    {
        public int num { get; set; }//序号
        public string wall_dep { get; set; }//层位
        public double horizon { get; set; }//井深
        public string lit_name { get; set; }//岩性定名


        public double porosity { get; set; }//孔隙度
        public double permea { get; set; }//渗透率
        public double oil_satur { get; set; }//含油饱和度
        public double lipuidty { get; set; }//可动流体
        public double bound_fluid { get; set; }//束缚流体
        public double mova_wat_sat { get; set; }//可动水饱和度
    }
}
