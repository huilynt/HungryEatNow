using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public Account account { get; set; }
        public List<Order> orderList { get; set; }

        public Customer(int id, string name, string address, string contactNumber, Account account)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.contactNumber = contactNumber;
            this.account = account;
            this.orderList = new List<Order>();
        }

        public void DisplayMenu(List<SetMenu> setMenu, List<FoodItem> foodItems, bool showHeader = true, int menuKind = 0)
        {
            int count = 1;
            if (showHeader == true)
            {
                Console.WriteLine("= Available Menu =\n" +
                                  "====================");
            }
            if (menuKind == 0)
            {
                //display set menu first
                Console.WriteLine("= Set Menu(s) =\n" +
                                  "===============");
                count = 1;
                foreach (SetMenu sm in setMenu)
                {

                    Console.WriteLine("{0}. {1} Price: ${2} ", count, sm.name, sm.price);
                    foreach (FoodItem fi in sm.foodItemList)
                    {
                        Console.WriteLine("\t-{0}", fi.name);
                    }
                    count++;

                }
            }
            else if (menuKind == 1)
            {
                Console.WriteLine("= Ala Carte Menu =\n" +
                  "==================");
                count = 1;
                foreach (FoodItem fi in foodItems)
                {
                    Console.WriteLine("{0}. {1} Price: ${2}", count, fi.name, fi.price);
                    count++;
                }
            }

            Console.WriteLine("");
        }

        public void DisplayOrderList(List<Order> orders, bool showHeader = true)
        {
            if(showHeader == true)
            {
                Console.WriteLine("= Current Orders =\n" +
                                  "==================");
            }
            foreach(Order o in orders)
            {
                foreach(OrderItem oi in o.orderItemList)
                {
                    Console.WriteLine("{0}, {1}, {2}", oi.id, oi.quantity, oi.item.name);
                }
            }


        }
    }
}
