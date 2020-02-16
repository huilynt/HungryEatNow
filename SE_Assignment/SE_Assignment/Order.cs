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

        public OrderState newOrderState { get; set; }
        public OrderState preparingOrderState { get; set; }
        public OrderState readyOrderState { get; set; }
        public OrderState dispatchedOrderState { get; set; }
        public OrderState deliveredOrderState { get; set; }
        public OrderState cancelledOrderState { get; set; }
        public OrderState archivedOrderState { get; set; }
        public OrderState state { get; set; }

        public List<Observer> observers = new List<Observer>();

        public Order(int id, DateTime createDateTime)
        {
            this.id = id;
            status = "New";
            this.createDateTime = createDateTime;
            deliveryCharge = 0;
            deliveryType = "Default";
            gst = 7.00;
            orderItemList = new List<OrderItem>();

            newOrderState = new NewOrderState(this);
            preparingOrderState = new PreparingOrderState(this);
            readyOrderState = new ReadyOrderState(this);
            dispatchedOrderState = new DispatchedOrderState(this);
            deliveredOrderState = new DeliveredOrderState(this);
            cancelledOrderState = new CancelledOrderState(this);
            archivedOrderState = new ArchivedOrderState(this);

            state = newOrderState;

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

        public void displayOrders(List<Order> orderList)
        {

        }
    }
}
