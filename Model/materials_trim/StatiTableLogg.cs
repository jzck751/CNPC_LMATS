using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.materials_trim
{
    public class StatiTableLogg
    {
        public string date { get; set; }//日期
        public double well_sec { get; set; }//井段
        public string log_pro { get; set; }//测井项目
        public double rate { get; set; }//比例
        public string log_co { get; set; }//情况

    }
}
