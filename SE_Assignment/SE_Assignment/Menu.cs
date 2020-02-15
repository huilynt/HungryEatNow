using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Menu
    {

        public int menuID { get; set; }
        public int getSize { get; set; }

        public List<SetMeals> setMenuList = new List<SetMeals>();

        public List<FoodItem> foodItemList = new List<FoodItem>();
        
        public Menu(List<SetMeals> setList, List<FoodItem> foodList)
        {
            this.setMenuList = setList;
            this.foodItemList = foodList;
        }

    }
}
