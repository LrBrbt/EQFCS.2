using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОКФКС._1_3._0_
{
    public static class OperatorAccount
    {
        public static string operatorPassword = "operator456";

        public static bool IsAdmin(string login, string password)
        {
            if (login == "admin" && password == operatorPassword)
            {
                return true;
            }
            return false;
        }
    }
}
