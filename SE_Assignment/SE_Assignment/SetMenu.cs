using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class SetMenu
    {
        public int setMenuId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int unit { get; set; }
        public string status { get; set; }
        public int size { get; set; }
        public List<SetMenuItem> setMenuItemList { get; set; }

        public SetMenu(int setMenuId, string name, string description, double price, int unit, string status = "available")
        {
            this.setMenuId = setMenuId;
            this.name = name;
            this.description = description;
            this.price = price;
            this.unit = unit;
            this.status = status;
            this.setMenuItemList = new List<SetMenuItem>();

            this.size = setMenuItemList.Count;
        }

        public SetMenu()
        {
        }

        public void add(SetMenuItem setMenuItem)
        {
            setMenuItemList.Add(setMenuItem);
            this.size = setMenuItemList.Count;
        }

        public override string ToString()
        {
            string setMenuItems = "";
            foreach (SetMenuItem i in setMenuItemList)
            {
                setMenuItems += "\t" + i.name + "\n";
            }
            return $"Name: {name}\n" +
                $"Description: {description}\n" +
                $"Items:\n" +
                setMenuItems +
                "\n";
        }

        public void update() { }
        public void remove() { }
        public void display() { }
    }
}
