using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class DeliveredOrderState : OrderState
    {
        private Order order;

        public DeliveredOrderState()
        {
        }

        public DeliveredOrderState(Order order)
        {
            this.order = order;
        }

        public void archiveOrder()
        {
            throw new NotImplementedException();
        }

        public void cancelOrder()
        {
            throw new NotImplementedException();
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Order {order.id} is delieverd");
        }

        public void dispatchOrder()
        {
            throw new NotImplementedException();
        }

        public void newOrder()
        {
            throw new NotImplementedException();
        }

        public void prepareOrder()
        {
            throw new NotImplementedException();
        }

        public void readyOrder()
        {
            throw new NotImplementedException();
        }
    }
}
