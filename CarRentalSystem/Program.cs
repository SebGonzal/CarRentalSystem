using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Controllers;
using CarRentalSystem.Entity;
using System.Diagnostics;

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
