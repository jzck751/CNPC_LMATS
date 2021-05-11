using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class CsaingRecord
    {
        //套管记录
        public int num { get; set; }//序号
        public double size { get; set; }
        public string pla_pro { get; set; }//产地
        public string steel_gra { get; set; }//钢级
        public double wall_thick { get; set; }//壁厚
        public double s_length { get; set; }//单根长
        public double tol_len { get; set; }//累长
        public double down_dep { get; set; }//下深
        public string remarks { get; set; }//备注
    }
}
