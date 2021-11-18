using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Controllers
{
    class AvailControl
    {
        public static List<Entity.Vehicle> CheckAvail(DateTime startDate, DateTime endDate)
        {
            List<Entity.Vehicle> availList = new List<Entity.Vehicle>();

            availList = DBConnector.CheckAvailDates(startDate, endDate);

            return availList;
        }
    }
}
