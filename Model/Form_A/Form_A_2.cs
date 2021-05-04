using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼迟到时间测量记录
    public class Form_A_2
    {
        public string data { get; set; }//时间
        public double drill_Location{ get; set; }//钻头位置
        public string theoretical_late_time { get; set; }//理论迟到时间
        public string cycle_time { get; set; }//循环一周时间
        public string downside_time { get; set; }//下行时间
        public string Line_delay_time { get; set; }//管路延迟时间
        public string measured_lateness_time { get; set; }//实测时间
        public string Adopt_late_time { get; set; }//采用迟到时间
        //public string Adopt_late_time { get; set; }//采用迟到时间
        public string adopt_well_depth { get; set; }//采用井深
        public string measurePerson { get; set; }//测量人
        public string verifyPerson { get; set; }//审核人
        public string remark { get; set; }//备注


        //环空体积(m³)
            public string inner_ring_empty { get; set; }//内环空
            public string outside_ring_empty { get; set; }//外环空


        //钻井液泵参数
            public double set_of_cylinder_diameter { get; set; }//套缸直径（mm）
            public double snumber_of_punchings { get; set; }//冲数(str/min)
            public double displacement { get; set; }//排量（L/s）



        //struct Annular_volume       //环空体积
        //{
        //    public string inner_ring_empty;//内环空
        //    public string outside_ring_empty;//外环空
        //};
        //struct Drilling_mud_pump    //钻井液泵参数
        //{
        //    public double set_of_cylinder_diameter;//套缸直径（mm）
        //    public double snumber_of_punchings;//冲数(str/min)
        //    public double displacement;//排量（L/s）
        //};
        //public Form_A_2(string v1, string v2, double p1, double p2, double p3){
        //    Annular_volume volume;
        //    Drilling_mud_pump pump;

        //    volume.inner_ring_empty = v1;
        //    volume.outside_ring_empty = v2;

        //    pump.set_of_cylinder_diameter = p1;
        //    pump.snumber_of_punchings = p2;
        //    pump.displacement = p3;
        //}

    }
}
