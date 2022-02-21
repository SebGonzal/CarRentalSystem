using System.Windows.Forms;
using CarRentalSystem.Boundary;

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
