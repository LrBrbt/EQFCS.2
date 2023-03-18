using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ОКФКС._1_3._0_
{
    /// <summary>
    /// Логика взаимодействия для Авторизация.xaml
    /// </summary>
    public partial class Авторизация : Window
    {

        public Авторизация()
        {
            InitializeComponent();
        }
       
        const string userPassword = "1234567890";

        private void Window_Activated(object sender, EventArgs e)
        {
            

        }

        private void LogInBTN_Click(object sender, RoutedEventArgs e)
        {
            login_TB.Text = login_TB.Text.ToLower();
            login_TB.Text = login_TB.Text.Trim();

            if (AdminAccount.IsAdmin(login_TB.Text, passwordPB.Password))
            {
                IsAuthorized.result = true;
                MessageBox.Show("Добро пожаловать, админ!");
                AdminWindow adminWindow = new();
                adminWindow.Owner = this;

                this.Owner.Hide();
                Hide();

                adminWindow.ShowDialog();
            }
            else if (OperatorAccount.IsOperator(login_TB.Text, passwordPB.Password))
            {
                IsAuthorized.result = true;
                MessageBox.Show("Добро пожаловать, оператор!");

                OperatorWindow operatorWindow = new();
                operatorWindow.Owner = this;

                Hide();
                this.Owner.Hide();

                operatorWindow.ShowDialog();
                Close();
            }
            else if (UserAccount.IsUser(login_TB.Text, passwordPB.Password))
            {
                IsAuthorized.result = true;
                MessageBox.Show("Добро пожаловать, пользователь!");

                Hide();
            }
        }

        private void login_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void ForgotPasswordBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для пользователя admin - admin123\nДля пользователя operator - operator456\nДля пользователя user - 1234567890");
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Учтите, что чтобы пользоваться программой, необходимо пройти авторизацию.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
       
        }

        private void login_TB_GotFocus(object sender, RoutedEventArgs e)
        {
            login_TB.Text = "";
            login_TB.Foreground = Brushes.Black;
        }
    }
}
