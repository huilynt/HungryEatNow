using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    interface OrderState
    {
        void confirmOrder();
        void readyOrder();
        void deliveringOrder();
        void deliverdOrder();
        void cancelledOrder();
        void archivedOrder();
    }
}
