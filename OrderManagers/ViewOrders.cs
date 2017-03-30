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

namespace OrderManagers
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RegularUserOperations bl = new RegularUserOperations();
            gridOrders.DataSource = bl.RetrieveOrders();
        }
    }
}
