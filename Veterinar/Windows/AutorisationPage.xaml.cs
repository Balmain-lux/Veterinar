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
using Veterinar.Connection;

namespace Veterinar.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorisationPage.xaml
    /// </summary>
    public partial class AutorisationPage : Page
    {
        public static User user;
        public AutorisationPage()
        {
            InitializeComponent();
        }
        public User sotrudniks { get; set; }
        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTxb.Text.Trim();
            string password = parolTxb.Password.Trim();
            user = Fun.AutoClass.AutorisationSotrudnik(login, password);
            sotrudniks = Fun.AutoClass.AutorisationSotrudnik(login, password);
            if (sotrudniks != null)
            {
                UserPage userPage = new UserPage(user);
                userPage.Show();
            }
            else MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
