using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class BasicDataSheet
    {
        //基本数据表
        public int wall_num { get; set; }//井号
        public string well { get; set; }//丼别
        public string wall_type { get; set; }//井型
        public string well_location { get; set; }//井位地理位置
        public string well_loc_str { get; set; }//井位构造位置
        public string well_loc_line { get; set; }//井位测线位置
        public string re_pos_well { get; set; }//井间相对位置
        public double cor_lo_we_lo { get; set; }//井位设计坐标经度
        public double cor_la_we_lo { get; set; }//井位设计坐标纬度
        public double ac_lo_well { get; set; }//井位实际坐标经度
        public double ac_la_well { get; set; }//井位实际坐标纬度
        public double cor_x { get; set; }//井位设计坐标X，m
        public double cor_y { get; set; }//井位设计坐标Y，m
        public double ac_x { get; set; }//井位实际坐标X，m
        public double ac_y { get; set; }//井位实际坐标Y,m
        public double ta_co_la_de { get; set; }//井位设计中靶纬度
        public double ta_co_lo_d { get; set; }//井位设计中靶经度
        public double ta_co_x { get; set; }//井位设计中靶X,m
        public double ta_co_y { get; set; }//井位设计中靶Y,m
        public double ac_ta_co_la_lo { get; set; }//井位实际中靶纬度
        public double ac_ta_co_lo_lo { get; set; }//井位实际中靶经度
        public double ac_ta_co_x { get; set; }//井位实际中靶坐标X,m
        public double ac_ta_co_y { get; set; }//井位实际中靶坐标Y,m
        public string de_well_f_coo { get; set; }//井位偏离设计坐标
        public double des_tar { get; set; }//设计中靶垂深
        public double ac_tar { get; set; }//实际中靶垂深
        public double wall_to_mo { get; set; }//井位总水平位移 
        public string wall_cl_az { get; set; }//井位闭合方位
        public double wall_tar_de { get; set; }//井位靶心距
        public double max_inc_sh { get; set; }//全井最大斜井
        public double max_po { get; set; }//全井最大斜井方位
        public double max_dep { get; set; }//全井最大斜井深
        public double buxingao { get; set; }//补心高
        public double bu_alti { get; set; }// 补心海拔
        public double wa_deep { get; set; }//水深
        public double des_dep { get; set; }//设计井深
        public string des_hor { get; set; }//设计层位
        public string pos_hor { get; set; }//目的层
        public double dri_dep_com { get; set; }//完钻井深度
        public string dri_hor_com { get; set; }//完钻井层位
        public string dir_id_co { get; set; }//完钻方法
        public string sta_dir_da { get; set; }//开钻日期
        public string con_dir_da { get; set; }//完钻日期
        public string wall_con_da { get; set; }//完井日期
        public double bit_pro { get; set; }//钻头程序
        public double cas_pro { get; set; }//套管程序
        public string remarks { get; set; }//备注

    }
}
