using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //钻井参数
    public class Form_B_1__3
    {
        public double drill_presure { get; set; }//钻压
        public int wheel_revolutions { get; set; }//转盘转数
        public double displacement { get; set; }//排量
        public double pumping_pressure { get; set; }//泵压
        public double torque { get; set; }//扭矩
        public double hanging_load{ get; set; }//悬重
    }
}
