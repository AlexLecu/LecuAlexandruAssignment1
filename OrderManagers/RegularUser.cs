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

namespace OrderManagers
{
    public partial class RegularUser : Form
    {
        public RegularUser()
        {
            InitializeComponent();
        }

        private void emptyControlsProduct()
        {
            txtProductID.Text = string.Empty;
            txtProductTitle.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtProductColor.Text = string.Empty;
            txtProductSize.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductStock.Text = string.Empty;
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

        private void emptyControlsOrder()
        {
            txtOrderID.Text = string.Empty;
            txtShippingAddress.Text = string.Empty;
            dtDeliveryDate.Value = DateTime.Now;
            txtOrderStatus.Text = string.Empty;
        }

        private Order retrieveOrderInformation()
        {
            Order order = new Order();
            order.ID = Convert.ToInt32(txtOrderID.Text);
            order.shippingAddress = txtShippingAddress.Text;
            order.deliveryDate = dtDeliveryDate.Value;
            order.status = txtOrderStatus.Text;

            return order;

        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = retrieveProductInformation();

            RegularUserOperations bl = new RegularUserOperations();
            bl.AddProduct(product);

            emptyControlsProduct();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = retrieveProductInformation();

            RegularUserOperations bl = new RegularUserOperations();
            bl.UpdateProduct(product);

            emptyControlsProduct();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = retrieveProductInformation();

            RegularUserOperations bl = new RegularUserOperations();
            bl.DeleteProduct(product);

            emptyControlsProduct();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            ViewProducts formViewProducts = new ViewProducts();
            formViewProducts.Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order = retrieveOrderInformation();

            RegularUserOperations bl = new RegularUserOperations();
            bl.AddOrder(order);

            emptyControlsOrder();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order = retrieveOrderInformation();

            RegularUserOperations bl = new RegularUserOperations();
            bl.UpdateOrder(order);

            emptyControlsOrder();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrders formViewOrders = new ViewOrders();
            formViewOrders.Show();
        }

        private void btnCreateNeworder_Click(object sender, EventArgs e)
        {
            NewOrder formNewOrder = new NewOrder();
            formNewOrder.Show();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            
    }
    }
}
