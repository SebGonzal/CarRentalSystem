namespace CarRentalSystem.Entity
{
    public class Account
    {
        private int id;
        private string username;
        private string type;
        public Account(int mid, string musername, string mtype)
        {
            SetId(mid);
            SetUsername(musername);
            SetType(mtype);
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int mid)
        {
            id = mid;
        }
        public string GetUsername()
        {
            return username;
        }
        public void SetUsername(string musername)
        {
            username = musername;
        }
        public string GetActType()
        {
            return type;
        }
        public void SetType(string mtype)
        {
            type = mtype;
        }
    }
}
