using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class Identity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Identity(string username, string password)
        {
            Username = username;
            Password = password;

        }
    }
}
