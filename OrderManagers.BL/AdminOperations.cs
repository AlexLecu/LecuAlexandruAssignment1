using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagers.Models;
using OrderManagers.DAL;

namespace OrderManagers.BL
{
    public class AdminOperations
    {
        public void AddUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccessAdmin dal = new DataAccessAdmin();
            dal.AddUser(user);
        }
        public void UpdateUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccessAdmin dal = new DataAccessAdmin();
            dal.UpdateUser(user);
        }
        public void DeleteUser(User user)
        {
            DataAccessAdmin dal = new DataAccessAdmin();
            dal.DeleteUser(user);
        }
        public IList<User> RetrieveUsers()
        {
            DataAccessAdmin dal = new DataAccessAdmin();
            return dal.RetrieveUsers();
        }
    }
}
