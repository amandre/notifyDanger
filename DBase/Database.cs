using System;
using System.Data.Odbc;
using Dangers;

namespace DBase
{
    /// <summary>
    /// Class Database describes the connection and is responsible for establishing it between PostgreSQL (in this case local) database and notifyMe App.
    /// Moreover it sends the accident to the db and check if the application db is up to date.
    /// </summary>
    public class Database
    {
        /// creating OdbcConnection object
        OdbcConnection connection;
        OdbcCommand command;

        private void connect()
        {
            connection = new OdbcConnection("Dsn=PostgreSQL35W;database=notify_danger;server=localhost;port=5432;uid=postgres;");
            command = connection.CreateCommand();
        }
        
        public Database()
        {
            /// During creation of the object, automatically try to connect to the db.
            connect();
        }

        /// <summary>
        /// Method giveAccidentDetails() is looking for the newest entry and gets entry's detailed information.
        /// These information cover type, location, date and optionally description of the accident.
        /// </summary>
        /// <returns>The string with detailed description of the last accident in the db</returns>    
        public string giveAccidentDetails()
        {
            string commandText = "select * from situationsdb order by id desc limit 1;";
            OdbcCommand command = new OdbcCommand(commandText, connection);
            connection.Open();
            OdbcDataReader reader = command.ExecuteReader();
            string answer = "";
            while(reader.Read())
            {
                string id = reader[0].ToString();
                string type = reader[1].ToString();
                string location = reader[2].ToString();
                string date = reader[3].ToString();
                string descr = reader[4].ToString();

                answer += string.Format("Type: {0}\nLocation: {1}\nDate: {2}\nDescription: {3}", type, location, date, descr);
            }
            connection.Close();
            return answer;
        }

       /// <summary>Method countAccidents() is looking for the entries and counts them.</summary>
       /// <returns>the amount of accidents in database</returns>
        public int countAccidents()
        {
            int returnValue;
            string commandText = "select * from situationsdb order by id desc limit 1;";
            OdbcCommand command = new OdbcCommand(commandText, connection);
            connection.Open();
            /// display the number of the newest id (for example '8')
            returnValue = Convert.ToInt16(command.ExecuteScalar());
            connection.Close();
            return returnValue;
        }
         
       /// <summary>
       /// Method insertDanger(Danger dan) inserts into db information about accident written by user.
       /// These inserting is doing in safe way.
       /// </summary>
       /// <param name="dan">It's the danger which has occured and needs to be put into the db.</param>
        public void insertDanger(Danger dan)
        {
            string commandText = "INSERT INTO situationsdb (acc_type,acc_location,acc_date,acc_descr) values(?,?,?,?);";
            OdbcCommand command = new OdbcCommand(commandText, connection);
            
            command.Parameters.AddWithValue("acctype",dan.AccType);
            command.Parameters.AddWithValue("acclocation",dan.AccLocation);
            command.Parameters.AddWithValue("accdate",dan.AccDate);
            command.Parameters.AddWithValue("accdescr",dan.AccDescr);
            try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }

                catch (Exception)
                {
                     throw;
                }

                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
        }
    }
}
