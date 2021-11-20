using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Controllers
{
    class AvailControl
    {
        public static List<Entity.Vehicle> checkAvail(int startDate, int endDate)
        {
            List<Entity.Vehicle> availList = new List<Entity.Vehicle>();

            availList = DBConnector.checkAvailDates(startDate, endDate);

            return availList;
        }
    }
}
