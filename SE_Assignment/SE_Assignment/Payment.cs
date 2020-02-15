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

        public Payment(int id, DateTime dateTime, string type, double amount, Order order)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.type = type;
            this.amount = amount;
            this.order = order;
        }
    }
}
