using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОКФКС._1_3._0_
{
    public static class UserAccount
    {
        public static string userPassword = "1234567890";

        public static bool IsUser(string login, string password)
        {
            if (login == "user" && password == userPassword)
            {
                return true;
            }
            return false;
        }
    }
}
