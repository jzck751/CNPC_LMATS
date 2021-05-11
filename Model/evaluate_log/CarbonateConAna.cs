using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class CarbonateConAna
    {
        //碳酸盐含量分析
        public int num { get; set; }//序号
        public double wall_dep { get; set; }//井深
        public double sam_type { get; set; }//样品类型
        public double cal_car_cont { get; set; }//碳酸钙含量
        public double con_ma_cal_car { get; set; }//碳酸镁钙含量
        public double other { get; set; }//其他矿物质含量
    }
}
