using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class StaTableAnaSamp
    {
        public int num { get; set; }//序号
        public string samp_time { get; set; }//取样日期
        public string well_dep { get; set; }//层位
        public double well_sec { get; set; }//井段
        public string samp_unit { get; set; }//取样单位
        public string samp_poe { get; set; }//取样人
        public string samp_type { get; set; }//样品类型
        public int samp_number { get; set; }//样品数量
        public string ana_project { get; set; }//分析项目
        public string rece_unit { get; set; }//接收单位
        public string receiver { get; set; }//接收人
    }
}
