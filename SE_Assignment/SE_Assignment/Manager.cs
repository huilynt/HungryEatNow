using System;
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
            
        public void DisplayFoodList(List<FoodItem> fList)
        {
            int count = 1;
            Console.WriteLine("= Available Food Items =\n" +
                              "========================");
            foreach (FoodItem food in fList)
            {
                Console.WriteLine("{0}) {1}", count, food.name);
                count++;
            }
            //Console.WriteLine("");
        }

        public void DisplayFoodItem(FoodItem selected, bool show)
        {
            

            if (show == true)
            {
                Console.WriteLine("= Food Item Details =\n" +
                              "=====================");
                Console.WriteLine("-Name: {0}\n" +
                                  "-Description: {1}\n" +
                                  "-Price: {2}\n" +
                                  "-Unit: {3}\n" +
                                  "-Status: {4}\n" +
                                  "-Type 'Done' to exit", selected.name, selected.description, selected.price, selected.unit, selected.status);
            }
            else
            {
                Console.WriteLine("= Food Item Details =\n" +
                              "=====================");
                Console.WriteLine("-Name: {0}\n" +
                                  "-Description: {1}\n" +
                                  "-Price: {2}\n" +
                                  "-Unit: {3}\n" +
                                  "-Status: {4}", selected.name, selected.description, selected.price, selected.unit, selected.status);
            }
            Console.WriteLine("");
        }
        
    }
}
