using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class FoodItem : Item
    {

        public FoodItem(int id, string name, string description,double price, int unit, string status = "available") : base(id, name, description,price, unit, status)
        {

        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Description: {description}\n";
        }

    }
}