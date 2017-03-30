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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AdminOperations bl = new AdminOperations();
            gridUsers.DataSource = bl.RetrieveUsers();
        }
    }
}
