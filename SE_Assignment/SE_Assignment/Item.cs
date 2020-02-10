using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Item
    {
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
