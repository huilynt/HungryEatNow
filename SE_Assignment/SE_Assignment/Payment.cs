using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Payment
    {
        public int receiptNumber { get; set; }
        public DateTime paymentDateTime { get; set; }
        public string paymentType { get; set; }
        public double paymentAmount { get; set; }
        public Order order { get; set; }

        public Payment(int receiptNumber, DateTime dateTime, string type, Order order)
        {
            this.receiptNumber = receiptNumber;
            this.paymentDateTime = dateTime;
            this.paymentType = type;
            this.order = order;


            double amt = 0;
            if (order != null)
            {


                foreach (OrderItem oi in order.orderItemList)
                {
                    if (oi.item != null)
                    {
                        amt += oi.item.price * oi.quantity;
                    }
                    else if (oi.setMenu != null)
                    {
                        amt += oi.setMenu.price * oi.quantity;
                    }
                }

                amt += order.deliveryCharge;

                double gstAmt = amt * 7 / 100;

                amt += gstAmt;

            }

            this.paymentAmount = amt;
        }

        public void printReceipt()
        {
            // implementation
        }
    }
}
