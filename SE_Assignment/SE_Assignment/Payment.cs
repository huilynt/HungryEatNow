using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Payment
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public string type { get; set; }
        public double amount { get; set; }
        public Order order { get; set; }

        public Payment(int id, DateTime dateTime, string type, Order order)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.type = type;
            this.order = order;

            double amt = 0;
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
            if (order.deliveryType.ToLower() == "express")
            {
                amt += order.deliveryCharge;
            }

            this.amount = 0;
        }
    }
}
