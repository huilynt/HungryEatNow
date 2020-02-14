using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    abstract class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nric { get; set; }
        public string gender { get; set; }
        public string contactNumber { get; set; }
        public DateTime dateJoined { get; set; }
        public string status { get; set; }
        public Account account { get; set; }

        public Employee(int id, string name, string nric, string gender, string contactNumber, DateTime dateJoined, string status, Account account)
        {
            this.id = id;
            this.name = name;
            this.nric = nric;
            this.gender = gender;
            this.contactNumber = contactNumber;
            this.dateJoined = dateJoined;
            this.status = status;
            this.account = account;
        }

        public void HandleOrder(Order order)
        {
            // If using strategy pattern
        }
    }
}
