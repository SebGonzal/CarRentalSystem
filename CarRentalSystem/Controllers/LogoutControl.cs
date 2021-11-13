using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CarRentalSystem.Controllers
{
    class LogoutControl
    {
        public static void Logout(string username)
        {
            // Logs the user logout in the database
            DBConnector.SaveLogout(username);

            // Opens a new login form
            Application.Run(new LoginForm());
        }
    }
}
