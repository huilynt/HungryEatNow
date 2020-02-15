using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int unit { get; set; }
        public string status { get; set; }

        public Item(int id, string name, string description, int unit, string status)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.unit = unit;
            this.status = status;
        }

        public void update() { }
        public void remove() { }
        public void display() { }
    }
}
