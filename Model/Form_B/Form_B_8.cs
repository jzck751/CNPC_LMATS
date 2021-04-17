using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //工程异常报告单
    public class Form_B_8
    {
        public string well_no { get; set; }//丼号
        public string date_time { get; set; }//日期
        public string well_log_team{ get; set; }//录井队
        public string well_drill_team { get; set; }//钻井队
        public double drill_to_the_depth { get; set; }//钻达井深
        public double exception_position { get; set; }//异常层位
        public string exception_start_time { get; set; }//异常开始时间
        public string report_time { get; set; }//报告时间
        public double exception_well_depth_to_depth { get; set; }//异常井段
        public string exception_parameter_change_situation { get; set; }//异常参数变化情况
        public string analyse_result_report { get; set; }//分析结果报告
        public string suggest_handle_measure { get; set; }//建议处理措施
        public string adapt_situation { get; set; }//采纳情况
        public string true_result { get; set; }//实际结果
        public string report_accord_situation { get; set; }//报告符合情况
        public string well_log_reporter { get; set; }//录井报告人
        public string well_log_header_signature { get; set; }//录井队长签字
        public string well_drill_team_or_the_supervise { get; set; }//钻井队或监督签字
        public string geology_supervise_signature { get; set; }//地质监督签字

    }
}
