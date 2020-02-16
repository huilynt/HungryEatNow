using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Category
    {
        public int categoryId { get; set; }
        public string name { get; set; }

        public List<Item> itemList;
    }
}
