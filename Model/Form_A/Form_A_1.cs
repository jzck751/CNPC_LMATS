using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Form_A
{
    //_____丼钻具丈量记录
    public class Form_A_1
    {
        public string data { get; set; }//日期
        public string serialNum { get; set; }//序号
        public double soloLength { get; set; }//单根长度
        public string measurePerson { get; set; }//丈量人
        public string reviewPerson { get; set; }//复查人
        public string remark { get; set; }//备注
    }
}
