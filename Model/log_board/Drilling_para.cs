using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class Drilling_para
    {
        //钻井参数
        public double wob { get; set; }//钻压
        public int rota_num_turn { get; set; }//转盘转数
        public double displact { get; set; }//排量
        public double mpa { get; set; }//泵压
        public double torque { get; set; }//扭矩
        public double su_weight { get; set; }//悬重
    }
}
