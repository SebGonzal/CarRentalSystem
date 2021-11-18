using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Controllers;

namespace CarRentalSystem.Boundary
{
    public partial class ReserveInitial : Form // landing page after user logs in with customer account
    {
        public static ReserveInitial instance; // public access to current instance of ReserveInitial
        public int vid; // public access to vehicle id of user's selection from ReserveInitial
        public ReserveInitial()
        {
            InitializeComponent();
            instance = this;
        }

        private void btn_car1_Click(object sender, EventArgs e) // 2021 Honda Civic
        {
            vid = 1;
        }

        private void btn_car2_Click(object sender, EventArgs e) // 2021 Subaru Outback
        {
            vid = 2;
        }

        private void btn_view_Click(object sender, EventArgs e) // View button takes user to see more info about selected vehicle
        {
            if (vid > 0) // validation to ensure a selection must be made before clicking View button
            {
                ReserveController.View(vid);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ReserveInitial.instance.Close();
            LogoutControl.Logout(LoginControl.thisUser);
        }
    }
}
