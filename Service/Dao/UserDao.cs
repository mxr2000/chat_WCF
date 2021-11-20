using Contracts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    class UserDao : BaseDao
    {
        public User GetUserByID(int id)
        {
            User user = null;
            var connection = GetConnection();
            string sql = "SELECT * FROM users WHERE id = " + id;
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                user = new User()
                {
                    ID = id,
                    Name = reader.GetString("username"),
                    Password = reader.GetString("password")
                };
            }
            Close(connection, reader);
            return user;
        }
        public User GetUserByUsernameAndPassword(string username, string password)
        {
            User user = null;
            var connection = GetConnection();
            string sql = "SELECT * FROM users WHERE username = '" + username + "' and password = '" + password + "'";
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                user = new User()
                {
                    ID = reader.GetInt32("id"),
                    Name = reader.GetString("username"),
                    Password = reader.GetString("password")
                };
            }
            Close(connection, reader);
            return user;
        }
    }
}
