using Resto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resto.Data;
namespace Resto.Manager
{
    public class UserManager
    {
        UserData data = new UserData();
        public Boolean Insert(userModel user)
        {
            return data.Insert(user);
        }
        public List<userModel> GetUsers()
        {
            return data.GetUsers();
        }
        public userModel CheckLogin(string userid, string password)
        {
            return data.CheckLogin(userid, password);
        }
    }
}
