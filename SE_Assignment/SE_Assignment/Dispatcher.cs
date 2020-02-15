using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Dispatcher : Employee, Observer
    {
        public double currentMonthCommision { get; set; }
        private Order order;

        public Dispatcher(int id, string name, string nric, string gender, string contactNumber, DateTime dateJoined, string status, Account account) : base(id, name, nric, gender, contactNumber, dateJoined, status, account)
        {
            this.id = id;
            this.name = name;
            this.nric = nric;
            this.gender = gender;
            this.contactNumber = contactNumber;
            this.dateJoined = dateJoined;
            this.status = status;
            this.account = account;
            this.currentMonthCommision = 0.00;

            this.order = null;
        }

        public void dispatchOrder(Order order)
        {
            order.readyOrderState.dispatchOrder();
        }

        public void deliverOrder(Order order)
        {
            order.dispatchedOrderState.deliverOrder();
        }

        public void update(Subject sub)
        {
            this.order = (Order)sub;
        }
    }
}
