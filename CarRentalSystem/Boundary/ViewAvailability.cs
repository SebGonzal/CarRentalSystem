using CarRentalSystem.Controllers;
using CarRentalSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Boundary
{

    public partial class ViewAvailability : Form
    {
        public static ViewAvailability instance;
        public ViewAvailability()
        {
            InitializeComponent();
            instance = this;
        }
        public void Display()
        {
            ViewAvailability Vform = new ViewAvailability();
            string startString = Startdate.Value.Year.ToString() + Startdate.Value.Month.ToString() + Startdate.Value.ToString("dd");
            int startDate = int.Parse(startString);
            string endString = Enddate.Value.Year.ToString() + Enddate.Value.Month.ToString() + Enddate.Value.ToString("dd");
            int endDate = int.Parse(endString);
            if (startDate > endDate) // validation to ensure user can't choose endDate earlier than startDate
            {
                Message.Text = "Invalid date entry.";
            }
            else
            {
                List<Vehicle> list = AvailControl.checkAvail(startDate, endDate);
                {
                    // dateTimePickers are disabled so user can't change dates after reaching "available" state,
                    // can be reset by X'ing out window and reopening

                    /*dateTimePicker_Start.Enabled = false;
                    dateTimePicker_End.Enabled = false;
                    btn_reserve.Enabled = true;
                }

                if (ReserveController.CheckReservation(ReserveController.selectedVehicle.GetVid(), startDate, endDate) == false)
                {
                    // reserve button will not be enabled until user inputs available dates
                    lbl_message.Text = "Unavailable";
                    btn_reserve.Enabled = false;*/
                }
            }
        }
    
    public void Submit()
    {

    }
    private void ViewAvailability_Load(object sender, EventArgs e)
    {

    }
}
}
