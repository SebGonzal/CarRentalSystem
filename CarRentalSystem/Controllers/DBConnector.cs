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
                    , [year] TEXT NOT NULL
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

                    strSql = @"INSERT INTO ACCOUNT VALUES(123, 'seb', 'gon', 'Customer')";
                    cmnd.CommandText = strSql;
                    cmnd.ExecuteNonQuery();

                    strSql = @"BEGIN TRANSACTION; 
                    INSERT INTO VEHICLE VALUES(001, 'Ford', 'Mustang', '1984');
                    INSERT INTO VEHICLE VALUES(002, 'Lamborghini', 'Aventador', '2021');
                    INSERT INTO VEHICLE VALUES(003, 'Tesla', 'Model X', '2020');
                    INSERT INTO VEHICLE VALUES(004, 'BMW', 'E30', '1991');
                    INSERT INTO VEHICLE VALUES(005, 'McLaren', '570S', '2020');
                    COMMIT;";
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
        
        public static List<Vehicle> getVehicles()
        {
            List<Vehicle> vehicleInfoList = new List<Vehicle>();
            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
            {

                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    conn.Open();
                    cmnd.Connection = conn;
                    cmnd.CommandText = "SELECT * FROM VEHICLE;";
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            vehicleInfoList.Add(new Vehicle(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)));
                        }
                    }
                }
            }
            return vehicleInfoList;
        }

        /*
        public static Vehicle getVehicle(int vin)
        {
        }
        */
        public static void SaveLogin(string usr)
        {   
            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
            {
                conn.Open();
                DateTime time = DateTime.Now;
                string t = time.ToString("s");
                int x = 0;
                
                string stm = "SELECT [id] FROM ACCOUNT WHERE username = ($name);";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    cmnd.Parameters.AddWithValue("$name", usr);
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            x = rdr.GetInt32(0);
                        }
                    }
                }
                stm = @"INSERT INTO LOGIN VALUES($id, $time);";
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    cmnd.Connection = conn;
                    cmnd.CommandText = stm;
                    cmnd.Parameters.AddWithValue("$id", x);
                    cmnd.Parameters.AddWithValue("$time", t);
                    cmnd.ExecuteNonQuery();
                }
            }
        }
        
        public static bool checkReservation(int vin, DateTime date)
        {
            return true;
        }
        public static void SaveLogout(string usr)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source = nCarDb.db"))
            {
                conn.Open();
                DateTime time = DateTime.Now;
                string t = time.ToString("s");
                int x = 0;
                
                string stm = "SELECT [id] FROM ACCOUNT WHERE username = ($name);";
                using (SQLiteCommand cmnd = new SQLiteCommand(stm, conn))
                {
                    cmnd.Parameters.AddWithValue("$name", usr);
                    using (SQLiteDataReader rdr = cmnd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            x = rdr.GetInt32(0);
                        }
                    }
                }
                stm = @"INSERT INTO LOGOUT VALUES($id, $time);";
                using (SQLiteCommand cmnd = new SQLiteCommand())
                {
                    cmnd.Connection = conn;
                    cmnd.CommandText = stm;
                    cmnd.Parameters.AddWithValue("$id", x);
                    cmnd.Parameters.AddWithValue("$time", t);
                    cmnd.ExecuteNonQuery();
                }
            }
        }
        public static void Save(Reservation reservation)
        {
        }
    }
}