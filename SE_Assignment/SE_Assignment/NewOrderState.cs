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
            Console.WriteLine($"Order already confirmed\n");
        }

        public void deliverOrder()
        {
            Console.WriteLine($"Cannot Deliver New Order\n");
        }

        public void dispatchOrder()
        {
            Console.WriteLine($"Cannot Dispatch New Order\n");
        }

        public void prepareOrder()
        {
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
