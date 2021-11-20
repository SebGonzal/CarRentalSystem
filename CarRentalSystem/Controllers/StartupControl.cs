using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Boundary;
using System.Diagnostics;

namespace CarRentalSystem.Controllers
{
    class StartupControl
    {
        public static LoginForm loginForm = new LoginForm();
        public static void Initiate()
        {
            // Initializes the database
            DBConnector.InitializeDB();

            // Opens the Login Form
            Application.Run(loginForm);

        }
    }
}
