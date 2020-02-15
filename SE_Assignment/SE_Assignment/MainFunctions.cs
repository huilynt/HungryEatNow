using System;
using System.Collections.Generic;
using System.Text;
using static SE_Assignment.HelperFunctions;

namespace SE_Assignment
{
    class MainFunctions
    {
        public static List<Account> allAccounts = new List<Account>();
        public static List<Customer> allCustomers = new List<Customer>();
        public static List<Employee> allEmployees = new List<Employee>();
        public static List<Order> allOrders = new List<Order>();
        public static List<StoreAssistant> allStoreAssistants = new List<StoreAssistant>();
        public static List<Dispatcher> allDispatchers = new List<Dispatcher>();
        public static List<FoodItem> allFoodItems = new List<FoodItem>();
        public static List<SetMenu> allSetMenus = new List<SetMenu>();

        // Function 1 - Huilin
        // Allow a customer to create a new order (i.e., choose food items or menu, select restaurant, select express delivery, etc.) and pay by credit card or other online means


        // Function 2
        // Allow the manager to manage food items and menus, including adding/updating/deleting of food items and menus

        // Function 3 - Huilin
        // Allow a chef to select the order he wishes to prepare and update the order for dispatch once the order is ready
        public static void DisplayChefMenu(Chef chef)
        {
            while (true)
            {
                Console.WriteLine("Chef Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1 Prepare Order");
                Console.WriteLine("2 Ready Order");
                Console.WriteLine("0 Logout");
                Console.Write("Please select an option: ");

                try
                {
                    int option = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    // 1. Chef chooses Prepare Order
                    if (option == 1)
                    {
                        // 2. System displays New Order(s)
                        Console.WriteLine("Showing all New orders");
                        List<Order> orderByStateList = GetOrdersByState(new NewOrderState());
                        // 5. System displays Order information
                        DisplayOrders(orderByStateList, new NewOrderState());
                        Console.Write("Select an order: ");

                        int orderOption = -1;
                        try
                        {
                            // 3. Chef selects an Order
                            orderOption = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            // 4. System retrieves selected Order
                            Order chosenOrder = GetOrderById(orderOption);

                            if (chosenOrder == null)
                            {
                                Console.WriteLine("Invalid Order.");
                            }
                            else
                            {
                                // 5. System prompts to Confirm or Cancel changing Order Status to Preparing
                                Console.WriteLine($"Change Order {orderOption} to Preparing?");
                                Console.WriteLine("1 Confirm");
                                Console.WriteLine("2 Cancel");
                                Console.Write("Select an option: ");

                                int confirmOption = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("");

                                // 6. Chef selects Confirm
                                if (confirmOption == 1)
                                {
                                    // 7. System updates Order Status to Preparing
                                    // 8. System displays ‘Order Status changed to Preparing’
                                    // 9. Use case ends
                                    chef.prepareOrder(chosenOrder);
                                }
                                // 6.1 Chef selects Cancel
                                // 6.2 Use case ends
                                else if (confirmOption == 2)
                                {
                                    Console.WriteLine($"Cancelled changing Order {orderOption} to Preparing");
                                }
                                else
                                {
                                    Console.WriteLine("Please select a valid option!\n");
                                }
                            }
                        }
                        // 3.1 System prompts to enter a valid Order
                        // 3.2 System returns to Step 2
                        catch
                        {
                            Console.WriteLine("Please select a valid Order!\n");
                        }
                    }
                    // 1. Chef chooses Dispatch Order
                    else if (option == 2)
                    {
                        // 2. System displays Order(s) with ‘Preparing’ Status
                        Console.WriteLine("Showing all Preparing orders");
                        List<Order> orderByStateList = GetOrdersByState(new NewOrderState());
                        DisplayOrders(orderByStateList, new NewOrderState());
                        Console.Write("Select an order: ");

                        try
                        {
                            // 3. Chef selects an Order
                            int orderOption = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            // 4. System retrieves selected Order
                            Order chosenOrder = GetOrderById(orderOption);

                            if (chosenOrder == null)
                            {
                                Console.WriteLine("Invalid Order.");
                            }
                            else
                            {
                                // 5. System prompts to Confirm or Cancel changing Order Status to ‘Ready’
                                Console.WriteLine($"Change Order {orderOption} to Ready?");
                                Console.WriteLine("1 Confirm");
                                Console.WriteLine("2 Cancel");
                                Console.Write("Select an option: ");

                                int confirmOption = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                // 6. Chef selects Confirm
                                if (confirmOption == 1)
                                {
                                    // 7. System updates Order Status to ‘Ready’
                                    // 8. System displays ‘Order Status changed to Ready’
                                    // 9. Use case ends
                                    chef.readyOrder(chosenOrder);
                                }
                                // 7.1 Chef chooses to cancel Status change
                                // 7.2 Use case ends
                                else if (confirmOption == 2)
                                {
                                    Console.WriteLine($"Cancelled changing Order {orderOption} to Ready");
                                }
                                else
                                {
                                    Console.WriteLine("Please select a valid option!");
                                }
                            }
                        }
                        // 3.1 System prompts to enter a valid Order
                        // 3.2 System returns to Step 2
                        catch { Console.WriteLine("Please select a valid order!"); }
                    }
                    // Logout
                    else if (option == 0) { break; }
                    // Invalid option
                    else { Console.WriteLine("Please select a valid option!"); }
                }
                catch { Console.WriteLine("Please select a valid option!"); }
            }
        }


        // Function 5
        // Allow the manager to view orders using various filters such as new, cancelled, delivered, delivering, archived, ready, preparing.

    }
}
