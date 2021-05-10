using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class DrillingCoring
    {
        //钻井取芯
        public int tube_times { get; set; }//筒次
        public string horizon { get; set; }//层位
        public double coring_sect { get; set; }//取心井段
        public double footage { get; set; }//进尺
        public double core_length { get; set; }//岩心长度
        public double harvest_rate { get; set; }//收获率
    }
}
