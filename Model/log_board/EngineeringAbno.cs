using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class EngineeringAbno
    {
        //工程异常报告
        public string time { get; set; }//时间
        public double well_depth { get; set; }//丼深
        public string excep_type { get; set; }//异常类型
        public string adoption { get; set; }//采纳情况
    }
}
