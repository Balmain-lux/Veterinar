using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для Autorisation.xaml
    /// </summary>
    public partial class Autorisation : Page
    {
        public static User user;
        public Autorisation()
        {
            InitializeComponent();
        }
        public User sotrudnik { get; private set; }
        private void btnVhod_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTxb.Text.Trim();
            string password = parolTxb.Password.Trim();
            user = Fun.AutoClass.AutorisationSotrudnik(login, password);
            sotrudnik = Fun.AutoClass.AutorisationSotrudnik(login, password);
            if (sotrudnik != null)
            {
                NavigationService.Navigate(new UserPage(user));

            }
            else MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
