using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    abstract class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int unit { get; set; }
        public string status { get; set; }

        public void update() { }
        public void remove() { }
        public void display() { }
    }
}
