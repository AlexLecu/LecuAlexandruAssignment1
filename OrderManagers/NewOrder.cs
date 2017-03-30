using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagers.BL;
using OrderManagers.Models;
using OrderManagers.DAL;

namespace OrderManagers
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void emptyControls()
        {
            //for product
            txtProductID.Text = string.Empty;
            txtProductTitle.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtProductColor.Text = string.Empty;
            txtProductSize.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductStock.Text = string.Empty;
            //for customer
            txtCustomerID.Text = string.Empty;
            txtCustomerFirstName.Text = string.Empty;
            txtCustomerLastName.Text = string.Empty;
            //for order
            txtOrderID.Text = string.Empty;
            txtShippingAddress.Text = string.Empty;
            txtOrderStatus.Text = string.Empty;
            dtDeliveryDate.Value = DateTime.Now;

        }

        private Product retrieveProductInformation()
        {
            Product product = new Product();
            product.ID = Convert.ToInt32(txtProductID.Text);
            product.title = txtProductTitle.Text;
            product.description = txtProductDescription.Text;
            product.color = txtProductColor.Text;
            product.size = Convert.ToInt32(txtProductSize.Text);
            product.price = Convert.ToInt32(txtProductPrice.Text);
            product.stock = Convert.ToInt32(txtProductStock.Text);

            return product;

        }

        private Customer retrieveCustomerInformation()
        {
            Customer customer = new Customer();
            customer.ID = Convert.ToInt32(txtCustomerID.Text);
            customer.FirstName = txtCustomerFirstName.Text;
            customer.LastName = txtCustomerLastName.Text;

            return customer;
        }

        private User retrieveUserInformation()
        {
            User user = new User();
            user.ID = Convert.ToInt32(txtUserID.Text);
            user.UserName = txtUserName.Text;
            user.Password = txtUserPassword.Text;
            user.isAdmin = 0;
            return user;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Product product = new Product();
            Order order = new Order();

            RegularUserOperations bl = new RegularUserOperations();
            DataAccessOrder dal = new DataAccessOrder();

            customer = retrieveCustomerInformation();
            product = retrieveProductInformation();

            order = bl.CreateNewOrder(customer, product);

            order.ID = Convert.ToInt32(txtOrderID.Text);
            order.shippingAddress = txtShippingAddress.Text;
            order.deliveryDate = dtDeliveryDate.Value;
            order.status = txtOrderStatus.Text;

            //order.user = retrieveUserInformation();

            dal.AddOrder(order);

            emptyControls();
        }
    }
}
