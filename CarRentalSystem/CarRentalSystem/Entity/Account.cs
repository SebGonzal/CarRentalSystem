using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Entity
{
    public class Account
    {
        private int id;
        private string username;
        private string type;

        public Account(int mid, string musername, string mtype)
        {
            setId(mid);
            setUsername(musername);
            setType(mtype);
        }

        public int getId()
        {
            return id;
        }

        public void setId(int mid)
        {
            id = mid;
        }

        public string getUsername()
        {
            return username;
        }

        public void setUsername(string musername)
        {
            username = musername;
        }

        public string getType()
        {
            return type;
        }

        public void setType(string mtype)
        {
            type = mtype;
        }
    }
}
