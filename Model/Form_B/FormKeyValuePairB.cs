using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    public static class FormKeyValuePairB
    {
        public static Dictionary<string, string> formBDIc = new Dictionary<string, string>();
        public static Dictionary<string, string> formBNameDIc = new Dictionary<string, string>();
        static FormKeyValuePairB()
        {

            formBDIc.Add("A_5", "chloride_ti_dilling_a5");

            formBDIc.Add("B_1_1", "log_board__class_b1");
            //formBDIc.Add("B_1_2", "");
            formBDIc.Add("B_1_3", "well_rot_cond_b1");
            formBDIc.Add("B_1_4", "turn_head_data_b1");
            formBDIc.Add("B_1_5", "drilling_tool_structure_b1");
            formBDIc.Add("B_1_6", "drilling_para_b1");
            formBDIc.Add("B_1_7", "drilling_fluif_b1");
            formBDIc.Add("B_1_8", "late_time_b1");
            formBDIc.Add("B_1_9", "lith_oil_gas_water_b1");
            formBDIc.Add("B_1_10", "evaluation_logging_b1");
            formBDIc.Add("B_1_11", "instrument_op_cali_b1");
            formBDIc.Add("B_1_12", "engineering_abno_b1");
            formBDIc.Add("B_1_13", "track_b1");
            formBDIc.Add("B_1_14", "drilling_coring_b1");
            formBDIc.Add("B_1_15", "coring_well_wall_b1");
            formBDIc.Add("B_1_16", "afte_gas_de_record_b1");
            formBDIc.Add("B_1_17", "complexity_treatment_b1");
            formBDIc.Add("B_1_18", "text_well_b1");
            formBDIc.Add("B_1_19", "casing_running_b1");
            formBDIc.Add("B_1_20", "cementing_b1");
            formBDIc.Add("B_1_21", "midway_test_b1");

            formBDIc.Add("B_2", "cuttings_description_b2");
            formBDIc.Add("B_3", "descr_dilling_coring_b3");
            formBDIc.Add("B_4", "frac_cavity_sta_b4");
            //formBDIc.Add("B_5", "");
            formBDIc.Add("B_6", "");
            formBDIc.Add("B_7", "afte_gas_de_record_b7");
            formBDIc.Add("B_8", "special_cond_marking_b8");
            formBDIc.Add("B_9", "density_ana_mudston_b9");
            formBDIc.Add("B_10", "carbonate_con_ana_b10");
            formBDIc.Add("B_11", "quanti_flu_logging_b11");
            formBDIc.Add("B_12", "therm_detion_rock_b12");
            formBDIc.Add("B_13", "");
            formBDIc.Add("B_14", "gas _chroa__hydca_rocks_b14");
            formBDIc.Add("B_15", "light_hydr_logging_b15");
            formBDIc.Add("B_16", "nuc_mag_reson_b16");
            formBDIc.Add("B_17", "x-ray_diff_logging_b17");
            formBDIc.Add("B_18", "x_ray_fiuore_logging_b18");
            formBDIc.Add("B_19", "natural_gamma_spe_log_b19");
            formBDIc.Add("B_20", "csaing_record_b20");

            formBDIc.Add("C_1", "c1");
            formBDIc.Add("C_2", "c2");
            formBDIc.Add("C_3", "c3"); //未加
            formBDIc.Add("C_4", "c4");
            formBDIc.Add("C_5", "c5");

            formBDIc.Add("D_1", "basic_data_sheet_d1");
            formBDIc.Add("D_2", "strati_data_sheet_d2");
            formBDIc.Add("D_3", "logging_work_sta_d3");
            formBDIc.Add("D_4", "oil_gas_dis_sta_d4");
            formBDIc.Add("D_5", "sub_sta_table_drill_d5");
            formBDIc.Add("D_6", "stati_table_logg_d6");
            formBDIc.Add("D_7", "statis_dirll_co_d7");
            formBDIc.Add("D_8", "sta_table_ana_samp_d8");

            //
            formBNameDIc.Add("cuttings_description", "岩屑记录");
            formBNameDIc.Add("num", "序号");
            formBNameDIc.Add("horizon", "层位");
            formBNameDIc.Add("top_dep_well", "顶深");
            formBNameDIc.Add("bot_dep_well", "底深");
            formBNameDIc.Add("litholo_color", "颜色");
            formBNameDIc.Add("litholo_oil", "含油级别");
            formBNameDIc.Add("lithology", "岩性");
            formBNameDIc.Add("lit_descr", "岩性及含油气水描述");
            formBNameDIc.Add("flu_wet_illu", "湿照颜色");
            formBNameDIc.Add("named_cutt", "定名岩屑占岩屑(%)");
            formBNameDIc.Add("perce_oil_cut", "湿照颜含油岩屑占定名岩屑色");
            formBNameDIc.Add("flu_color", "荧光滴照颜色");
            formBNameDIc.Add("flu_dry_co", "荧光干照颜色");
            formBNameDIc.Add("flu_con_lev", "荧光对比级别");
        }

    }
}
