using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class EvualationLogging
    {
        //评价录井
        public string mud_log_p { get; set; }//录井项目
        public double well_secti { get; set; }//井段（深）
        public int num_ana_sam { get; set; }//分析样品个数
        public string remarks { get; set; }//备注
    }
}
