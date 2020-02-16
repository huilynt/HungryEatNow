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
            throw new NotImplementedException();
        }
    }
}
