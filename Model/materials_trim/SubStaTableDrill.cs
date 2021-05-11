using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class SubStaTableDrill
    {
        //钻井液性能分段统计表
        public string well_dep { get; set; }//层位
        public double well_sec { get; set; }//井段
        public string dirll_fil { get; set; }//钻井液体系
        public double fil_den { get; set; }//钻井液密度
        public double fil_vis { get; set; }//钻井液粘度
        public double cl_cont { get; set; }//氯离子含量
        public string dirll_flu_tr { get; set; }//钻井液处理情况
    }
}
