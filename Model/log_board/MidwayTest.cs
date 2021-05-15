using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    public class MidwayTest
    {
        //试油（测试）
        public double well_section { get; set; }//丼段
        public double horizon { get; set; }//层位
        public string tool_struct { get; set; }//工具结构
        public double forma_press { get; set; }//地层压力
        public string work_fluid_type { get; set; }//工作液类型
        public string test { get; set; }//测试工艺
        public string test_location { get; set; }//测试器座封位置
        public string seat_seal_time { get; set; }//座封时间
        public string unseal_time { get; set; }//解封时间
        public string well_op_clos_ti { get; set; }//开关井时间
        public string dis_well_op { get; set; }//开丼时显示情况
        public double quan_reco { get; set; }//回收流体量
        public double pre_con_daily { get; set; }//初步折算流体日产量
        public string fluid_pro { get; set; }//流体性质
        public string oil_test_con { get; set; }//试油结论
    }
}
