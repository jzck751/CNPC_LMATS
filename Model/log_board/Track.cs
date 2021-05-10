using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.log_board
{
    class Track
    {
        //测斜
        public double depth_measur { get; set; }//测斜井深
        public double well_angle { get; set; }//井斜角
        public double azimuth { get; set; }//方位角
    }
}
