using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //_____丼录井班报
    public class Form_B_1
    {
        public string date { get; set; }//日期
        public string classes { get; set; }//班次
        public string watch { get; set; }//值班人
        public double hands_the_well_depth { get; set; }//交班井深
        public double position { get; set; }//层位
        public double drilling_footage{ get; set; }//进尺
        public string drilling_tool_structure { get; set; }//钻具结构
        public string gas_and_water_displaye { get; set; }//岩性及油气水显示
        public string instrument_operation_and_calibration { get; set; }//仪器运行及校验
        public string Logging_captain { get; set; }//录井队长
        public string geological_supervision{ get; set; }//地质监督

    }
}
