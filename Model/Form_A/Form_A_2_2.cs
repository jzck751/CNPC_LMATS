using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //钻井液泵参数
    public class Form_A_2_2
    {
        public double set_of_cylinder_diameter { get; set; }//套缸直径（mm）
        public double snumber_of_punchings { get; set; }//冲数(str/min)
        public double displacement { get; set; }//排量（L/s）
    }
}
