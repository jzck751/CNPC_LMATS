using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //缝洞统计表
    public class Form_B_4
    {
        public int core_barrel { get; set; }//取心筒次
        public double well_section { get; set; }//井段
        public int core_number{ get; set; }//岩心编号
        public double length { get; set; }//长度
        public string the_lithology_named { get; set; }//岩性定名
        public int total_number{ get; set; }//总条数
        public double the_total_density { get; set; }//总密度
        public int suture_line { get; set; }//缝合线
        public int plaques { get; set; }//块斑
        public int smoking_location { get; set; }//冒气处数
        public string connected_situation{ get; set; }//连通情况
    }
}
