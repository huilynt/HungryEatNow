using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public Account account { get; set; }
        public List<Order> orderList { get; set; }

        public Customer(int id, string name, string address, string contactNumber, Account account)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.contactNumber = contactNumber;
            this.account = account;
            this.orderList = new List<Order>();
        }
    }
}
