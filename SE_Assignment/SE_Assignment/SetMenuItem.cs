using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class SetMenuItem
    {
        public int setMenuItemId { get; set; }
        public string name { get; set; }

        private SetMenu setMenu;
        private Item item;

        public SetMenuItem(int setMenuItemId, string name, SetMenu setMenu, Item item)
        {
            this.setMenuItemId = setMenuItemId;
            this.name = name;
            this.setMenu = setMenu;
            this.item = item;
        }
    }
}
