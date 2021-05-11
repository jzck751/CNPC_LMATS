using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class DensityAnaMudston
    {
        //泥页岩密度分析
        public int num { get; set; }//序号
        public double horizon { get; set; }//层位
        public double wall_dep { get; set; }//井深
        public string lith_name { get; set; }//岩性定名

        //测量值
        public double mea_value_l_o { get; set; }//L1
        public double mea_value_t { get; set; }//L2
        public double density { get; set; }//密度
    }
}
