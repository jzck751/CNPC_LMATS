using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //固井
    public class Form_B_1_15
    {
        public string cement_brand { get; set; }//水泥品牌
        public string cement_type { get; set; }//水泥类型
        public double cement_paste_injection_number { get; set; }//水泥浆注入量
        public double cement_paste_average_density { get; set; }//水泥浆平均密度
        public double cemenet_paste_back_height { get; set; }//水泥返高
        public double pressure_test{ get; set; }//试压
        public double replace_cement_paste_number { get; set; }//替泥浆量
        public string touch_the_pressure_time { get; set; }//碰压时间
        public double touch_the_presure_value { get; set; }//碰压值
        public double spacer_fluid_injection_number{ get; set; }//隔离液注入量
        public string well_cementation_quality { get; set; }//固井质量

    }
}
