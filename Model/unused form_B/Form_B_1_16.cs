using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //试油（测试）
    public class Form_B_1_16
    {
        public double well_depth_to_depth { get; set; }//丼段
        public double position { get; set; }//层位
        public string tools_structure { get; set; }//工具结构
        public double stratum_presure { get; set; }//地层压力
        public string work_fluid_type { get; set; }//工作液类型
        public string test_technology { get; set; }//测试工艺
        public string sealing_position_of_tester { get; set; }//测试器座封位置
        public string seat_sealing_time { get; set; }//座封时间
        public string unlock_time { get; set; }//解封时间
        public string open_or_close_well_time { get; set; }//开关井时间
        public string open_well_display_situation { get; set; }//开丼时显示情况
        public double reclycle_fluid_number { get; set; }//回收流体量
        public double preliminary_conversion_daily_fluid_production { get; set; }//初步折算流体日产量
        public string fluid_property { get; set; }//流体性质
        public string test_oil_conclusion { get; set; }//试油结论
    }
}
