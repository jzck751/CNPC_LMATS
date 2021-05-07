using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //溶洞/晶洞
    public class Form_B_4_2
    {
        public int number { get; set; }//个数 
        public double density { get; set; }//密度
        public string degree_of_filling { get; set; }//填充程度

        //直径
        public bool more_than_ten { get; set; }//大于10
        public bool five_to_ten { get; set; }//5-10
        public bool less_than_five { get; set; }//小于5

        //填充物
        public string filling_thing { get; set; }//填充物
    }
}
