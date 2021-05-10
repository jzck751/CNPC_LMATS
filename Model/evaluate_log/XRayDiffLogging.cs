using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.evaluate_log
{
    public class XRayDiffLogging
    {
        public int num { get; set; }//序号
        public double wall_dep { get; set; }//井深
        public string lit_name { get; set; }//岩性定名

        //矿物含量
        public double miner_1cont { get; set; }//矿物1含量
        public double miner_2cont { get; set; }//矿物2含量
        public double miner_3cont { get; set; }//矿物3含量
        public double miner_4cont { get; set; }//矿物4含量
        public double miner_5cont { get; set; }//矿物5含量
        public double miner_6cont { get; set; }//矿物6含量
        public double miner_7cont { get; set; }//矿物7含量
        public double miner_8cont { get; set; }//矿物8含量
    }
}
