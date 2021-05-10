using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class BasicMaterials
    {
        public string date { get; set; }//日期
        public int classes { get; set; }//班次
        public string watcher { get; set; }//值班人
        public double shift { get; set; }//交班井深
        public double horizon { get; set; }//层位
        public double footage { get; set; }//进尺
    }
}
