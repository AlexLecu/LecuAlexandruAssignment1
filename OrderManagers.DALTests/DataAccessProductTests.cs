using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagers.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using OrderManagers.BL;

namespace OrderManagers.DAL.Tests
{
    [TestClass()]
    public class DataAccessUserTests
    {

        [TestMethod()]
        public void AddProductTest()
        {
            Product product = new Product();
            product.ID = 9;
            product.title = "asdf";
            product.description = "asdf";
            product.color = "asdfafs";
            product.size = 12;
            product.price = 13;
            product.stock = 11;

            IList<Product> products = new List<Product>();

            DataAccessProduct dal = new DataAccessProduct();
            products = dal.RetrieveProducts();

            for(int i =0;i<products.Count;i++)
            {
                if(products.ElementAt(i).ID == product.ID)
                {
                    Assert.Fail();
                }
            }

            dal.AddProduct(product);

            Assert.AreNotEqual(products.Count, dal.RetrieveProducts().Count, 0, "Eroare");
           
        }

        [TestMethod]
        public void RetrieveProductsTest()
        {
            DataAccessProduct manager = new DataAccessProduct();
            Assert.IsTrue(manager.RetrieveProducts().Count > 0);

        }
    }
}