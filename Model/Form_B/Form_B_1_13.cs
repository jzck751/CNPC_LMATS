using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //测井
    public class Form_B_1_13
    {
        public string well_logging_projects { get; set; }//测井项目
        public double rate { get; set; }//比例
        public string well_depth_to_depth { get; set; }//井段
        public string remark { get; set; }//备注
    }
}
