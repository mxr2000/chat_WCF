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
    class MessageDao : BaseDao
    {
        public string GetMessageByID(int id)
        {
            string message = "";
            var connection = GetConnection();
            string sql = "SELECT * FROM messages WHERE id = " + id;
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
                message = reader.GetString("content");
            Close(connection, reader);
            return message;
        }

        public ObservableCollection<Message> GetAllMessageByUserIDs(int user1ID, int user2ID)
        {
            ObservableCollection<Message> list = new ObservableCollection<Message>();
            var connection = GetConnection();
            string sql = "SELECT * FROM messages WHERE user1_id = " + user1ID + " AND user2_id = " + user2ID;
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Message message = new Message() {
                    Content = reader.GetString("content"),
                    Time = reader.GetDateTime("time")
                };
                list.Add(message);
            }

            Close(connection, reader);
            return list;
        }

        public ObservableCollection<Message> GetAllMessageByUserIDsWithRange(int user1ID, int user2ID, int range)
        {
            ObservableCollection<Message> list = new ObservableCollection<Message>();
            var connection = GetConnection();
            string sql = "SELECT * FROM messages WHERE user1_id = " + user1ID + " AND user2_id = " + user2ID;
            var command = new MySqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Message message = new Message()
                {
                    Content = reader.GetString("content"),
                    Time = reader.GetDateTime("time")
                };
                list.Add(message);
            }

            Close(connection, reader);
            return list;
        }
    }
}
