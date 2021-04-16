using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼套管丈量记录
    public class Form_A_6
    {
        public string date { get; set; }//日期
        public string serialNum { get; set; }//序号
        public string place_of_origin { get; set; }//产地
        public string steel_grade { get; set; }//钢级
        public double external_diametery { get; set; }//外径
        public double wall_thickness { get; set; }//壁厚
        public double solo_Length { get; set; }//单根长
        public string measurePerson { get; set; }//丈量人
        public string reviewPerson { get; set; }//复查人
        public string remark { get; set; }//备注
    }
}
