using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class NewOrderState : OrderState
    {
        private Order order;

        public NewOrderState()
        {
        }

        public NewOrderState(Order order)
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
            throw new NotImplementedException();
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
            Console.WriteLine($"Preparing Order {order.id}");
            order.state = order.preparingOrderState;
        }

        public void readyOrder()
        {
            throw new NotImplementedException();
        }
    }
}
