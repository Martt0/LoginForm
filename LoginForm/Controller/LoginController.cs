using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controller
{
    internal class LoginController
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>()
            {
                new User("sos", "2802"),
                new User("cska", "1948")
            };
            return users;
        }
    }
}
