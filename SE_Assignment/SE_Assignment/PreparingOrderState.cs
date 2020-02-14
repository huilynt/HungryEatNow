using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class PreparingOrderState : OrderState
    {
        private Order order;

        public PreparingOrderState()
        {
        }

        public PreparingOrderState(Order order)
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
            throw new NotImplementedException();
        }

        public void readyOrder()
        {
            Console.WriteLine($"Preparing Order {order.id}...");
            order.state = order.readyOrderState;
            order.notifyObservers();
            Console.WriteLine($"Changed Order {order.id} to Ready.");
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return "Ready";
        }
    }
}
