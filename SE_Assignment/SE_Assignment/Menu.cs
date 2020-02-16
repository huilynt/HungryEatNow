using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Menu
    {

        public int menuID { get; set; }
        public int getSize { get; set; }

        public List<SetMenu> setMenuList = new List<SetMenu>();

        public List<FoodItem> foodItemList = new List<FoodItem>();
        
        public Menu(List<SetMenu> setList, List<FoodItem> foodList)
        {
            this.setMenuList = setList;
            this.foodItemList = foodList;
        }

    }
}
