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
            if (DateTime.Now > order.deliveryDateTime)
            {
                order.state = order.cancelledOrderState;
                foreach (Observer o in order.observers)
                {
                    order.removeObserver(o);
                }
                order.refundCustomer();
                order.archiveOrder();
                Console.WriteLine($"Cancelled Order {order.id}\n");
            }
            else
            {
                Console.WriteLine("Cannot cancel order.\n");
            }
        }

        public void confirmOrder()
        {
            Console.WriteLine($"Cannot cancel Dispatched Order\n");
        }

        public void deliverOrder()
        {
            sendEmail();
            sendCommission();
            order.deliveryDateTime = DateTime.Now;
            order.state = order.readyOrderState;
            order.notifyObservers();
            Console.WriteLine($"Changed Order {order.id} to Delivered.\n");
        }

        private void sendCommission()
        {
            throw new NotImplementedException();
        }

        private void sendEmail()
        {
            throw new NotImplementedException();
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
