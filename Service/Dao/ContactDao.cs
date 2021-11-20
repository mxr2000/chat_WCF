using Contracts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    class ContactDao : BaseDao
    {
        List<int> GetContactIDsByUserIDAndGroupName(int userID, string groupName)
        {
            List<int> list = new List<int>();
            var connection = GetConnection();
            string sql = "SELECT * FROM contacts WHERE user1_id = " + userID + " AND group_name = '" + groupName + "'";
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetInt32("user2_id"));
            }
            Close(connection, reader);
            return list;
        }
    }
}
