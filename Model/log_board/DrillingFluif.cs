using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class DrillingFluif
    {
        //钻井液性能
        public string type { get; set; }//类型
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public double water_loss { get; set; }//失水
        public double mud_cake { get; set; }//泥饼
        public double initial_cut { get; set; }//补切
        public double final_cut { get; set; }//终切
        public double sand_bearing { get; set; }//含砂
        public double fri_coe { get; set; }//摩阻系数
        public double read_300 { get; set; }//300转读数
        public double read_600 { get; set; }//600转读数
        public double hthp_w_loss { get; set; }//HTHP失水
        public double ph_value { get; set; }//pH值
        public double clay_conte { get; set; }//般土含量
        public double solid_cont { get; set; }//固相含量
        public double cl { get; set; }//氯离子
        public double total_sal { get; set; }//总矿化度
        public string affect_m_l_t { get; set; }//影响录井处理剂

    }
}
