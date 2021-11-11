using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;
using Microsoft.Data.Sqlite;

namespace CarRentalSystem.Controllers
{
    public static class DBConnector
    {
        public static void InitializeDB()
        {
            using (SqliteConnection conn = new SqliteConnection("Data Source = CarDB.db"))
            {
                conn.Open();
                {
                    string strSql = "DROP TABLE IF EXISTS [ACCOUNT]";
                    SqliteCommand cmd = new SqliteCommand(strSql, conn);
                    cmd.ExecuteNonQuery();

                    strSql = "CREATE TABLE [ACCOUNT] " + "(id INT PRIMARY KEY NOT NULL," + " username TEXT NOT NULL, "
                            + " password TEXT NOT NULL, " + " type TEXT NOT NULL)";
                    SqliteCommand createTable = new SqliteCommand(strSql, conn);
                    createTable.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
        /*
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
        */
    }
}