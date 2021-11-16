using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CarRentalSystem.Entity;

namespace CarRentalSystem.Controllers
{
    public static class DBConnector
    {
        public static void InitializeDB()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = .\\CarDB.db;Version=3;New=True;");

            conn.Open();
            {
                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "DROP TABLE IF EXISTS ACCOUNT";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS VEHICLE";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DROP TABLE IF EXISTS RESERVATION";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE ACCOUNT (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, username TEXT NOT NULL, password TEXT NOT NULL, type TEXT NOT NULL)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE VEHICLE (vid INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, make TEXT NOT NULL, model TEXT NOT NULL, year TEXT NOT NULL)";
                cmd.ExecuteNonQuery();

                // dates currently stored as INTEGER, format yyyyMMdd to aid in comparison; ex: 20211201 is 1 Dec, 2021.
                // dates separated into startDate and endDate
                cmd.CommandText = "CREATE TABLE RESERVATION (acctID INTEGER NOT NULL, vid INTEGER NOT NULL, startDate INTEGER NOT NULL, endDate INTEGER NOT NULL, PRIMARY KEY(acctID, vid, startDate, endDate))";
                cmd.ExecuteNonQuery();

                // hard coded elements added to database
                cmd.CommandText = "INSERT INTO ACCOUNT (username, password, type) VALUES ('cus', '1qaz', 'customer')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO ACCOUNT (username, password, type) VALUES ('emp', '2wsx', 'employee')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO VEHICLE (make, model, year) VALUES ('Honda', 'Civic', '2021')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO VEHICLE (make, model, year) VALUES ('Subaru', 'Outback', '2021')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO RESERVATION (acctID, vid, startDate, endDate) VALUES (1, 1, 20211201, 20211203)";
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public static Vehicle GetVehicle(int mvid) // returns vehicle info from database
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = .\\CarDB.db;Version=3;");
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

        public static bool CheckReservation(int vid, int inputStart, int inputEnd) // checks user input against dates in database
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = .\\CarDB.db;Version=3;");
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
        }

        public static void Save(int vid, int start, int end) // saves reservation to database
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = .\\CarDB.db;Version=3;");
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
    }
}