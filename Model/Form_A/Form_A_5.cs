using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼钻井液氯离子滴定记录
    public class Form_A_5
    {
        public string serialNum { get; set; }//编号
        public double sampling_depth { get; set; }//取样井深
        public double silver_nitrate_concentration_equivalent { get; set; }//硝酸银浓度当量
        public double sample_volume { get; set; }//取样体积
        public double Chlorine_root { get; set; }//氯根含量
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public string surveyory { get; set; }//检验人

        //取样时间
        public string dateAndMonth { get; set; }//日/月
        public string hourAndMinute { get; set; }//时/分

        //硝酸银用量
        public string before_the_titration { get; set; }//滴定前
        public string after_the_titration { get; set; }//滴定后
        public string consumption { get; set; }//消耗量

        ////取样时间
        //struct sample_time{
        //    public string dateAndMonth;//日/月
        //    public string hourAndMinute;//时/分
        //}

        ////硝酸银用量
        //struct AgNO3_consume{
        //    public string before_the_titration;//滴定前
        //    public string after_the_titration;//滴定后
        //    public string  consumption;//消耗量
        //}

        //public Form_A_5(string time_1, string time_2, string consume_1, string consume_2, string consume_3){
        //    sample_time time;
        //    AgNO3_consume consume;

        //    time.dateAndMonth = time_1;
        //    time.hourAndMinute = time_2;
        //    consume.before_the_titration = consume_1;
        //    consume.after_the_titration = consume_2;
        //    consume.consumption = consume_3;
    }
    }
}
