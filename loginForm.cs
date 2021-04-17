using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CNPC_LMATS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user_name = this.user_name_textBox.Text;
            string user_pwd = this.user_pwd_textBox.Text;

            if (user_name.Equals("") || user_pwd.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空!");
            }
            else
            {
                //string strcon = "server=localhost;user_id=root;password=123456;database=program";
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;user id=root;password=123456;database=program;pooling=true");

                try
                {
                    con.Open();
                    Console.WriteLine("已经建立连接!");
                    string query = "select * from manager";
                    string sqlSel = "select count(*) from manager where manager_id = '" + user_name + "' and manager_pwd = '" + user_pwd + "'";
                    MySqlCommand com = new MySqlCommand(sqlSel, con);
                    if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("登录成功！");

                        mainForm mF = new mainForm();
                        mF.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "打开数据库失败!");
                }
                finally
                {
                    //关闭连接
                    con.Close();
                    Console.WriteLine("数据库已关闭!");
                }
            }
        }
    }
}
