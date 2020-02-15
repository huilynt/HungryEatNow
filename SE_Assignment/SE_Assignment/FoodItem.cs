using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class FoodItem
    {
        private int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int unit { get; set; }
        public string status { get; set; }

        public FoodItem() { }
        public FoodItem(int id, string name, string description, int unit, string status = "available")
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.unit = unit;
            this.status = status;
        }
    }
}
