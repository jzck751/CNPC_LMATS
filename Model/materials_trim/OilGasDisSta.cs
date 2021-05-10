using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class OilGasDisSta
    {
        public int num { get; set; }//序号
        public string horizon { get; set; }//层位
        public double well_sec { get; set; }//井段
        public double thick { get; set; }//厚度
        public string lithology { get; set; }//岩性
        public double q_basic { get; set; }//全烃基值
        public double q_max { get; set; }//全烃峰值
        public double co { get; set; }//非烃co2
        public double hs { get; set; }//非烃H2S
        public double fi_den { get; set; }//钻井液密度
        public double fi_vis { get; set; }// 钻井液粘度
        public double fi_cl { get; set; }//钻井液氯离子含量
        public double oil_h { get; set; }//油花
        public double bubble { get; set; }//气泡
        public double oil_core_leng { get; set; }//含油气岩心长度
        public string wall_cen { get; set; }//壁心，颗 
        public string log_explain { get; set; }//录井解释
    }
}
