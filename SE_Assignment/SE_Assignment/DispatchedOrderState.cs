using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class DispatchedOrderState : OrderState
    {
        private Order order;

        public DispatchedOrderState()
        {
        }

        public DispatchedOrderState(Order order)
        {
            this.order = order;
        }

        public void cancelOrder()
        {
            Console.WriteLine($"Cannot cancel Dispatched Order\n");
        }

        public void confirmOrder()
        {
            Console.WriteLine($"Cannot cancel Dispatched Order\n");
        }

        public void deliverOrder()
        {
            order.deliveryDateTime = DateTime.Now;
            order.state = order.readyOrderState;
            order.notifyObservers();
            Console.WriteLine($"Changed Order {order.id} to Delivered.\n");
        }

        public void dispatchOrder()
        {
            Console.WriteLine($"Order already Dispatched\n");
        }

        public void prepareOrder()
        {
            Console.WriteLine($"Cannot prepare Dispatched Order\n");
        }

        public void readyOrder()
        {
            Console.WriteLine($"Cannot ready Dispatched Order\n");
        }
    }
}
