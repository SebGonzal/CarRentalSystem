using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Entity
{
    public class Reservation
    {
        private DateTime startDate;
        private DateTime endDate;
        private string username;
        private int vid;

        public Reservation(DateTime mstartDate, DateTime mendDate, string musername, int mvid)
        {
            SetStartDate(mstartDate);
            SetEndDate(mendDate);
            SetUsername(musername);
            SetVid(mvid);
        }

        public DateTime GetStartDate()
        {
            return startDate;
        }

        public void SetStartDate(DateTime mstartDate)
        {
            startDate = mstartDate;
        }

        public DateTime GetEndDate()
        {
            return endDate;
        }

        public void SetEndDate(DateTime mendDate)
        {
            endDate = mendDate;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string musername)
        {
            username = musername;
        }

        public int GetVid()
        {
            return vid;
        }

        public void SetVid(int mvid)
        {
            vid = mvid;
        }
    }
}
