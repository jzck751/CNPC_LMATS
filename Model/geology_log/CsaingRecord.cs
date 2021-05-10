using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class CsaingRecord
    {
        public string date { get; set; }//日期
        public int num { get; set; }//序号
        public string pla_pro { get; set; }//产地
        public string steel_gra { get; set; }//钢级
        public double ext_diam { get; set; }//外径
        public double wall_thick { get; set; }//壁厚
        public double s_length { get; set; }//单根长
        public string surveyor { get; set; }//丈量人
        public string reviewer { get; set; }//复查人
        public string remarks { get; set; }//备注
    }
}
