using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class AfterEffectGasDete
    {
        public string time { get; set; }//时间
        public double bit_position { get; set; }//钻头位置
        public double total_hyd_peak { get; set; }//全烃峰值
        public double up_speed { get; set; }//上窜速度
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public string slot_sur_dis { get; set; }//槽面显示
    }
}
