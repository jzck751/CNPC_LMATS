using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //缝洞统计表
    public class Form_B_4
    {
        public int take_core_canister_number { get; set; }//取心筒次
        public double well_depth_to_depth { get; set; }//井段
        public int core_number{ get; set; }//岩心编号
        public double length { get; set; }//长度
        public string rock_lithology_named { get; set; }//岩性定名
        public int total_number{ get; set; }//总条数
        public double total_density { get; set; }//总密度
        public int suture_line { get; set; }//缝合线
        public int patch_number { get; set; }//块斑
        public int smoking_location { get; set; }//冒气处数
        public string connected_situation{ get; set; }//连通情况

        //有效缝
        public int number_of_branches { get; set; }//有效条数
        public double density { get; set; }//密度
        public string seam_degree_of_filling { get; set; }//填充程度
        public string seam_filling_thing { get; set; }//填充物

        //宽度
        public bool width_greater_than_five { get; set; }//大于5
        public bool width_one_to_five { get; set; }//1-5
        public bool width_less_than_one { get; set; }//小于1

        //产况
        public string vertical_seam { get; set; }//立缝
        public string inclined_seam { get; set; }//斜缝
        public string flat_seaming { get; set; }//平缝

        //溶洞（晶洞）
        public int karst_cave_number { get; set; }//个数 
        public double karst_cave_density { get; set; }//密度
        public string karst_cave_degree_of_filling { get; set; }//填充程度
        public string karst_cave_filling_thing { get; set; }//填充物

        //直径
        public bool diameter_greater_than_ten { get; set; }//大于10
        public bool diameter_five_to_ten { get; set; }//5-10
        public bool diameter_less_than_five { get; set; }//小于5

        //填充物
        
    }

}
