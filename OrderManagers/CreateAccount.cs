using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagers.Models;
using OrderManagers.DAL;
using OrderManagers.BL;

namespace OrderManagers
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();

        }

        private void emptyControlsUser()
        {
            txtUserID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtUserPassword.Text = string.Empty;

        }

        private User retrieveUserInformation()
        {
            User user = new User();
            user.ID = Convert.ToInt32(txtUserID.Text);
            user.UserName = txtUserName.Text;
            user.Password = txtUserPassword.Text;
            if (checkBoxAdmin.Checked)
                user.isAdmin = 1;
            else user.isAdmin = 0;

            return user;
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            User user = new User();

            user = retrieveUserInformation();

            UserOperations bl = new UserOperations();
            bl.AddUser(user);

            MessageBox.Show("Operation succesful");
        }
    }
}
