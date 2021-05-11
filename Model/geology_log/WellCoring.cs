using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class WellCoring
    {
        //丼壁取心
        public int num { get; set; }//序号
        public string horizon { get; set; }//层位

        //井深
        public double well_dep { get; set; }//顶深


        //岩性定名
        public string lith_name_co { get; set; }//颜色
        public string lith_name_oil { get; set; }//含油级别
        public string lith_name_lith { get; set; }//岩性

        //岩性及含油气水描述
        public string lit_des_wat { get; set; }//岩性及含油气水描述

        //荧光
        public string flu_wet { get; set; }//湿照颜色
        public string flu_color { get; set; }//滴照颜色
        public string flu_cont_le { get; set; }//干照颜色
    }
}
