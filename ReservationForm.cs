using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem.Entity;
using CarRentalSystem.Controllers;

namespace CarRentalSystem.Boundary
{
    public partial class ReservationForm : Form // displays info of selected vehicle, allows user to check and make reservations
    {
        public static ReservationForm instance; // public access to current instance of reservationForm
        public ReservationForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void ReservationForm_Load(object sender, EventArgs e) // custom date format on dateTimePicker objects
        {
            dateTimePicker_Start.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Start.CustomFormat = "yyyy-MM-dd";
            dateTimePicker_End.Format = DateTimePickerFormat.Custom;
            dateTimePicker_End.CustomFormat = "yyyy-MM-dd";
        }

        public static void Display(Vehicle vehicle) // displays a new reservationForm to user with selected vehicle info
        {
            ReservationForm reservationForm = new ReservationForm();

            if (vehicle.GetVid() == 1)
            {
                // these .png files imported to Resources folder, should travel with executable
                reservationForm.pictureBox_vehicle.Image = CarRentalSystem.Properties.Resources._2021_Honda_Civic;
            }

            if (vehicle.GetVid() == 2)
            {
                reservationForm.pictureBox_vehicle.Image = CarRentalSystem.Properties.Resources._2021_Subaru_Outback;
            }

            reservationForm.lbl_year.Text = vehicle.GetYear();
            reservationForm.lbl_make.Text = vehicle.GetMake();
            reservationForm.lbl_model.Text = vehicle.GetModel();

            reservationForm.Show();
        }

        private void btn_checkDates_Click(object sender, EventArgs e)
        {
            // converts default dateTime from dateTimePicker to string, then to int for comparison with date values in database
            string startString = dateTimePicker_Start.Value.Year.ToString() + dateTimePicker_Start.Value.Month.ToString() + dateTimePicker_Start.Value.ToString("dd");
            int startDate = int.Parse(startString);

            // format of these integers is yyyyMMdd (ex: 20211201 = 1 Dec, 2021)
            string endString = dateTimePicker_End.Value.Year.ToString() + dateTimePicker_End.Value.Month.ToString() + dateTimePicker_End.Value.ToString("dd");
            int endDate = int.Parse(endString);

            if (startDate > endDate) // validation to ensure user can't choose endDate earlier than startDate
            {
                lbl_message.Text = "Invalid date entry.";
            }

            else
            {
                if (ReserveController.CheckReservation(ReserveController.selectedVehicle.GetVid(), startDate, endDate) == true)
                {
                    // dateTimePickers are disabled so user can't change dates after reaching "available" state,
                    // can be reset by X'ing out window and reopening
                    lbl_message.Text = "Available";
                    dateTimePicker_Start.Enabled = false;
                    dateTimePicker_End.Enabled = false;
                    btn_reserve.Enabled = true;
                }

                if (ReserveController.CheckReservation(ReserveController.selectedVehicle.GetVid(), startDate, endDate) == false)
                {
                    // reserve button will not be enabled until user inputs available dates
                    lbl_message.Text = "Unavailable";
                    btn_reserve.Enabled = false;
                }
            }
        }

        private void btn_reserve_Click(object sender, EventArgs e) // clicking reserve button will save reservation to db and close form
        {
            // same date to int conversion as before
            string startString = dateTimePicker_Start.Value.Year.ToString() + dateTimePicker_Start.Value.Month.ToString() + dateTimePicker_Start.Value.ToString("dd");
            int startDate = int.Parse(startString);

            string endString = dateTimePicker_End.Value.Year.ToString() + dateTimePicker_End.Value.Month.ToString() + dateTimePicker_End.Value.ToString("dd");
            int endDate = int.Parse(endString);

            ReserveController.Reserve(ReserveController.selectedVehicle.GetVid(), startDate, endDate);
        }
    }
}