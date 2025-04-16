using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinar.Connection;

namespace Veterinar.Fun
{
    internal class AutoClass
    {
        public static ObservableCollection<User> sotrudnik { get; set; }
        public static User AutorisationSotrudnik(string login, string password)
        {
            sotrudnik = new ObservableCollection<User>(DB.vet.User.ToList());
            var userExists = sotrudnik.Where(sotrudnik => sotrudnik.login == login && sotrudnik.password == password).FirstOrDefault();
            if (userExists != null)
            {
                return userExists;
            }
            else
            {
                return userExists;
            }
        }
    }
}
