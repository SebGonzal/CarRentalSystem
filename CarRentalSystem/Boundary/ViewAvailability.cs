using CarRentalSystem.Controllers;
using CarRentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSystem.Boundary
{
    public partial class ViewAvailability : Form
    {
        private int startDate;
        private int endDate;
        public static ViewAvailability instance;
        public ViewAvailability()
        {
            InitializeComponent(); //Initilize the form
            instance = this;
        }
        public void Display() // Displays the list of available vehicles in selected date range
        {
            List<Vehicle> availList = AvailControl.checkAvail(startDate, endDate);
            AvailList.Items.Clear();
            foreach (Vehicle vehicle in availList)
            {
                AvailList.Items.Add(vehicle.GetVid() + " | " + vehicle.GetYear() 
                    + " | " + vehicle.GetMake() + " | " + vehicle.GetModel());
            }
            daterange.Text = "Vehicles available from " + Startdate.Value.Month
                + "/" + Startdate.Value.Day + "/" + Startdate.Value.Year + " and "
                + Enddate.Value.Month + "/" + Startdate.Value.Day + "/" + Startdate.Value.Year + ".";
        }
        private void viewBtn_Click(object send, EventArgs e) // Click event for view button
        {
            Submit();
        }
        public void Submit() // Takes date range and displays error or availlist
        {
            string startString = Startdate.Value.Year.ToString() + Startdate.Value.ToString("MM") + Startdate.Value.ToString("dd");
            startDate = int.Parse(startString);
            string endString = Enddate.Value.Year.ToString() + Enddate.Value.ToString("MM") + Enddate.Value.ToString("dd");
            endDate = int.Parse(endString);
            if (startDate > endDate) // validation to ensure user can't choose endDate earlier than startDate
            {
                Message.Text = "Invalid date entry.";
            }
            else
            {
                Display();
            }
        }
        private void ViewAvailability_Load(object sender, EventArgs e)
        {
            Startdate.Format = DateTimePickerFormat.Custom;
            Startdate.CustomFormat = "yyyy-MM-dd";
            Enddate.Format = DateTimePickerFormat.Custom;
            Enddate.CustomFormat = "yyyy-MM-dd";
            Startdate.MinDate = DateTime.Today;
            Enddate.MinDate = DateTime.Today;
        }
        private void logoutBtn_Click(object sender, EventArgs e) // Event for logout button
        {
            ViewAvailability.instance.Close();
        }
        private void ViewAvailability_FormClosed(object sender, FormClosedEventArgs e) // Logout if form is closed
        {
            LogoutControl.Logout(LoginControl.thisUser);
        }
    }
}