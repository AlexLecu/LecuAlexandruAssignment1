using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagers.Models;
using OrderManagers.DAL;

namespace OrderManagers.BL
{
    public class RegularUserOperations
    {
        public void AddProduct(Product product)
        {
            DataAccessProduct dal = new DataAccessProduct();
            dal.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            DataAccessProduct dal = new DataAccessProduct();
            dal.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            DataAccessProduct dal = new DataAccessProduct();
            dal.DeleteProduct(product);
        }

        public IList<Product> RetrieveProducts()
        {
            DataAccessProduct dal = new DataAccessProduct();
            return dal.RetrieveProducts();
        }

        public void AddOrder(Order order)
        {
            DataAccessOrder dal = new DataAccessOrder();
            dal.AddOrder(order);
        }

        public void UpdateOrder(Order order)
        {
            DataAccessOrder dal = new DataAccessOrder();
            dal.UpdateOrder(order);
        }

        public IList<Order> RetrieveOrders()
        {
            DataAccessOrder dal = new DataAccessOrder();
            return dal.RetrieveOrders();
        }

        public Order CreateNewOrder(Customer customer, Product product)
        {
            Order order = new Order();
            IList<Product> products = new List<Product>();

            DataAccessProduct dalProduct = new DataAccessProduct();
            DataAccessCustomer dalCustomer = new DataAccessCustomer();

            dalCustomer.AddCustomer(customer);

            products = dalProduct.RetrieveProducts();

            if(products.Contains(product))
            {
                order.orderProducts.Add(product);
            }

            for(int i=0;i<products.Count;i++)
            {
                if(products.ElementAt(i).ID == product.ID)
                {
                    products.ElementAt(i).stock = products.ElementAt(i).stock - product.stock;
                    dalProduct.UpdateProduct(products.ElementAt(i));
                }
            }

            order.customer = customer;
            order.orderProducts = products;

            return order;
        }




    }
}
