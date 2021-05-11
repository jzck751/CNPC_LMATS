using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class ChlorideTiDrilling
    {

        public string num { get; set; }//编号
        public double samp_well_dep { get; set; }//取样井深
        public double silver_ni_c { get; set; }//硝酸银浓度当量
        public double samp_v { get; set; }//取样体积
        public double silv_ni_q { get; set; }//氯根含量
        public double silv_ni_l { get; set; }//密度
        public double silv_ni_co { get; set; }//粘度
        public string reviewPerson { get; set; }//检验人

        //取样时间
        public string samp_time_d { get; set; }//日/月
        public string samp_time_m { get; set; }//时/分

        //硝酸银用量
        public string before_the_titration { get; set; }//滴定前
        public string after_the_titration { get; set; }//滴定后
        public string consumption { get; set; }//消耗量
        //public int core_num { get; set; }//岩心编号
        //public string wear_cond { get; set; }//磨损情况
        //public double total_leng { get; set; }//累计长度
        //public int sample_num { get; set; }//岩样编号

        //public string lith_name_co { get; set; }//颜色
        //public string lith_name_oil { get; set; }//含油级别
        //public string lith_name_lith { get; set; }//岩性
        //public string lit_des_wat { get; set; }//油气水描述
        //public string flu_wet { get; set; }//湿照
        //public string flu_color { get; set; }//滴照
        //public string flu_cont_le { get; set; }//对比级别
        ////顶头数据
        //public int canister_number { get; set; }//筒次
        //public double well_top_depth { get; set; }//井段顶深
        //public double well_bottom_depth { get; set; }//井段底深
        //public double measure_into { get; set; }//进尺
        //public double rock_core_length { get; set; }//岩心长度
        //public double harvest_rate { get; set; }//收获率
        //public string position { get; set; }//层位
        //public string contain_oil { get; set; }//饱含油
        //public string be_rich_oil { get; set; }//富含油
        //public string oil_immersion { get; set; }//油浸
        //public string oil_patch { get; set; }//油斑
        //public string oil_stains { get; set; }//油迹
        //public string fluorescence { get; set; }//荧光
        //public string contain_gas { get; set; }//含气
        //public double total_contain_oil_gas_core_length { get; set; }//累计含油气岩心长度
    }
}
