using CarRentalSystem.Entity;
using CarRentalSystem.Boundary;

namespace CarRentalSystem.Controllers
{
    public static class ReserveController // controller for Reserve use case
    {
        public static Vehicle selectedVehicle; // public access to currently selected vehicle
        public static void View(int vid)
        {
            selectedVehicle = DBConnector.GetVehicle(vid); // stores selected vehicle info from database
            ReservationForm.Display(selectedVehicle); // display ReservationForm to user with selected vehicle info
            ReserveInitial.instance.Hide();
        }
        public static bool CheckReservation(int vid, int start, int end) // "go-between" from check reservation button to database
        {
            if (DBConnector.CheckReservation(vid, start, end) == true)
            {
                return true;
            }
            else return false;
        }
        public static void Reserve(int vid, int start, int end) // "go-between" from reserve button to database
        {
            DBConnector.Save(vid, start, end);
        }
    }
}