using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻井取心描述记录
    public class Form_B_3:Base_Class.lithology_and_oil_gas_water_fluorescence
    {
        public int core_number { get; set; }//岩心编号
        public string damage_circumastance { get; set; }//磨损情况
        public double total_length { get; set; }//累计长度
        public int rock_sample_number { get; set; }//岩样编号

        //顶头数据
        public int canister_number { get; set; }//筒次
        public double well_top_depth { get; set; }//井段顶深
        public double well_bottom_depth { get; set; }//井段底深
        public double measure_into { get; set; }//进尺
        public double rock_core_length { get; set; }//岩心长度
        public double harvest_rate { get; set; }//收获率
        public string position { get; set; }//层位
        public string contain_oil { get; set; }//饱含油
        public string be_rich_oil { get; set; }//富含油
        public string oil_immersion { get; set; }//油浸
        public string oil_patch { get; set; }//油斑
        public string oil_stains { get; set; }//油迹
        public string fluorescence { get; set; }//荧光
        public string contain_gas { get; set; }//含气
        public double total_contain_oil_gas_core_length { get; set; }//累计含油气岩心长度
    }
}
