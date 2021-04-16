using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼样品入库清单
    public class Form_A_4
    {
        public string region { get; set; }//地区
        public string  well_no{ get; set; }//丼别
        public string spud_date{ get; set; }//开钻日期
        public string finishing_drilling_well_depth{ get; set; }//完钻丼深
        public string finishing_drilling_date { get; set; }//完钻日期
        public string finishing_drilling_position { get; set; }//完钻层位
        public string trim_status { get; set; }//现场整理、取样及保管情况
        public string the_unit_directly { get; set; }//送样单位
        public string the_unit_directly_person { get; set; }//送样人
        public string the_unit_directly_date { get; set; }//送样时间
        public string warehouse_entry_results_and_problems { get; set; }//入库结果及存在问题
        public string acceptance_of_the_unit { get; set; }//验收单位
        public string acceptance_of_the_unit_person{ get; set; }//验收人
        public string acceptance_of_the_unit_date{ get; set; }//验收时间

    }
}
