using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class BasicDataSheet
    {
        public int wall_num { get; set; }//井号
        public string well { get; set; }//丼别
        public string wall_type { get; set; }//井型
        public string well_location { get; set; }//井位地理位置
        public string well_loc_str { get; set; }
        public string well_loc_line { get; set; }
        public string re_pos_well { get; set; }
        public double cor_lo_we_lo { get; set; }
        public double cor_la_we_lo { get; set; }
        public double ac_lo_well { get; set; }
        public double ac_la_well { get; set; }
        public double cor_x { get; set; }
        public double cor_y { get; set; }
        public double ac_x { get; set; }
        public double ac_y { get; set; }
        public double ta_co_la_de { get; set; }
        public double ta_co_lo_d { get; set; }
        public double ta_co_x { get; set; }
        public double ta_co_y { get; set; }
        public double ac_ta_co_la_lo { get; set; }
        public double ac_ta_co_lo_lo { get; set; }
        public double ac_ta_co_x { get; set; }
        public double ac_ta_co_y { get; set; }
        public string de_well_f_coo { get; set; }
        public double des_tar { get; set; }
        public double ac_tar { get; set; }
        public double wall_to_mo { get; set; }
        public string wall_cl_az { get; set; }
        public double wall_tar_de { get; set; }
        public double max_inc_sh { get; set; }
        public double max_po { get; set; }
        public double max_dep { get; set; }
        public double buxingao { get; set; }
        public double bu_alti { get; set; }
        public double wa_deep { get; set; }
        public double des_dep { get; set; }
        public string des_hor { get; set; }
        public string pos_hor { get; set; }
        public double dri_dep_com { get; set; }
        public string dri_hor_com { get; set; }
        public string dir_id_co { get; set; }
        public string sta_dir_da { get; set; }
        public string con_dir_da { get; set; }
        public string wall_con_da { get; set; }
        public double bit_pro { get; set; }
        public double cas_pro { get; set; }
        public string remarks { get; set; }

    }
}
