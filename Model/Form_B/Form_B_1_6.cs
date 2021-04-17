using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //评价录井
    public class Form_B_1_6
    {
        public string logging_projects { get; set; }//录井项目
        public string well_depth_to_depth { get; set; }//井段（深）
        public string analyse_sample_number { get; set; }//分析样品个数
        public string remark { get; set; }//备注
    }
}
