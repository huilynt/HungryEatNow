using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class PreparingOrderState : OrderState
    {
        private Order order;

        public PreparingOrderState() { }

        public PreparingOrderState(Order order)
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
            Console.WriteLine($"Cannot confirm Preparing Order\n");
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Cannot deliver Preparing Order\n");
        }

        public void dispatchOrder()
        {
            Console.WriteLine($"Cannot dispatch Preparing Order\n");
        }

        public void prepareOrder()
        {
            Console.WriteLine($"Order is already preparing\n");
        }

        public void readyOrder()
        {
            order.readyDateTime = DateTime.Now;
            order.state = order.readyOrderState;
            order.notifyObservers();
            Console.WriteLine($"Changed Order {order.id} to Ready\n");
        }

        public override string ToString()
        {
            return "Preparing";
        }
    }
}
