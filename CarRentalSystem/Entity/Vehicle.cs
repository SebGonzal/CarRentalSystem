using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Entity
{
    public class Vehicle
    {
        private int vid;
        private string make;
        private string model;
        private string year;

        public Vehicle(int mvid, string mmake, string mmodel, string myear)
        {
            SetVid(mvid);
            SetMake(mmake);
            SetModel(mmodel);
            SetYear(myear);
        }

        public int GetVid(int mvid)
        {
            return vid;
        }

        public void SetVid(int mvid)
        {
            vid = mvid;
        }

        public string GetMake(string mmake)
        {
            return make;
        }

        public void SetMake(string mmake)
        {
            make = mmake;
        }

        public string GetModel(string mmodel)
        {
            return model;
        }

        public void SetModel(string mmodel)
        {
            make = mmodel;
        }

        public string GetYear(string myear)
        {
            return year;
        }

        public void SetYear(string myear)
        {
            make = myear;
        }
    }
}
