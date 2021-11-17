using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;
<<<<<<< Updated upstream
using Microsoft.Data.Sqlite;
=======
using CarRentalSystem.Boundary;
using System.Data.SQLite;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
                    string strSql = "DROP TABLE IF EXISTS [ACCOUNT]";
                    SqliteCommand cmd = new SqliteCommand(strSql, conn);
                    cmd.ExecuteNonQuery();
=======
                    conn.Open();
                    cmnd.Connection = conn;
                    string strSql = @"BEGIN TRANSACTION; 
                    DROP TABLE IF EXISTS ACCOUNT;
                    DROP TABLE IF EXISTS LOGIN;
                    DROP TABLE IF EXISTS LOGOUT;
                    DROP TABLE IF EXISTS VEHICLE;
                    DROP TABLE IF EXISTS RESERVATION;
                    COMMIT;";
                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();

                    string table = @"CREATE TABLE [ACCOUNT] (
                                  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                                , [username] TEXT NOT NULL
                                , [password] TEXT NOT NULL
                                , [type] TEXT NOT NULL
                                );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();

                    table = @"CREATE TABLE [LOGIN] (
                    [acctID] INTEGER NOT NULL
                    , [timestamp] TEXT NOT NULL
                    , CONSTRAINT [PK_LOGIN] PRIMARY KEY ([acctID],[timestamp])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();

                    table = @"CREATE TABLE [LOGOUT] (
                    [acctID] INTEGER NOT NULL
                    , [timestamp] TEXT NOT NULL
                    , CONSTRAINT [PK_LOGOUT] PRIMARY KEY ([acctID],[timestamp])
                    , FOREIGN KEY([acctID]) REFERENCES [ACCOUNT]([id])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();

                    table = @"CREATE TABLE [VEHICLE] (
                    [vid] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
                    , [make] TEXT NOT NULL
                    , [model] TEXT NOT NULL
                    , [year] TEXT NOT NULL
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();
>>>>>>> Stashed changes

                    strSql = "CREATE TABLE [ACCOUNT] " + "(id INT PRIMARY KEY NOT NULL," + " username TEXT NOT NULL, "
                            + " password TEXT NOT NULL, " + " type TEXT NOT NULL)";
                    SqliteCommand createTable = new SqliteCommand(strSql, conn);
                    createTable.ExecuteNonQuery();

<<<<<<< Updated upstream
=======
                    strSql = @"BEGIN TRANSACTION;
                    INSERT INTO ACCOUNT (username, password, type) VALUES ('cus', '1qaz', 'customer');
                    INSERT INTO ACCOUNT (username, password, type) VALUES ('emp', '2wsx', 'employee');
                    COMMIT;";
                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();

                    strSql = @"BEGIN TRANSACTION; 
                    INSERT INTO VEHICLE (make, model, year) VALUES ('Honda', 'Civic', '2021');
                    INSERT INTO VEHICLE (make, model, year) VALUES ('Subaru', 'Outback', '2021');
                    INSERT INTO RESERVATION (acctID, vid, startDate, endDate) VALUES (1, 1, 20211201, 20211203);
                    COMMIT;";
                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        public static Vehicle getVehicle(int vin)
=======

        public static Vehicle GetVehicle(int mvid) // returns vehicle info from database
>>>>>>> Stashed changes
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
            {
                conn.Open();
                {
                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "SELECT * FROM VEHICLE WHERE vid = '" + mvid + "';";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    Vehicle V = new Vehicle(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

                    reader.Close();
                    conn.Close();
                    return V;
                }
            }
        }
        public static void SaveLogin(string usr)
        {
        }
<<<<<<< Updated upstream
        public static bool checkReservation(int vin, DateTime date)
        {
=======

        public static bool CheckReservation(int vid, int inputStart, int inputEnd) // checks user input against dates in database
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
            {
                conn.Open();
                {
                    SQLiteCommand cmd = conn.CreateCommand();

                    // compares vehicle id, startDate, and endDate to user input and selected vehicle to ensure no conflicts
                    cmd.CommandText = "SELECT 1 FROM RESERVATION WHERE vid = '" + vid + "' AND startDate = '" + inputStart + "' OR vid = '" + vid + "' AND startDate = '" + inputEnd + "' OR vid = '" + vid + "' AND endDate = '" + inputStart + "' OR vid = '" + vid + "' AND endDate = '" + inputEnd + "' OR vid = '" + vid + "' AND startDate < '" + inputStart + "' AND '" + inputStart + "' < endDate OR vid = '" + vid + "' AND startDate < '" + inputEnd + "' AND '" + inputEnd + "' < endDate OR vid = '" + vid + "' AND '" + inputStart + "' < startDate AND '" + inputEnd + "' > endDate;";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        conn.Close();
                        return false; // a reservation conflict exists; unavailable to reserve for user input dates
                    }

                    else
                    {
                        reader.Close();
                        conn.Close();
                        return true; // no conflict; available for user input dates
                    }
                }
            }
>>>>>>> Stashed changes
        }
        public static void SaveLogout(string usr)
        {
        }
        public static void Save(int vid, int start, int end) // saves reservation to database
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = nCarDb.db;");
            {
                conn.Open();
                {
                    SQLiteCommand cmd = conn.CreateCommand();

                    try
                    {
                        cmd.CommandText = "INSERT INTO RESERVATION (acctID, vid, startDate, endDate) VALUES ('1', '" + vid + "', '" + start + "', '" + end + "');";
                        cmd.ExecuteNonQuery();
                    }

                    catch
                    {
                        ReservationForm.instance.Close();
                        throw new Exception("Entry already exist in database"); // somewhat redundant
                    }

                    finally
                    {
                        ReservationForm.instance.Close(); // reservationForm closes after reservation saved to database
                    }
                }
            }
        }
        */
    }
}