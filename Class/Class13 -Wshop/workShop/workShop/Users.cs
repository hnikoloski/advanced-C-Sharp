using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workShop
{
    public class Users
    {
        public static string Email { get; set; }
        public static string Role { get; set; }
        public static string Password { get; set; }
        

        public Users(string email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;

        }

       
    }
}
