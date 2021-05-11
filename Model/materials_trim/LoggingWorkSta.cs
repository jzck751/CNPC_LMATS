using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class LoggingWorkSta
    {
        //录井工作量统计表
        public string project { get; set; }//项目
        public double recording { get; set; }//井段
        public int number { get; set; }//数量
        public string qua_col { get; set; }//质量控制
        public string remarks { get; set; }//备注
    }
}
