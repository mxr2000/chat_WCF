using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    class BaseDao
    {
        string connstr = "data source=39.104.25.156;database=chat;user id=root;password=mxr2017;pooling=false;charset=utf8";


        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connstr);
            connection.Open();
            return connection;
        }

        public void Close(MySqlConnection connection, MySqlDataReader reader)
        {
            if (reader != null)
            {
                reader.Close();
            }
            connection.Close();
        }
    }
}
