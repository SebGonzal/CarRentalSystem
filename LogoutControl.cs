using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Boundary;

namespace CarRentalSystem.Controllers
{
    class LogoutControl
    {
        public static void Logout(string username)
        {
            // Logs the user logout in the database
            DBConnector.SaveLogout(username);

            // Opens a new login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
