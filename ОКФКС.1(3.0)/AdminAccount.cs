using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ОКФКС._1_3._0_
{
    public static class AdminAccount
    {
        public static string adminPassword = "admin123";

        public static bool IsAdmin(string login, string password)
        {
            if(login == "admin" && password == adminPassword)
            {
                return true;
            }
            return false;
        }
        public static void AdminWindowOpen()
        {
            IsAuthorized.result = true;
            MessageBox.Show("Добро пожаловать, админ!");
            AdminWindow adminWindow = new();
            adminWindow.ShowDialog();
        }
    }
}
