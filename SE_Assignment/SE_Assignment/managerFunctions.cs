using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class managerFunctions
    {
        public static void DisplayManagerMainMenu(Manager manager)
        {
            bool isLoggin = true;
            while (isLoggin)
            {
                Console.WriteLine("==Manager Main Menu==");
                Console.WriteLine("1) Manager Food Items\n" +
                                  "2) Manage Menus\n" +
                                  "0) Log Out");
                Console.Write("Please select an option: ");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ManagerMenuFood(manager);
                        break;
                    case 2:
                        ManagerMenuSet(manager);
                        break;
                    case 0:
                        isLoggin = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option!");
                        break;
                }
            }
        }
        public static void ManagerMenuFood(Manager manager)
        {
            bool isEditFood = true;
            while (isEditFood)
            {
                Console.WriteLine("===Food Item Menu===");
                Console.WriteLine("1) Add new Food Item\n" +
                                  "2) Update Food Item\n" +
                                  "3) Delete Food Item\n" +
                                  "0) Return to Main Menu");
                Console.Write("Please select an option: ");
                int option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        //display food item list

                        //get input

                        //add to food item list
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        DisplayManagerMainMenu(manager);
                        isEditFood = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }
            }


        }

        public static void ManagerMenuSet(Manager manager)
        {
            bool isEditSet = true;

            while (isEditSet)
            {
                Console.WriteLine("===Set Menu Menu===");
                Console.WriteLine("1) Add new Set Menu\n" +
                                  "2) Update Set Menu\n" +
                                  "3) Delete Set Menu\n" +
                                  "0) Return to Main Menu");
                Console.Write("Please select an option: ");
                int option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        DisplayManagerMainMenu(manager);
                        isEditSet = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }

            }
        }


    }
}
