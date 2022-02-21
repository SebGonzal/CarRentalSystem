using System;
using CarRentalSystem.Controllers;
namespace CarRentalSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartupControl.Initiate();
        }
    }
}
