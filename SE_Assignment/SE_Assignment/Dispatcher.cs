using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Dispatcher: Employee
    {

        private double currentMonthCommission;
        public double CurrentMonthCommision
        {
            get { return currentMonthCommission; }
            set { currentMonthCommission = value; }
        }
    }
}
