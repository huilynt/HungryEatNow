using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Dispatcher : Employee
    {
        public double currentMonthCommision { get; set; }

        public Dispatcher(int id, string name, string nric, string gender, string contactNumber, DateTime dateJoined, string status, Account account, double currentMonthCommision) : base(id, name, nric, gender, contactNumber, dateJoined, status, account)
        {
            this.id = id;
            this.name = name;
            this.nric = nric;
            this.gender = gender;
            this.contactNumber = contactNumber;
            this.dateJoined = dateJoined;
            this.status = status;
            this.account = account;
            this.currentMonthCommision = currentMonthCommision;
        }

        public void dispatchOrder(Order order)
        {
            order.readyOrderState.dispatchOrder();
        }

        public void deliverOrder(Order order)
        {
            order.dispatchedOrderState.deliverOrder();
        }
    }
}
