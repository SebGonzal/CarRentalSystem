using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Entity;
using System.Data.SQLite;

namespace CarRentalSystem.Controllers
{
    public static class DBConnector
    {
        public static void InitializeDB()
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
            {
                
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
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
                                  [Id] INTEGER NOT NULL
                                , [username] TEXT NOT NULL
                                , [password] TEXT NOT NULL
                                , [type] TEXT NOT NULL
                                , CONSTRAINT [PK_ACCOUNT] PRIMARY KEY ([Id])
                                );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();

                    table = @"CREATE TABLE [LOGIN] (
                    [acctID] INTEGER NOT NULL
                    , [timestamp] TEXT NOT NULL
                    , CONSTRAINT [PK_LOGIN] PRIMARY KEY ([acctID],[timestamp])
                    , FOREIGN KEY([acctID]) REFERENCES [ACCOUNT]([id])
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
                    [vid] INTEGER NOT NULL
                    , [make] TEXT NOT NULL
                    , [model] TEXT NOT NULL
                    , [year] INTEGER NOT NULL
                    , CONSTRAINT [PK_VEHICLE] PRIMARY KEY ([vid])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();

                    table = @"CREATE TABLE [RESERVATION] (
                    [acctID] INTEGER NOT NULL
                    , [vid] INTEGER NOT NULL
                    , [startDate] TEXT NOT NULL
                    , [endDate] TEXT NOT NULL
                    , CONSTRAINT [PK_RESERVATION] PRIMARY KEY ([acctID],[vid],[startDate],[endDate])
                    , FOREIGN KEY([acctID]) REFERENCES [ACCOUNT]([id])
                    , FOREIGN KEY([vid]) REFERENCES [VEHICLE]([vid])
                    );";
                    cmnd.CommandText = table;
                    cmnd.ExecuteNonQuery();

                    strSql = @"INSERT INTO ACCOUNT VALUES(123, 'seb', 'gon', 'customer')";
                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();


                    conn.Close();

                }
            }
        
        }
        public static Account GetUser(string usr, string pwd)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
            {
                conn.Open();
                string stm = @"SELECT[Id]
                        ,[username]
                        ,[password]
                        ,[type]
                        FROM[ACCOUNT]
                        WHERE[username] == ($name)
                        AND[password] == ($pd);";

                using (SQLiteCommand cmnd = new SQLiteCommand(stm,conn))
                {
                    cmnd.Parameters.AddWithValue("$name", usr);
                    cmnd.Parameters.AddWithValue("$pd", pwd);

                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Account acct = new Account(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(3));
                            return acct;                           
                        }

                        Account act = new Account(0, null, null);
                        return act;                       
                    }

                }
                
            }
        }
        /*
        public static Vehicle[] getVehicles()
        {
            Vehicle[] VehicleInfoList = new Vehicle[8];
            VehicleInfoList[0] = new Vehicle(345, "ford", "Mustang", "1984");
            return VehicleInfoList;
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