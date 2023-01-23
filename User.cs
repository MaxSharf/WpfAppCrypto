﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCrypto
{
    internal class User
    {
        public int Id { get; set; }
        private string login, email, password;

        public string Login {
            get { return login; }
            set { login = value; }
        }

        public string Password {
            get { return password; }
            set { password = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }

        public User() { }

        public User(string login, string email, string password)
        {
            this.login = login;
            this.email = email;
            this.password = password;
        }
    }
}
