using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using OrderManagers.Models;

namespace OrderManagers.DAL
{
    public class DataAccessOrder
    {
        private string connString;

        public DataAccessOrder()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Order> RetrieveOrders()
        {
            IList<Order> orderList = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM orderfurniture";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.ID = reader.GetInt32("ID");
                        order.shippingAddress = reader.GetString("ShippingAddress");
                        order.status = reader.GetString("Status");
                        order.deliveryDate = reader.GetDateTime("DeliveryDate");
                       
                        orderList.Add(order);
                    }
                }
            }

            return orderList;
        }

        public void AddOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO orderfurniture(ID, ShippingAddress, Status, DeliveryDate) VALUES(@ID, @ShippingAddress, @Status, @DeliveryDate)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", order.ID);
                cmd.Parameters.AddWithValue("@ShippingAddress", order.shippingAddress);
                cmd.Parameters.AddWithValue("@Status", order.status);
                cmd.Parameters.AddWithValue("@DeliveryDate", order.deliveryDate);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE orderfurniture SET ShippingAddress = @ShippingAddress, Status = @Status, DeliveryDate = @DeliveryDate WHERE ID = @ID;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", order.ID);
                cmd.Parameters.AddWithValue("@ShippingAddress", order.shippingAddress);
                cmd.Parameters.AddWithValue("@Status", order.status);
                cmd.Parameters.AddWithValue("@DeliveryDate", order.deliveryDate);
                cmd.ExecuteNonQuery();
            }
        }

        /*
        public void AddOrder2(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO orderfurniture(ID, ShippingAddress, Status, DeliveryDate, user_ID, customer_ID) VALUES(@ID, @ShippingAddress, @Status, @DeliveryDate, @user_ID, @customer_ID)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", order.ID);
                cmd.Parameters.AddWithValue("@ShippingAddress", order.shippingAddress);
                cmd.Parameters.AddWithValue("@Status", order.status);
                cmd.Parameters.AddWithValue("@DeliveryDate", order.deliveryDate);
                cmd.Parameters.AddWithValue("@user_ID", order.user.ID);
                cmd.Parameters.AddWithValue("@customer_ID", order.customer.ID);

                cmd.ExecuteNonQuery();
            }
        }
        */
    }
}
