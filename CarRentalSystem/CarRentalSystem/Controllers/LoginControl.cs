using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;

namespace CarRentalSystem.Controllers
{
    public static class LoginControl
    {
        public static bool Login(string username, string password)
        {
            Account account = DBConnector.GetUser(username, password);
        }

        public static void Validate(Account acct)
        {

        }
    }
}
