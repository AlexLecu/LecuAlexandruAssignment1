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
using OrderManagers.BL;

namespace OrderManagers
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void emptyControlsUser()
        {
            txtUserID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private User retrieveUserInformation()
        {
            User user = new User();
            user.ID = Convert.ToInt32(txtUserID.Text);
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            if (cbIsAdmin.Checked)
                user.isAdmin = 1;
            else user.isAdmin = 0;

            return user;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AdminOperations bl = new AdminOperations();
            User user = new User();
            user = retrieveUserInformation();
            bl.AddUser(user);

            emptyControlsUser();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewUsers formViewUsers = new ViewUsers();
            formViewUsers.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AdminOperations bl = new AdminOperations();
            User user = new User();
            user = retrieveUserInformation();
            bl.UpdateUser(user);
            emptyControlsUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdminOperations bl = new AdminOperations();
            User user = new User();
            user = retrieveUserInformation();
            bl.DeleteUser(user);
            emptyControlsUser();
        }
    }
}
