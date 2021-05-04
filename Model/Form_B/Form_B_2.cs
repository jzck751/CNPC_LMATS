using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩屑描述记录
    public class Form_B_2
    {
        public int serial_number { get; set; }//序号
        public string position { get; set; }//层位

        //井段
        public double top_depth { get; set; }//顶深
        public double bottom_depth { get; set; }//底深


        //岩性定名
        public string color { get; set; }//颜色
        public string oil_level { get; set; }//含油级别
        public string lithology { get; set; }//岩性

        //岩性及含油气水描述
        public string lithology_and_description_of_hydrocarbon_and_water { get; set; }//岩性及含油气水描述

        //荧光
        public string wet_according_to_color { get; set; }//湿照颜色
        public string according_to_the_color { get; set; }//滴照颜色
        public string dry_according_to_color { get; set; }//干照颜色
        public string contrast_level { get; set; }//对比级别

        public double designated_cuttings_of_cuttings { get; set; }//定名岩屑占岩屑
        public double oil_bearing_cuttings_are_named_cuttings { get; set; }//含油岩屑占定名岩屑
    }
}
