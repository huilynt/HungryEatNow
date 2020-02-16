using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Item
    {
        public int itemId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int unit { get; set; }
        public string status { get; set; }

        public Item(int itemId, string name, string description, double price, int unit, string status)
        {
            this.itemId = itemId;
            this.name = name;
            this.description = description;
            this.price = price;
            this.unit = unit;
            this.status = status;
        }

        public Item()
        {
        }

        public void update() { }
        public void remove() { }
        public void display() { }
    }
}
