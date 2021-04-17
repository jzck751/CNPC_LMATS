using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻井液性能
    public class Form_B_1_4
    {
        public string drilling_fluid_type { get; set; }//类型
        public string drilling_fluiddensity { get; set; }//密度
        public string drilling_fluid_viscosity { get; set; }//粘度
        public string drilling_fluid_water_loss { get; set; }//失水
        public string drilling_fluid_mud_cake { get; set; }//泥饼
        public string drilling_fluid_for_cutting { get; set; }//补切
        public string drilling_fluid_egress { get; set; }//终切
        public string drilling_fluid_sand_content { get; set; }//含砂
        public string drilling_fluid_coefficient_of_friction_resistance { get; set; }//摩阻系数
        public string drilling_fluid_300_revolutions { get; set; }//300转读数
        public string drilling_fluid_600_revolutions { get; set; }//600转读数
        public string drilling_fluid_HTHP_water_loss { get; set; }//HTHP失水
        public string drilling_fluid_pH_value { get; set; }//pH值
        public string drilling_fluid_like_the_content { get; set; }//般土含量
        public string drilling_fluid_solid_content { get; set; }//固相含量
        public string drilling_fluid_chloridion { get; set; }//氯离子
        public string drilling_fluid_total_salinity { get; set; }//总矿化度
        public string drilling_fluid_affects_logging_treatment_agents { get; set; }//影响录井处理剂


    }
}
