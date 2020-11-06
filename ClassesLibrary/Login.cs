﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login() { }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return string.Format("Username: {0}\nPassword: {1}\n", 
                Username,
                Password);
        }
    }
}
