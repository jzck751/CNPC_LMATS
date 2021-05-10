using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    public class Cementing
    {
        //固井
        public string cement_brand { get; set; }//水泥品牌
        public string cement_type { get; set; }//水泥类型
        public double inje_vol_cem_ { get; set; }//水泥浆注入量
        public double av_den_cem_sl { get; set; }//水泥浆平均密度
        public double cement_higt { get; set; }//水泥返高
        public double pres_test { get; set; }//试压
        public double displa_mud { get; set; }//替泥浆量
        public string lmpact_time { get; set; }//碰压时间
        public double impact_value { get; set; }//碰压值
        public double inject_amount_is_li { get; set; }//隔离液注入量
        public string cement_qua { get; set; }//固井质量
    }
}
