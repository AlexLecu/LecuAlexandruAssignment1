using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OrderManagers.Models;
using MySql.Data.MySqlClient;

namespace OrderManagers.DAL
{
    public class DataAccessProduct
    {
        private string connString;

        public DataAccessProduct()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Product> RetrieveProducts()
        {
            IList<Product> productList = new List<Product>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ID = reader.GetInt32("ID");
                        product.title = reader.GetString("title");
                        product.description = reader.GetString("description");
                        product.color = reader.GetString("color");
                        product.size = reader.GetInt32("size");
                        product.price = reader.GetInt32("price");
                        product.stock = reader.GetInt32("stock");
                        productList.Add(product);
                    }
                }
            }

            return productList;
        }


        public void AddProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product(ID, title, description, color, size, price, stock) VALUES(@ID, @title, @description, @color, @size, @price, @stock)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", product.ID);
                cmd.Parameters.AddWithValue("@title", product.title);
                cmd.Parameters.AddWithValue("@description",product.description);
                cmd.Parameters.AddWithValue("@color",product.color);
                cmd.Parameters.AddWithValue("@size",product.size);
                cmd.Parameters.AddWithValue("@price",product.price);
                cmd.Parameters.AddWithValue("@stock",product.stock);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product SET title = @title, description = @description, color = @color, size = @size, price = @price, stock = @stock  WHERE ID = @ID;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", product.ID);
                cmd.Parameters.AddWithValue("@title", product.title);
                cmd.Parameters.AddWithValue("@description", product.description);
                cmd.Parameters.AddWithValue("@color", product.color);
                cmd.Parameters.AddWithValue("@size", product.size);
                cmd.Parameters.AddWithValue("@price", product.price);
                cmd.Parameters.AddWithValue("@stock", product.stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product WHERE ID=@ID";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", product.ID);
                cmd.Parameters.AddWithValue("@title", product.title);
                cmd.Parameters.AddWithValue("@description", product.description);
                cmd.Parameters.AddWithValue("@color", product.color);
                cmd.Parameters.AddWithValue("@size", product.size);
                cmd.Parameters.AddWithValue("@price", product.price);
                cmd.Parameters.AddWithValue("@stock", product.stock);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
