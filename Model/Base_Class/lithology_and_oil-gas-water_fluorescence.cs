using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base_Class
{
    //这个基类封装的是岩性定名、岩性及含油气水描述、荧光这三个表的数据
    public class lithology_and_oil_gas_water_fluorescence
    {
        //岩性定名
        public string color { get; set; }//颜色
        public string oil_level { get; set; }//含油级别
        public string lithology { get; set; }//岩性

        //岩性及含油气水描述
        public string lithology_and_description_of_hydrocarbon_and_water { get; set; }//岩性及含油气水描述

        //荧光
        public string wet_according_to_color { get; set; }//湿照颜色
        public string according_to_the_color { get; set; }//滴照颜色
        public string do_according_to_color { get; set; }//干照颜色
        public string contrast_level { get; set; }//对比级别
    }
}
