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
        public string num { get; set; }//编号
        public double samp_well_dep { get; set; }//取样井深
        public double silver_ni_c { get; set; }//硝酸银浓度当量
        public double samp_v { get; set; }//取样体积
        public double chlo_con { get; set; }//氯根含量
        public double density { get; set; }//密度
        public double viscosity { get; set; }//粘度
        public string examiner { get; set; }//检验人

        //取样时间
        public string samp_time_d { get; set; }//日/月
        public string samp_time_m { get; set; }//时/分

        //硝酸银用量
        public string silv_ni_q { get; set; }//滴定前
        public string silv_ni_l { get; set; }//滴定后
        public string silv_ni_co { get; set; }//消耗量

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
