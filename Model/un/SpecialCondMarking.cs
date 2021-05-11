using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class SpecialCondMarking
    {
        public int well_num { get; set; }//丼号
        public string date { get; set; }//日期
        public string log_team { get; set; }//录井队
        public string drill_team { get; set; }//钻井队
        public double well_dep { get; set; }//钻达井深
        public double abno_hori { get; set; }//异常层位
        public string abno_st_time { get; set; }//异常开始时间
        public string report_time { get; set; }//报告时间
        public double abno_ho { get; set; }//异常井段
        public string abno_para_ch { get; set; }//异常参数变化情况
        public string ana_re_rep { get; set; }//分析结果报告
        public string proposal { get; set; }//建议处理措施
        public string adoption { get; set; }//采纳情况
        public string act_res { get; set; }//实际结果
        public string report_com { get; set; }//报告符合情况
        public string mud_log_rep { get; set; }//录井报告人
        public string sig_dil_te { get; set; }//录井队长签字
        public string sig_captain { get; set; }//钻井队或监督签字
        public string sig_geo_su { get; set; }//地质监督签字
    }
}
