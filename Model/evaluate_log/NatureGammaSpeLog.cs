
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class NatureGammaSpeLog
    {
        //伽马
        public int num { get; set; }//序号
        public string horizon { get; set; }//层位
        public double wall_dep { get; set; }//井深
        public double samp_qua { get; set; }//样品重量
        public double u { get; set; }//U
        public double th { get; set; }//Th
        public double k { get; set; }//K
        public double total_co_ra { get; set; }//总计数率
        public double total_gamma { get; set; }//总伽马
        public double toc { get; set; }//TOC
    }
}
