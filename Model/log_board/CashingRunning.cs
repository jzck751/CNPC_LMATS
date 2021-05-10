using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class CashingRunning
    {
        //下套管
        public string bushing_type { get; set; }//套管类型
        public string external_dia { get; set; }//产地
        public string steel_grade { get; set; }//钢级
        public double wall_th { get; set; }//外径
        public double place_origin { get; set; }//壁厚
        public double depth { get; set; }//下深
        public double location_choke { get; set; }//阻流环位置
        public double short_casing { get; set; }//短套管位置
        public double hanger_pos { get; set; }//悬挂器位置
        public double location_gra_hoop { get; set; }//分级箍位置
        public double join_in { get; set; }//联入
    }
}
