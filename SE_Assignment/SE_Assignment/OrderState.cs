using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    interface OrderState
    {
        void confirmOrder();
        void prepareOrder();
        void readyOrder();
        void dispatchOrder();
        void deliverOrder();
        void cancelOrder();
    }
   
}
