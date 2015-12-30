using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Domain;

namespace DBase
{
    public class Database
    {
        OdbcConnection connection;
        OdbcCommand command;

        private void connect()
        {
            connection = new OdbcConnection("Dsn=PostgreSQL35W;database=notify_danger;server=localhost;port=5432;uid=postgres;");
            command = connection.CreateCommand();
        }
        
        public Database()
        {
            connect();
        }

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

        public int countAccidents()
        {
            int returnValue;
           // string commandText = "select * from situationsdb order by id desc;";
            string commandText = "select * from situationsdb order by id desc limit 1;";
            OdbcCommand command = new OdbcCommand(commandText, connection);
            connection.Open();
            returnValue = Convert.ToInt16(command.ExecuteScalar()); // display the number of the newest id (for example '8')
            connection.Close();
            return returnValue;
        }

        public void insertDanger(Danger dan)
        {
            string commandText = "INSERT INTO situationsdb (acc_type,acc_location,acc_date,acc_descr) values(?,?,?,?);";
            OdbcCommand command = new OdbcCommand(commandText, connection);
            
            command.Parameters.AddWithValue("acctype",dan.AccType);
            command.Parameters.AddWithValue("acclocation",dan.AccLocation);
            command.Parameters.AddWithValue("accdate",dan.AccDate);
            command.Parameters.AddWithValue("accdescr",dan.AccDescr);
            //command.ExecuteNonQuery();
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
