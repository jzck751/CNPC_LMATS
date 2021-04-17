using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //后效气检测
    public class Form_B_1_11
    {
        public string time { get; set; }//时间
        public double drill_position { get; set; }//钻头位置
        public double the_peak_of_hydrocarbon { get; set; }//全烃峰值
        public double soar_speed { get; set; }//上窜速度
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public string groove_face_shows { get; set; }//槽面显示

    }
}
