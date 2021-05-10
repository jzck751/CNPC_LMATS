using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class DrillHead
    {
        //钻头
        public int number { get; set; }//序号
        public double size { get; set; }//尺寸
        public string type { get; set; }//类型
        public double acc_footage { get; set; }//累计进尺
        public string cum_pure_d_t { get; set; }//累计纯钻时间
    }
}
