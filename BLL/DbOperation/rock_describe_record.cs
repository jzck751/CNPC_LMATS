using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBUtils;
using MySql.Data.MySqlClient;
using DAL.DBUtils;
namespace BLL.Update
{
    class rock_describe_record
    {
        public int delete(int serial_number, string position, double top_depth, double bottom_depth, string color,
                            string oil_level, string lithology, string lithology_and_description_of_hydrocarbon_and_water,
                            string wet_according_to_color, string according_to_the_color, string dry_according_to_color,
                            string contrast_level, double designated_cuttings_of_cuttings, double oil_bearing_cuttings_are_named_cuttings)
        {
            modify_B_2 modify = new modify_B_2();
            int rows = modify.add(serial_number, position, top_depth, bottom_depth, color,
                            oil_level, lithology, lithology_and_description_of_hydrocarbon_and_water,
                            wet_according_to_color, according_to_the_color, dry_according_to_color,
                            contrast_level, designated_cuttings_of_cuttings, oil_bearing_cuttings_are_named_cuttings);
            return rows;
        }
    }
}
