using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class OrderItem
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public Item item;
        public SetMenu setMenu;

        public OrderItem(int id, int quantity, Item item)
        {
            this.id = id;
            this.quantity = quantity;
            this.item = item;
        }

        public OrderItem(int id, int quantity, SetMenu setMenu)
        {
            this.id = id;
            this.quantity = quantity;
            this.setMenu = setMenu;
        }
    }
}
