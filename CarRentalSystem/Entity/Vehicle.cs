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
        public int GetVid()
        {
            return vid;
        }
        public void SetVid(int mvid)
        {
            vid = mvid;
        }
        public string GetMake()
        {
            return make;
        }
        public void SetMake(string mmake)
        {
            make = mmake;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetModel(string mmodel)
        {
            model = mmodel;
        }
        public string GetYear()
        {
            return year;
        }
        public void SetYear(string myear)
        {
            year = myear;
        }
    }
}