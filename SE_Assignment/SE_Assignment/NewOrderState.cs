using System;
using System.Collections.Generic;
using System.Text;
using static SE_Assignment.MainFunctions;

namespace SE_Assignment
{
    class NewOrderState : OrderState
    {
        private Order order;

        public NewOrderState() { }

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
            Console.WriteLine($"Cancelling Order {order.id}...");
            order.state = order.cancelledOrderState;
            foreach (Observer o in order.observers)
            {
                order.removeObserver(o);
            }
            Console.WriteLine($"Cancelled Order {order.id}\n");
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Cannot Dispatch New Order\n");
        }

        public void dispatchOrder()
        {
            Console.WriteLine($"Cannot Dispatch New Order\n");
        }

        public void newOrder()
        {
            Console.WriteLine($"Order {order.id} is already New\n");
        }

        public void prepareOrder()
        {
            Console.WriteLine($"Preparing Order {order.id}...");
            order.state = order.preparingOrderState;
            foreach (Dispatcher d in allDispatchers)
            {
                order.registerObserver(d);
            }
            Console.WriteLine($"Changed Order {order.id} to Preparing\n");
        }

        public void readyOrder()
        {
            Console.WriteLine($"Cannot change New Order {order.id} to Ready\n");
        }

        public override string ToString()
        {
            return "New";
        }
    }
}
