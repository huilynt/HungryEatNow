using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class SetMenu : Item
    {
        public int size { get; set; }
        public List<FoodItem> foodItemList { get; set; }

        public SetMenu(int id, string name, string description, int unit, string status) : base(id, name, description, unit, status)
        {
            this.foodItemList = new List<FoodItem>();
            this.size = foodItemList.Count;
        }

        public void add(FoodItem foodItem)
        {
            foodItemList.Add(foodItem);
            this.size = foodItemList.Count;
        }

        public override string ToString()
        {
            string foodItems = "";
            foreach (FoodItem i in foodItemList)
            {
                foodItems += "\t" + i.name + "\n";
            }
            return $"Name: {name}\n" +
                $"Description: {description}\n" +
                $"Items:\n" +
                foodItems +
                "\n";
        }
    }
}
