using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼钻井液氯离子滴定记录
    public class Form_A_5
    {
        public string serialNum { get; set; }//编号
        public double sampling_depth { get; set; }//取样井深
        public double silver_nitrate_concentration_equivalent { get; set; }//硝酸银浓度当量
        public double sample_volume { get; set; }//取样体积
        public double Chlorine_root { get; set; }//氯根含量
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public string surveyory { get; set; }//检验人

    }
}
