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
        public string annularTubes_date { get; set; }//日期
        public int annularTubes_serialNum { get; set; }//序号
        public string annularTubes_place_of_origin { get; set; }//产地
        public string annularTubes_steel_grade { get; set; }//钢级
        public double annularTubes_external_diametery { get; set; }//外径
        public double annularTubes_wall_thickness { get; set; }//壁厚
        public double annularTubes_solo_Length { get; set; }//单根长
        public string annularTubes_measurePerson { get; set; }//丈量人
        public string annularTubes_reviewPerson { get; set; }//复查人
        public string annularTubes_remark { get; set; }//备注
    }
}
