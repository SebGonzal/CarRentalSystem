using CarRentalSystem.Entity;
using CarRentalSystem.Boundary;

namespace CarRentalSystem.Controllers
{
    public static class LoginControl
    {
        public static string thisUser;
        public static bool Login(string username, string password)
        {
            Account account = DBConnector.GetUser(username, password);
            bool isUser = Validate(account);
            if (isUser)
            {
                DBConnector.SaveLogin(username);
                thisUser = username;
                if (account.GetActType() == "employee")
                {
                    ViewAvailability viewAvailability = new ViewAvailability();
                    viewAvailability.Show();
                    return isUser;
                }
                else if (account.GetActType() == "customer")
                {
                    ReserveInitial rInitial = new ReserveInitial();
                    rInitial.Show();
                    return isUser;
                }
            }
            return isUser;
        }
        public static bool Validate(Account acct)
        {
            if (acct.GetActType() is null)
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