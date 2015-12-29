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
