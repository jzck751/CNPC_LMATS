using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class QuantiFluLogging
    {
        public int num { get; set; }//序号
        public int wall_num { get; set; }//丼号
        public double well_dep { get; set; }//井深
        public double sam_type { get; set; }//样品类型
        public string lith_name { get; set; }//岩性定名

        //分析参数
        public double exc_wava { get; set; }//激发波长
        public double fluo_wava { get; set; }//荧光波长
        public double fiuo_inten { get; set; }//荧光强度
        public double oil_con { get; set; }//相当油含量
        public string level { get; set; }//对比级别
        public double oil_index { get; set; }//含油指数
    }
}
