using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class DeliveredOrderState : OrderState
    {
        private Order order;

        public DeliveredOrderState(Order order)
        {
            this.order = order;
        }

        public void cancelOrder()
        {
            Console.WriteLine($"Cannot cancel Delivered Order\n");
        }

        public void confirmOrder()
        {
            Console.WriteLine($"Cannot confirm Delivered Order\n");
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Order is already delivered\n");
        }

        public void dispatchOrder()
        {
            Console.WriteLine($"Cannot dispatch Delivered Order\n");
        }

        public void prepareOrder()
        {
            Console.WriteLine($"Cannot prepare Delivered Order\n");
        }

        public void readyOrder()
        {
            Console.WriteLine($"Cannot ready Delivered Order\n");
        }
    }
}
