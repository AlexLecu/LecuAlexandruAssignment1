using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagers.Models
{
    public class Order
    {
        public Customer customer  { get; set; }
        public string shippingAddress { get; set; }
        public int ID { get; set; }
        public DateTime deliveryDate { get; set; }
        public string status { get; set; }
        public IList<Product> orderProducts { get; set; }
       // public User user { get; set; }
    }
}
