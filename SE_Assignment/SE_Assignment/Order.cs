using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Order
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime createDateTime;

        public DateTime CreateDateTime
        {
            get { return createDateTime; }
            set { createDateTime = value; }
        }

        private DateTime readyDateTime;

        public DateTime ReadyDateTime
        {
            get { return readyDateTime; }
            set { readyDateTime = value; }
        }

        private DateTime deliveryDateTime;

        public DateTime DeliveryDateTime
        {
            get { return deliveryDateTime; }
            set { deliveryDateTime = value; }
        }

        private double deliveryCharge;

        public double DeliveryCharge
        {
            get { return deliveryCharge; }
            set { deliveryCharge = value; }
        }

        private double totalAmount;

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        private string deliveryType;

        public string DeliveryType
        {
            get { return deliveryType; }
            set { deliveryType = value; }
        }

    }
}
