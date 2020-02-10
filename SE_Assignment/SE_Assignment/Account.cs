using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Account
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Account(int id, string email, string password)
        {
            this.id = id;
            this.email = email;
            this.password = password;
        }
    }
}
