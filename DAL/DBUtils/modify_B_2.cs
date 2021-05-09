using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBUtils
{
    public class modify_B_2
    {
        //public DataTable select()
        //{ 

        //    return        
        //}
        public int add(int serial_number, string position, double top_depth, double bottom_depth, string color,
                            string oil_level, string lithology, string lithology_and_description_of_hydrocarbon_and_water,
                            string wet_according_to_color, string according_to_the_color, string dry_according_to_color,
                            string contrast_level, double designated_cuttings_of_cuttings, double oil_bearing_cuttings_are_named_cuttings)
        {
            int rows = 0;
            //建立数据库连接


            string sql = @"insert into sc values(@serialnumber, @position, @topdepth, @bottomdepth, @color,
                            @oillevel, @lithology, @lithologyanddescriptionofhydrocarbonandwater,
                            @wetaccordingtocolor, @accordingtothecolor, @dryaccordingtocolor,
                            @contrastlevel, @designatedcuttingsofcuttings, @oilbearingcuttingsarenamedcuttings);";
            List<MySqlParameter> Par = new List<MySqlParameter>();
            Par.Add(new MySqlParameter("@serialnumber", serial_number));
            Par.Add(new MySqlParameter("@position", position));
            Par.Add(new MySqlParameter("@topdepth", top_depth));
            Par.Add(new MySqlParameter("@bottomdepth", bottom_depth));
            Par.Add(new MySqlParameter("@color", color));
            Par.Add(new MySqlParameter("@oillevel", oil_level));
            Par.Add(new MySqlParameter("@lithology", lithology));
            Par.Add(new MySqlParameter("@lithologyanddescriptionofhydrocarbonandwater", lithology_and_description_of_hydrocarbon_and_water));
            Par.Add(new MySqlParameter("@wetaccordingtocolor", wet_according_to_color));
            Par.Add(new MySqlParameter("@accordingtothecolor", according_to_the_color));
            Par.Add(new MySqlParameter("@dryaccordingtocolor", dry_according_to_color));
            Par.Add(new MySqlParameter("@contrastlevel", contrast_level));
            Par.Add(new MySqlParameter("@designatedcuttingsofcuttings", designated_cuttings_of_cuttings));
            Par.Add(new MySqlParameter("@oilbearingcuttingsarenamedcuttings)", oil_bearing_cuttings_are_named_cuttings));
            //Par.Add(new MySqlParameter("", ));

            rows = DbManager.Ins.ExecuteNonquery(sql, Par.ToArray());

            return rows;
        }

        public int delete(int num)
        {
            int rows = 0;
            //建立数据库连接
            //删除
            string sql = @"delete from mc_rock-describe-record where serialNumber = @num;";
            List<MySqlParameter> Par_delete = new List<MySqlParameter>();
            Par_delete.Add(new MySqlParameter("@num", num));
            rows = DbManager.Ins.ExecuteNonquery(sql, Par_delete.ToArray());

            return rows;
        }
    }
}
