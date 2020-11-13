using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get;  }
        public int ID { get; }
        private static int nextID = 0;

        public User()
        {
            this.ID = nextID++;
        }

        public User(string username, string email, string pasword) : this()
        {
            Username = username;
            Email = email;
            Password = pasword;
        }


    }
}
