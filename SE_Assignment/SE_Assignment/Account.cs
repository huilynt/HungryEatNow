using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Account
    {
        public int accountNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }


        public Account(int accountNumber, string email, string password)
        {
            this.accountNumber = accountNumber;
            this.email = email;
            this.password = password;
        }
    }
}
