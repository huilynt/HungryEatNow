﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Manager : Employee
    {
        public DateTime startDate { get; set; }


        public Manager(int id, string name, string nric, string gender, string contactNumber, DateTime dateJoined, string status, Account account, DateTime startDate) : base(id, name, nric, gender, contactNumber, dateJoined, status, account)
        {
            this.id = id;
            this.name = name;
            this.nric = nric;
            this.gender = gender;
            this.contactNumber = contactNumber;
            this.dateJoined = dateJoined;
            this.status = status;
            this.account = account;
            this.startDate = startDate;
        }

        public List<FoodItem> addItem(List<FoodItem> itemList, FoodItem selection)
        {
            List<FoodItem> modifiedList = new List<FoodItem>();



            return modifiedList;

        }

    }
}
