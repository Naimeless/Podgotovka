using Services;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, RoutedEventArgs e)
        {
            bool valid = Authentification.Login(LoginBox.Text, PasswordBox.Password);
            if (valid)
            {
                NavigationService.Navigate(new URL());
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль");
            }
        }
    }
}
