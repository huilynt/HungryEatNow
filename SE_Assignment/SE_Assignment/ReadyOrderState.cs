using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class ReadyOrderState : OrderState
    {
        private Order order;

        public ReadyOrderState(Order order)
        {
            this.order = order;
        }

        public void cancelOrder()
        {
            Console.WriteLine($"Cannot cancel Ready Order\n");
        }

        public void confirmOrder()
        {
            Console.WriteLine($"Cannot confirm Ready Order\n");
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Cannot deliver Ready Order\n");
        }

        public void dispatchOrder()
        {
            Dispatcher dispatcher = (Dispatcher)order.observers[0];
            dispatcher.update(order);
            foreach (Observer o in order.observers)
            {
                order.removeObserver(o);
            }
            order.state = order.dispatchedOrderState;
            Console.WriteLine($"Changed Order {order.id} to Dispatched.\n");
        }

        public void prepareOrder()
        {
            Console.WriteLine($"Cannot prepare Ready Order\n");
        }

        public void readyOrder()
        {
            Console.WriteLine($"Order is already Ready\n");
            order.status = "ready";
        }
    }
}
