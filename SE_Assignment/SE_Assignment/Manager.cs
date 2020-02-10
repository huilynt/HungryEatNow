using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Manager: Employee
    {
        private DateTime startTime;

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public void createMenu() { }

        public void createMenuItem() { }

        public void createFoodItem() { }

    }
}
