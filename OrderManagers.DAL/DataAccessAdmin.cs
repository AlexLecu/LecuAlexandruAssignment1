using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagers.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace OrderManagers.DAL
{
    public class DataAccessAdmin
    {
        private string connString;

        public DataAccessAdmin()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<User> RetrieveUsers()
        {
            IList<User> usersList = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.UserName = reader.GetString("UserName");
                        user.Password = reader.GetString("Password");
                        user.isAdmin = reader.GetInt32("isAdmin");

                        usersList.Add(user);
                    }
                }
            }

            return usersList;
        }

        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user(ID, UserName, Password, isAdmin) VALUES(@ID, @UserName, @Password, @isAdmin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.isAdmin);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM user WHERE ID=@ID";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.isAdmin);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE user SET UserName = @UserName, Password = @Password, isAdmin = @isAdmin WHERE ID = @ID;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.isAdmin);
              
                cmd.ExecuteNonQuery();
            }
        }
    }
}
