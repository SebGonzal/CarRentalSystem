using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Controllers;
using CarRentalSystem.Entity;
using System.Diagnostics;

namespace CarRentalSystem.Controllers
{
    class StartupControl
    {
        public static void Initiate()
        {
            // Initializes the database
            DBConnector.InitializeDB();

            // Opens the Login Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
    }
}
