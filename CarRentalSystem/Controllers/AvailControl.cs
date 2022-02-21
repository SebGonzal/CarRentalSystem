using System.Collections.Generic;

namespace CarRentalSystem.Controllers
{
    class AvailControl
    {
        public static List<Entity.Vehicle> checkAvail(int startDate, int endDate) // gets list from dbconnector 
        {
            
            List<Entity.Vehicle> availList = new List<Entity.Vehicle>();

            availList = DBConnector.checkAvailDates(startDate, endDate);

            return availList;
        }
    }
}