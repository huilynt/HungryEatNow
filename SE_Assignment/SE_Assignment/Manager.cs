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


        public Manager(int id, string name, string NRIC, string gender, string contactNo, DateTime dateJoined, string status, Account account)
        {
            this.Name = name;
            this.Id = id;
            this.NRIC = NRIC;
            this.Gender = gender;
            this.ContactNumber = contactNo;
            this.DateJoined = dateJoined;
            this.Status = status;
            this.Account = account;
        }

        public void createMenu() { }

        public void createMenuItem() { }

        public void createFoodItem() { }

    }
}
