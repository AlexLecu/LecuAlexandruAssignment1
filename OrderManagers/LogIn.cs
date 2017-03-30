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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserOperations bl = new UserOperations();

            User user = bl.Login(txtUserName.Text, txtPassword.Text); 
           
           if(user.isAdmin == 1)
            {
                Admin formAdmin = new Admin();
                formAdmin.Show();
            }
           else
            {
                RegularUser formRegularUser = new RegularUser();
                formRegularUser.Show();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createAccountForm = new CreateAccount();
            createAccountForm.Show();  
        }
    }
}
