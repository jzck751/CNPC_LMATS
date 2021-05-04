using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_B
{
    //岩心分块长度及井深校正记录
    public class Form_B_5
    {
        public int the_number_of_coring { get; set; }//取心次数
        public int total_block_number { get; set; }//总块号
        public int block_number { get; set; }//块号
        public double block_length { get; set; }//块长
        public double the_cumulative_length_of_the_cylinder { get; set; }//本筒累计长度
        public string crushed_and_polished_surface { get; set; }//破碎及磨光面
        public double drilling_boundary_depth { get; set; }//钻井底界深度
        public double corrected_value { get; set; }//校正值
        public double logging_bottom_depth { get; set; }//测井底界深度
        public int lithologic_segment_number { get; set; }//岩性分段序号
        public double lithologic_section_thickness { get; set; }//岩性段厚度
        public double compressed_length { get; set; }//压缩（拉伸）长度
        public string the_lithology_named { get; set; }//岩性定名
    }
}
