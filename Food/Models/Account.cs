using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Models
{
    class Account
    {
        public string UserName { get; set; }
        public int Password { get; set; }

        public Account(string username, int password)
        {
            UserName = username;
            Password = password;
        }
    }
}
