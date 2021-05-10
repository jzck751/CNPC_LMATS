using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class ThermDetionRock
    {
        public int num { get; set; }//序号
        public double wall_dep { get; set; }//井深
        public string lit_name { get; set; }//岩心定名
        public string sam_type { get; set; }//样品类型
        public double s_o { get; set; }//S0
        public double s_tw { get; set; }//S1
        public double s_t { get; set; }//S2
        public double s_f { get; set; }//S3
        public double tmax { get; set; }//最大温度
    }
}
