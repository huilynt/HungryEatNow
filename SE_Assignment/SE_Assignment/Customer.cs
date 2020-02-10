using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Customer
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        private Account account;

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public Customer(int id, string name, string address, string contactNumber, Account account)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.contactNumber = contactNumber;
            this.account = account;
        }
    }
}
