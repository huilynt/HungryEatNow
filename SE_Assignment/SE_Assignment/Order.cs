using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Order
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

        public Order(int id, DateTime createDateTime)
        {
            this.id = id;
            this.status = "New";
            this.createDateTime = createDateTime;
            this.deliveryCharge = 0;
            this.deliveryType = "Default";
            this.gst = 7.00;
            this.orderItemList = new List<OrderItem>();

            this.newOrderState = new NewOrderState(this);
            this.preparingOrderState = new PreparingOrderState(this);
            this.readyOrderState = new ReadyOrderState(this);
            this.dispatchedOrderState = new DispatchedOrderState(this);
            this.deliveredOrderState = new DeliveredOrderState(this);
            this.cancelledOrderState = new CancelledOrderState(this);
            this.archivedOrderState = new ArchivedOrderState(this);

            this.state = newOrderState;
        }


    }
}
