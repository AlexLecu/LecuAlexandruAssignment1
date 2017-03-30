using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagers.Models;
using OrderManagers.DAL;

namespace OrderManagers.BL
{
    public class UserOperations
    {
        public User Login(string userName, string password)
        {
            DataAccessUser dal = new DataAccessUser();
            User user = dal.GetUser(userName);
            if (user != null)
            {
                Security secure = new Security();
                if (secure.VerifyHash(password, user.Password))
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccessUser dal = new DataAccessUser();
            dal.AddUser(user);
        }
    }
}
