using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    interface OrderState
    {
        void newOrder();
        void prepareOrder();
        void readyOrder();
        void dispatchOrder();
        void deliverOrder();
        void cancelOrder();
        void archiveOrder();
    }
}
