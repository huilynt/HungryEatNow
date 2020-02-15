using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Chef : Employee
    {

        public Chef(int id, string name, string nric, string gender, string contactNumber, DateTime dateJoined, string status, Account account) : base(id, name, nric, gender, contactNumber, dateJoined, status, account)
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

        public void prepareOrder(Order order)
        {
            order.state.prepareOrder();
        }

        public void readyOrder(Order order)
        {
            order.state.readyOrder();
        }
    }
}
