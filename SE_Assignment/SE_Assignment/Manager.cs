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

        public void DisplaySetMenuList(List<SetMenuItem> itemList, bool showHeader = true)
        {
            int count = 1;
            if (showHeader == true)
            {
                Console.WriteLine("= Available Food Items =\n" +
                                  "========================");
                foreach (SetMenuItem food in itemList)
                {
                    Console.WriteLine("{0}) {1}", count, food.name);
                    count++;
                }
            }
            else
            {
                foreach (SetMenuItem food in itemList)
                {
                    Console.WriteLine("{0}) {1}", count, food.name);
                    count++;
                }
            }

            Console.WriteLine("");
        }


        public void DisplayFoodList(List<Item> fList, bool showHeader = true)
        {

            List<Item> itemList = (List<Item>)fList;
            int count = 1;
            if (showHeader == true)
            {
                Console.WriteLine("= Available Food Items =\n" +
                                  "========================");
                foreach (Item food in itemList)
                {
                    Console.WriteLine("{0}) {1}", count, food.name);
                    count++;
                }
            }
            else
            {
                foreach (Item food in itemList)
                {
                    Console.WriteLine("{0}) {1}", count, food.name);
                    count++;
                }
            }

            Console.WriteLine("");
        }

        public void DisplayFoodItem(Item selected, bool showHeader = true)
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
                foreach (SetMenu sm in sList)
                {
                    Console.WriteLine("{0}. Set Menu Name: {1}", count, sm.name);
                    foreach (SetMenuItem fi in sm.setMenuItemList)
                    {
                        Console.WriteLine("\t-{0}", fi.name);
                    }
                    count++;
                }
            }
            else
            {
                foreach (SetMenu sm in sList)
                {
                    Console.WriteLine("{0}. Set Menu Name: {1}", count, sm.name);
                    foreach (SetMenuItem fi in sm.setMenuItemList)
                    {
                        Console.WriteLine("\t-{0}", fi.name);
                    }
                    count++;
                }
            }

            Console.WriteLine("");
        }

        public void DisplaySetMenuItem(SetMenu setmenu, bool showHeader = true)
        {
            if (showHeader == true)
            {
                Console.WriteLine("= Set Menu Details =\n" +
                              "====================");
                Console.WriteLine("Name: {0}", setmenu.name);
                foreach (SetMenuItem item in setmenu.setMenuItemList)
                {
                    Console.WriteLine("\t-{0}", item.name);
                }
            }
            else
            {
                Console.WriteLine("Name: {0}", setmenu.name);
                foreach (SetMenuItem item in setmenu.setMenuItemList)
                {
                    Console.WriteLine("\t-{0}", item.name);
                }
            }

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
