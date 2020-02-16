using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Order : Subject
    {
        public int id { get; set; }
        public string status { get; set; }
        public DateTime createDateTime { get; set; }
        public DateTime readyDateTime { get; set; }
        public DateTime deliveryDateTime { get; set; }
        public double deliveryCharge { get; set; }
        public double subTotal { get; set; }
        public double gst { get; set; }
        public double totalAmount { get; set; }
        public string deliveryType { get; set; }
        public List<OrderItem> orderItemList { get; set; }
        public bool archive { get; set; }


        public OrderState newOrderState { get; set; }
        public OrderState preparingOrderState { get; set; }
        public OrderState readyOrderState { get; set; }
        public OrderState dispatchedOrderState { get; set; }
        public OrderState deliveredOrderState { get; set; }
        public OrderState cancelledOrderState { get; set; }
        public OrderState state { get; set; }

        public List<Observer> observers = new List<Observer>();
        public Payment payment;

        public Order(int id, DateTime createDateTime)
        {
            this.id = id;
            this.createDateTime = createDateTime;
            deliveryCharge = 0;
            this.deliveryType = deliveryType;
            gst = 7.00;
            orderItemList = new List<OrderItem>();
            archive = false;

            newOrderState = new NewOrderState(this);
            preparingOrderState = new PreparingOrderState(this);
            readyOrderState = new ReadyOrderState(this);
            dispatchedOrderState = new DispatchedOrderState(this);
            deliveredOrderState = new DeliveredOrderState(this);
            cancelledOrderState = new CancelledOrderState(this);

            state = newOrderState;

            if (deliveryType == "Express")
            {
                this.deliveryCharge = 5;
                this.deliveryDateTime = createDateTime.AddMinutes(10);
            }
            else
            {
                this.deliveryDateTime = createDateTime.AddMinutes(30);
            }

            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);

        }
        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.update(this);
            }
        }

        public void archiveOrder()
        {
            this.archive = true;
        }

        public void refundCustomer()
        {
            // implementation
        }

        public void calculateAmount()
        {
            double subamt = 0;
            foreach (OrderItem oi in orderItemList)
            {
                if (oi.item != null)
                {
                    subamt += oi.item.price * oi.quantity;
                }
                else if (oi.setMenu != null)
                {
                    subamt += oi.setMenu.price * oi.quantity;
                }
            }

            subamt += deliveryCharge;
            this.subTotal = subamt;
            double gstAmt = subamt * 7 / 100;

            double totamt = subamt + gstAmt;
            this.totalAmount = totamt;
        }

    }
}
