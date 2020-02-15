using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class FoodItem : Item
    {
        public FoodItem(int id, string name, string description, int unit, string status) : base(id, name, description, unit, status)
        {

        }

        public void update()
        {

        }
        public void remove()
        {

        }
        public void display()
        {

        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Description: {description}\n";
        }
    }
}
