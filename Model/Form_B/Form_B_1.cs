using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //_____丼录井班报
    public class Form_B_1
    {
        public string date { get; set; }//日期
        public int classes { get; set; }//班次
        public string watch { get; set; }//值班人
        public double hands_the_well_depth { get; set; }//交班井深
        public double position { get; set; }//层位
        public double drilling_footage{ get; set; }//进尺
        public string drilling_tool_structure { get; set; }//钻具结构
        public string lithology_and_description_of_hydrocarbon_and_water { get; set; }//岩性及油气水显示
        public string instrument_operation_and_calibration { get; set; }//仪器运行及校验
        public string Logging_captain_signature { get; set; }//录井队长
        public string geological_supervision_signature{ get; set; }//地质监督


        //钻井工况
        public string drilling_well_situation_date { get; set; }//时间
        public string construction_brief { get; set; }//施工简况

        //钻头
        public int drill_number { get; set; }//序号
        public double drill_size { get; set; }//尺寸
        public string drill_type { get; set; }//类型
        public double drill_the_cumulative_penetration { get; set; }//累计进尺
        public string drill_accumulated_net_drilling_time { get; set; }//累计纯钻时间

        //钻井参数
        public double drill_pressure { get; set; }//钻压
        public int wheel_revolutions { get; set; }//转盘转数
        public double displacement { get; set; }//排量
        public double pumping_pressure { get; set; }//泵压
        public double torque { get; set; }//扭矩
        public double hanging_load { get; set; }//悬重

        //钻井液性能
        public string drilling_fluid_type { get; set; }//类型
        public double drilling_fluiddensity { get; set; }//密度
        public double drilling_fluid_viscosity { get; set; }//粘度
        public double drilling_fluid_water_loss { get; set; }//失水
        public double drilling_fluid_mud_cake { get; set; }//泥饼
        public double drilling_fluid_for_cutting { get; set; }//补切
        public double drilling_fluid_egress { get; set; }//终切
        public double drilling_fluid_sand_content { get; set; }//含砂
        public double drilling_fluid_coefficient_of_friction_resistance { get; set; }//摩阻系数
        public double drilling_fluid_300_revolutions { get; set; }//300转读数
        public double drilling_fluid_600_revolutions { get; set; }//600转读数
        public double drilling_fluid_HTHP_water_loss { get; set; }//HTHP失水
        public double drilling_fluid_pH_value { get; set; }//pH值
        public double drilling_fluid_like_the_content { get; set; }//般土含量
        public double drilling_fluid_solid_content { get; set; }//固相含量
        public double drilling_fluid_chloridion { get; set; }//氯离子
        public double drilling_fluid_total_salinity { get; set; }//总矿化度
        public string drilling_fluid_affects_logging_treatment_agents { get; set; }//影响录井处理剂

        //迟到时间
        public double measure_the_hole_depth { get; set; }//测量井深
        public string delay_time { get; set; }//迟到时间


        //评价录井
        public string logging_projects { get; set; }//录井项目
        public double well_depth_to_depth { get; set; }//井段（深）
        public int analyse_sample_number { get; set; }//分析样品个数
        public string evaluate_projects_remark { get; set; }//备注

        //工程异常报告
        public string exception_report_time { get; set; }//时间
        public double exception_report_well_depth { get; set; }//丼深
        public string exception_report_type { get; set; }//异常类型
        public string adapt_situation { get; set; }//采纳情况

        //测斜
        public double survey_well_depth { get; set; }//测斜井深
        public double hole_drift_angle { get; set; }//井斜角
        public double azimuthal_angle { get; set; }//方位角

        //钻井取芯
        public int drill_take_core_canister { get; set; }//筒次
        public string drill_take_core_position { get; set; }//层位
        public double drill_take_core_depth_to_depth { get; set; }//取心井段
        public double drill_take_core_footage { get; set; }//进尺
        public double drill_take_core_crock_coring_length { get; set; }//岩心长度
        public double drill_take_core_yield_rate { get; set; }//收获率


        //后效气检测
        public string after_effect_gas_detection_time { get; set; }//时间
        public double after_effect_gas_detection_drill_location { get; set; }//钻头位置
        public double after_effect_gas_detection_the_peak_of_hydrocarbon { get; set; }//全烃峰值
        public double after_effect_gas_detection_soar_speed { get; set; }//上窜速度
        public double after_effect_gas_detection_density { get; set; }//密度
        public double after_effect_gas_detection_viscosity { get; set; }//粘度
        public string after_effect_gas_detection_groove_face_shows { get; set; }//槽面显示

        //钻井复杂或事故处理过程
        public double drill_difficultOr_acident_and_handle_process_well_depth { get; set; }//井深
        public string drill_difficultOr_acident_and_handle_process_date { get; set; }//时间
        public string drill_difficultOr_acident_and_handle_process_stratum { get; set; }//地层
        public string drill_difficultOr_acident_and_handle_process_type { get; set; }//复杂事故类型
        public string drill_difficultOr_acident_and_handle_process_handle_process { get; set; }//处理过程
        public string drill_difficultOr_acident_and_handle_process_relieve_time { get; set; }//解除时间
        public string drill_difficultOr_acident_and_handle_process_remark { get; set; }//备注

        //测井
        public string measure_well_projects { get; set; }//测井项目
        public double measure_well_rate { get; set; }//比例
        public string measure_well_well_depth_to_depth { get; set; }//井段
        public string measure_well_remark { get; set; }//备注

        //下套管
        public string down_annular_tubes_type { get; set; }//套管类型
        public string down_annular_tubes_place_of_origin { get; set; }//产地
        public string down_annular_tubes_steel_grade { get; set; }//钢级
        public double down_annular_tubes_external_diametery { get; set; }//外径
        public double down_annular_tubes_wall_thickness { get; set; }//壁厚
        public double down_annular_tubes_under_the_deep { get; set; }//下深
        public double down_annular_tubes_choke_ring_position { get; set; }//阻流环位置
        public double down_annular_tubes_short_drivepipe_position { get; set; }//短套管位置
        public double down_annular_tubes_hanger_position { get; set; }//悬挂器位置
        public double down_annular_tubes_grading_ring_position { get; set; }//分级箍位置
        public double down_annular_tubes_access_to { get; set; }//联入

        //固井
        public string solid_well_cement_brand { get; set; }//水泥品牌
        public string solid_well_cement_type { get; set; }//水泥类型
        public double solid_well_cement_paste_injection_number { get; set; }//水泥浆注入量
        public double solid_well_cement_paste_average_density { get; set; }//水泥浆平均密度
        public double solid_well_cemenet_paste_back_height { get; set; }//水泥返高
        public double solid_well_pressure_test { get; set; }//试压
        public double solid_well_replace_cement_paste_number { get; set; }//替泥浆量
        public string solid_well_touch_the_pressure_time { get; set; }//碰压时间
        public double solid_well_touch_the_presure_value { get; set; }//碰压值
        public double solid_well_spacer_fluid_injection_number { get; set; }//隔离液注入量
        public string solid_well_well_cementation_quality { get; set; }//固井质量

        //试油（测试）
        public double test_oil_well_depth_to_depth { get; set; }//丼段
        public double test_oil_position { get; set; }//层位
        public string test_oil_tools_structure { get; set; }//工具结构
        public double test_oil_stratum_presure { get; set; }//地层压力
        public string test_oil_work_fluid_type { get; set; }//工作液类型
        public string test_oil_test_technology { get; set; }//测试工艺
        public string test_oil_sealing_position_of_tester { get; set; }//测试器座封位置
        public string test_oil_seat_sealing_time { get; set; }//座封时间
        public string test_oil_unlock_time { get; set; }//解封时间
        public string test_oil_open_or_close_well_time { get; set; }//开关井时间
        public string test_oil_open_well_display_situation { get; set; }//开丼时显示情况
        public double test_oil_reclycle_fluid_number { get; set; }//回收流体量
        public double test_oil_preliminary_conversion_daily_fluid_production { get; set; }//初步折算流体日产量
        public string test_oil_fluid_property { get; set; }//流体性质
        public string test_oil_test_oil_conclusion { get; set; }//试油结论

        //录井队长及地质监督
        public string signature_well_log_header { get; set; }//录井队长
        public string signature_geology_supervise { get; set; }//地质监督

        //井壁取芯
        public string well_wall_take_core_date { get; set; }//取心时间
        public string well_wall_take_core_way { get; set; }//取心方式
        public int well_wall_take_core_design_number { get; set; }//设计颗数
        public int well_wall_take_core_true_get_number { get; set; }//实取颗数
        public double well_wall_take_core_yiele_rate { get; set; }//收获率



    }
}
