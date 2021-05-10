using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class CoringWellWall
    {
        //井壁取芯
        public string coring_time { get; set; }//取心时间
        public string coring_meth { get; set; }//取心方式
        public int design_num { get; set; }//设计颗数
        public int footage { get; set; }//实取颗数
        public double harvest_rate { get; set; }//收获率
    }
}
