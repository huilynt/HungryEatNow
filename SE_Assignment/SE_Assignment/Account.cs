using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Account
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }


        public Account(int id, string email, string password)
        {
            this.id = id;
            this.email = email;
            this.password = password;
        }
    }
}
