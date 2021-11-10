using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using CarRentalSystem.Entity;

namespace CarRentalSystem.Controllers
{
    public static class DBConnector
    {
        public static void InitializeDB()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source = CarDB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "DROP TABLE IF EXISTS ACCOUNT";
                    cmd.ExecuteNonQuery();

                    string strSql = "CREATE TABLE ACCOUNT " + "(id INT PRIMARY KEY NOT NULL," + " username TEXT NOT NULL, "
                            + " password TEXT NOT NULL, " + " type TEXT NOT NULL, )";
                    cmd.CommandText = strSql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static Account GetUser(string usr, string pwd)
        {

        }
        public static VehicleInfoList getVehicles()
        {
        }
        public static Vehicle getVehicle(int vin)
        {
        }
        public static void SaveLogin(string usr)
        {
        }
        public static bool checkReservation(int vin, DateTime date)
        {
        }
        public static void SaveLogout(string usr)
        {
        }
        public static void Save(Reservation reservation)
        {
        }
    }
}
