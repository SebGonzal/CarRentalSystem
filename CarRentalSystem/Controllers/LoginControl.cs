using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;
<<<<<<< Updated upstream
=======
using System.Windows.Forms;
using CarRentalSystem.Boundary;
>>>>>>> Stashed changes

namespace CarRentalSystem.Controllers
{
    public static class LoginControl
    {
        public static bool Login(string username, string password)
        {
<<<<<<< Updated upstream
            // Account account = DBConnector.GetUser(username, password);
 
            return false;
=======
            Account account = DBConnector.GetUser(username, password);
            bool isUser = Validate(account);
            if (isUser)
            {
                DBConnector.SaveLogin(username);
                if (account.GetActType() == "Employee")
                {
                    // code to open ViewAvaialability
                    return isUser;
                }
                else if (account.GetActType() == "customer")
                {
                    ReserveInitial rInitial = new ReserveInitial();
                    rInitial.Show();
                    return isUser;
                }
            }
            else
            {
                return isUser;
            }
            return isUser;
>>>>>>> Stashed changes
        }

        public static void Validate(Account acct)
        {
<<<<<<< Updated upstream

=======
            if (acct.GetActType() is null)
            {
                return false;
            }
            else
            {
                return true;
            }
>>>>>>> Stashed changes
        }
    }
}
