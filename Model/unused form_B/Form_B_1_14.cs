using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //下套管 
    public class Form_B_1_14
    {
        public string drivepipe_type { get; set; }//套管类型
        public string place_of_origin { get; set; }//产地
        public string steel_grade { get; set; }//钢级
        public double external_diametery { get; set; }//外径
        public double wall_thickness { get; set; }//壁厚
        public double under_the_deep { get; set; }//下深
        public double choke_ring_position{ get; set; }//阻流环位置
        public double short_drivepipe_position { get; set; }//短套管位置
        public double hanger_position { get; set; }//悬挂器位置
        public double grading_ring_position{ get; set; }//分级箍位置
        public double access_to { get; set; }//联入
    }
}
