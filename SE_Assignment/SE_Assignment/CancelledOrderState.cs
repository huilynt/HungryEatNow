using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class CancelledOrderState : OrderState
    {
        private Order order;

        public CancelledOrderState()
        {
        }

        public CancelledOrderState(Order order)
        {
            this.order = order;
        }

        public void cancelOrder()
        {
            Console.WriteLine($"Order already cancelled\n");
        }

        public void confirmOrder()
        {
            Console.WriteLine($"Cannot confirm Cancelled Order\n");
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Cannot deliver Cancelled Order\n");
        }

        public void dispatchOrder()
        {
            Console.WriteLine($"Cannot dispatch Cancelled Order\n");
        }

        public void prepareOrder()
        {
            Console.WriteLine($"Cannot prepare Cancelled Order\n");
        }

        public void readyOrder()
        {
            Console.WriteLine($"Cannot ready Cancelled Order\n");
        }
    }
}
