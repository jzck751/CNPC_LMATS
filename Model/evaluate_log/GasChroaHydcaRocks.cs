using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class GasChroaHydcaRocks
    {
        public double wall_dep { get; set; }//丼深
        public string horizon { get; set; }//层位
        public string lit_name { get; set; }//岩性定名
        public int num { get; set; }//样品编号
        public string sam_type { get; set; }//样品类别
        public double sam_qua { get; set; }//样品质量

        //分析参数
        public string team_code { get; set; }//组分
        public double peak_area { get; set; }//峰面积
    }
}
