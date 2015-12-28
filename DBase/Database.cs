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
            string acc_type = dan.AccType;
            string acc_location = dan.AccLocation;
            DateTime acc_date = dan.AccDate;
            string acc_descr = dan.AccDescr;

            string commandText = "INSERT INTO situationsdb (acc_type, acc_location, acc_date, acc_descr) VALUES('"+@acc_type+"','"+@acc_location+"','"+@acc_date+"','"+@acc_descr+"');";

                OdbcCommand command = new OdbcCommand(commandText, connection);
            

            /*
                command.Parameters.Add("@acc_type", OdbcType.Text);
                command.Parameters["@acc_type"].Value = dan.AccType;
                command.Parameters.Add("@acc_location", OdbcType.Text);
                command.Parameters["@acc_location"].Value = dan.AccLocation;
                command.Parameters.Add("@acc_date", OdbcType.DateTime);
                command.Parameters["@acc_date"].Value = dan.AccDate;
                command.Parameters.Add("@acc_descr", OdbcType.Text);
                command.Parameters["@acc_descr"].Value = dan.AccDescr;
                */
            // Use AddWithValue to assign Demographics.
            // SQL Server will implicitly convert strings into XML.
            //  command.Parameters.AddWithValue("@demographics", demoXml);

                try
                {
                    connection.Open();
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
