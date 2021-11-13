using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;
using System.Windows.Forms;

namespace CarRentalSystem.Controllers
{
    public static class LoginControl
    {
        public static bool Login(string username, string password)
        {
            Account account = DBConnector.GetUser(username, password);
            bool isUser = Validate(account);
            if (isUser)
            {
                DBConnector.SaveLogin(username);
                if (account.GetActType() == "Employee")
                {
                    // code to open ViewAvaialability
                    return isUser;
                }
                else if (account.GetActType() == "Customer")
                {
                    // code to open ReserveInitial
                    List<Vehicle> vehicleInfoList = DBConnector.getVehicles();
                    foreach (Vehicle v in vehicleInfoList)
                    {
                        /*
                        Console.WriteLine(v.GetVid());
                        Console.WriteLine(v.GetMake());
                        Console.WriteLine(v.GetModel());
                        Console.WriteLine(v.GetYear());
                        */
                    }
                    return isUser;
                }
            }
            return isUser;
        }

        public static bool Validate(Account acct)
        {
            if (acct.GetType() is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
