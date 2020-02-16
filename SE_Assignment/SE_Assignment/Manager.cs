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

            
        public void DisplayFoodList(List<FoodItem> fList, bool showHeader = true)
        {
            int count = 1;
            if (showHeader == true)
            {
                Console.WriteLine("= Available Food Items =\n" +
                                  "========================");
            }
            
            
            foreach (FoodItem food in fList)
            {
                Console.WriteLine("{0}) {1}", count, food.name);
                count++;
            }
            

            Console.WriteLine("");
        }

        public void DisplayFoodItem(FoodItem selected, bool showHeader = true)
        {
            

            if (showHeader == true)
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
        
        public void DisplaySetMenuList(List<SetMenu> sList, bool showHeader = true)
        {
            int count = 1;
            if (showHeader == true)
            {
                Console.WriteLine("= Available Set Menu =\n" +
                  "======================");

            }
            foreach (SetMenu sm in sList)
            {
                Console.WriteLine("{0}. Set Menu Name: {1}", count, sm.name);
                foreach (FoodItem fi in sm.foodItemList)
                {
                    Console.WriteLine("\t-{0}", fi.name);
                }
                count++;
            }

            Console.WriteLine("");
        }

        public void DisplaySetMenuItem(SetMenu setmenu, bool showHeader = true)
        {
            if(showHeader == true)
            {
                Console.WriteLine("= Set Menu Details =\n" +
                              "====================");

            }
            Console.WriteLine("Name: {0}", setmenu.name);
            foreach (FoodItem item in setmenu.foodItemList)
            {
                Console.WriteLine("\t-{0}", item.name);
            }
            Console.WriteLine("");

        }

        public void DisplayOrderList(List<Order> orderList)
        {
            if (orderList.Count > 0)
            {
                Console.WriteLine("Status: Order:");
                foreach (Order i in orderList)
                {

                    Console.WriteLine("{0}:    Order No.{1} ", i.status, i.id);
                }
            }
            else
            {
                Console.WriteLine("No orders in this category");
                Console.WriteLine("");
            }

        }

    }
}
