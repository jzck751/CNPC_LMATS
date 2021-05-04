using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //自然伽马能谱录井分析记录
    public class Form_B_19
    {
        public int serial_number { get; set; }//序号
        public string position { get; set; }//层位
        public double well_depth { get; set; }//井深
        public double sample_weight { get; set; }//样品重量
        public double U { get; set; }//U
        public double Th { get; set; }//Th
        public double K { get; set; }//K
        public double the_total_rate { get; set; }//总计数率
        public double totalgamma { get; set; }//总伽马
        public double TOC { get; set; }//TOC
    }
}
