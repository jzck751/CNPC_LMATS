using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBUtils;

namespace BLL
{
    public class LoginManager
    {
        
        public Model.LoginForm.UserInfo UserLogin(string userName,string password)
        {
            UserDB UserDB = new UserDB();
            Model.LoginForm.UserInfo user = UserDB.SelectUser(userName, password);
            if(user != null)
            {
                
                return user;
            }
            else
            {
                throw new WrongInfoException();
            }
        }
    }

    public class WrongInfoException : Exception
    {

    }

    class TimeoutException : Exception
    {

    }
}
