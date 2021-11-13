using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;
using System.Windows.Forms;

namespace CarRentalSystem.Controllers
{
    public static class LoginControl
    {
        public static bool Login(string username, string password)
        {
            Account account = DBConnector.GetUser(username, password);
            if (Validate(account))
            {
            }
            return Validate(account);
            

        }

        public static bool Validate(Account acct)
        {
            if (acct.GetType() is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
