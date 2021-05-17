using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL.DBUtils
{
    public class UserDB
    {
        //用户登录的方法  
        public Model.LoginForm.UserInfo SelectUser(string userId, string Password)
        {
            //建立数据库连接
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "localhost";
            connectionString.UserID = "root";
            connectionString.Password = "123456";
            connectionString.Database = "cnpc_lmats1";
            connectionString.AllowUserVariables = true;

            using (MySqlConnection conn = new MySqlConnection(connectionString.ToString()))
            {
                //执行SQL语句进行查询
                MySqlCommand cmd = conn.CreateCommand();
                //添加两个参数
                cmd.Parameters.Add(new MySqlParameter(@"UserID", userId));
                cmd.Parameters.Add(new MySqlParameter(@"Password", Password));
                cmd.CommandText = string.Format("SELECT UserID,Password FROM users WHERE UserID =@UserID AND Password =@Password");
                //输出查询结果
                cmd.CommandType = CommandType.Text;

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                Model.LoginForm.UserInfo user = null;

                //读取具体的数据
                while (reader.Read())
                {
                    if (user == null)
                    {
                        user = new Model.LoginForm.UserInfo();
                    }
                    //读取查询到的数据
                    user.UserId = reader.GetString(0);
                    user.Password = reader.GetString(1);
                    //if (!reader.IsDBNull(3))
                    //{
                    //    user.Email = reader.GetString(3);
                    //}
                }
                return user;
            }
        }
    }

}

