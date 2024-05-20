using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class Connection
    {
        private MySqlConnection connection;
        private string connecrionString = "Server=192.168.1.18; Port=3306; Database=demo_test_online; Uid=demo; Pwd=demo";

        public Connection()
        {
            connection = new MySqlConnection(connecrionString);
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

  
}
