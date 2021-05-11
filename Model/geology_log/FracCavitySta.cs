using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class FracCavitySta
    {
        //缝洞统计
        public int time_cor { get; set; }//取心筒次
        public double well_sec { get; set; }//井段
        public int cori_num { get; set; }//岩心编号
        public double length { get; set; }//长度
        public string litho_namein { get; set; }//岩性定名
        public int total_num { get; set; }//总条数
        public double total_dens { get; set; }//总密度
        public int suture { get; set; }//缝合线
        public int plaque { get; set; }//块斑
        public int air_pla { get; set; }//冒气处数
        public string connect { get; set; }//连通情况

        //有效缝
        public int eff_seam_num { get; set; }//有效条数
        public double eff_seam_de { get; set; }//密度
        public string seam_degree_of_filling { get; set; }//填充程度
        public string seam_filling_thing { get; set; }//填充物

        //宽度
        public bool eff_seam_w_o { get; set; }//大于5
        public bool eff_seam_w_tw { get; set; }//1-5
        public bool eff_seam_w_t { get; set; }//小于1

        //产况
        public string eff_vert_seam { get; set; }//立缝
        public string eff_seam_in { get; set; }//斜缝
        public string eff_flat_seam { get; set; }//平缝

        //溶洞（晶洞）
        public int lim_cave_num { get; set; }//个数 
        public double lim_cave_de { get; set; }//密度
        public string cave_fil_le { get; set; }//填充程度
        public string cave_fil { get; set; }//填充物

        //直径
        public bool cave_diam_10 { get; set; }//大于10
        public bool cave_diam_5_10 { get; set; }//5-10
        public bool cave_diam_5 { get; set; }//小于5
    }
}
