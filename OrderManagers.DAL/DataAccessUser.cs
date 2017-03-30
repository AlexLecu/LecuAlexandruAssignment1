using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OrderManagers.Models;
using System.Configuration;

namespace OrderManagers.DAL
{
    public class DataAccessUser
    {
        private string connString;

        public DataAccessUser()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public User GetUser(string userName)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user where UserName=\"" + userName + "\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.UserName = reader.GetString("UserName");
                        user.Password = reader.GetString("Password");
                        user.isAdmin = reader.GetInt32("isAdmin");

                        return user;
                    }
                }
            }

            return null;
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
    }
}
