using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.geology_log
{
    public class CuttingsDescription
    {
        public int num { get; set; }//序号
        public string horizon { get; set; }//层位

        //井段
        public double top_dep_well { get; set; }//顶深
        public double bot_dep_well { get; set; }//底深


        //岩性定名
        public string litholo_color { get; set; }//颜色
        public string litholo_oil { get; set; }//含油级别
        public string lithology { get; set; }//岩性

        //岩性及含油气水描述
        public string lit_descr { get; set; }//岩性及含油气水描述

        //荧光
        public string flu_wet_illu { get; set; }//湿照颜色
        public string flu_color { get; set; }//滴照颜色
        public string flu_dry_co { get; set; }//干照颜色
        public string flu_con_lev { get; set; }//对比级别

        public double named_cutt { get; set; }//定名岩屑占岩屑
        public double perce_oil_cut { get; set; }//含油岩屑占定名岩屑
    }
}
