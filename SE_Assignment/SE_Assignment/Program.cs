using System;
using static SE_Assignment.MainFunctions;
using static SE_Assignment.HelperFunctions;
using static SE_Assignment.managerFunctions;

namespace SE_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            InitData();

            Object user = null;
            while (true)
            {
                Console.WriteLine("Login");
                Console.WriteLine("=====");
                Console.WriteLine("1 Customer");
                Console.WriteLine("2 Employee");
                Console.WriteLine("0 Exit");
                Console.Write("Please select an option: ");
                int loginOption = -1;
                try
                {
                    loginOption = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    string email = "";
                    string password = "";

                    if (loginOption == 1 || loginOption == 2)
                    {
                        user = HandleLogin(loginOption, email, password);
                        if (user is Chef)
                        {
                            DisplayChefMenu((Chef)user);
                        }
                        else if (user is Manager)
                        {
                            DisplayManagerMainMenu((Manager)user);
                        }
                    }
                    else if (loginOption == 0) { break; }
                    else
                    {
                        Console.WriteLine("Please enter a valid option!\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid option!\n");
                }
            }

            // Initialize all data here
            void InitData()
            {
                string password = "123";

                // Customer
                Account customerAccount1 = new Account(1, "customer1@se.com", password);
                allAccounts.Add(customerAccount1);
                Customer customer1 = new Customer(1, "customer1", "Yew Tee", "87654321", customerAccount1);
                allCustomers.Add(customer1);

                Account customerAccount2 = new Account(2, "customer1@se.com", password);
                allAccounts.Add(customerAccount2);
                Customer customer2 = new Customer(2, "customer2", "Yew Tee", "87654321", customerAccount2);
                allCustomers.Add(customer1);

                // Manager
                Account managerAccount1 = new Account(3, "manager1@se.com", password);
                allAccounts.Add(managerAccount1);
                Manager manager1 = new Manager(1, "manager1", "T1234567A", "Male", "87654321", DateTime.Now, "Status", managerAccount1, DateTime.Now);
                allEmployees.Add(manager1);

                // Store Assistant
                Account storeAssistantAccount1 = new Account(4, "storeAssistant1@se.com", password);
                allAccounts.Add(storeAssistantAccount1);
                StoreAssistant storeAssistant1 = new StoreAssistant(1, "storeAssistant1", "T1234567A", "Male", "87654321", DateTime.Now, "Status", storeAssistantAccount1);
                allStoreAssistants.Add(storeAssistant1);

                // Chef
                Account chefAccount1 = new Account(5, "chef1@se.com", password);
                allAccounts.Add(chefAccount1);
                Chef chef1 = new Chef(1, "chef1", "T1234567A", "Male", "87654321", DateTime.Now, "Status", chefAccount1);
                allEmployees.Add(chef1);

                // Dispatcher
                Account dispatcherAccount1 = new Account(6, "dispatcher1@se.com", password);
                allAccounts.Add(dispatcherAccount1);
                Dispatcher dispatcher1 = new Dispatcher(1, "dispatcher1", "T1234567A", "Male", "87654321", DateTime.Now, "Status", dispatcherAccount1);
                allDispatchers.Add(dispatcher1);

                Account dispatcherAccount2 = new Account(7, "dispatcher1@se.com", password);
                allAccounts.Add(dispatcherAccount2);
                Dispatcher dispatcher2 = new Dispatcher(2, "dispatcher2", "T1234567A", "Male", "87654321", DateTime.Now, "Status", dispatcherAccount2);
                allDispatchers.Add(dispatcher2);

                Account dispatcherAccount3 = new Account(8, "dispatcher1@se.com", password);
                allAccounts.Add(dispatcherAccount3);
                Dispatcher dispatcher3 = new Dispatcher(3, "dispatcher2", "T1234567A", "Male", "87654321", DateTime.Now, "Status", dispatcherAccount3);
                allDispatchers.Add(dispatcher3);

                // FoodItem
                FoodItem foodItem1 = new FoodItem(1, "Buttermilk Crispy Chicken", "Crispy whole-muscle chicken thigh flavoured with buttermilk packed in a glazed burger bun.", 1, "Available");
                allFoodItems.Add(foodItem1);

                FoodItem foodItem2 = new FoodItem(2, "Original Angus Cheeseburger", "Made from all the things you love – two slices of melty cheese, slivered onions and 100% Angus beef.", 1, "Available");
                allFoodItems.Add(foodItem2);

                FoodItem foodItem3 = new FoodItem(3, "Classic Angus Cheese", "Our delicious classic begins with a juicy 100% Angus beef patty between creamy Colby cheese slices.", 1, "Available");
                allFoodItems.Add(foodItem3);

                FoodItem foodItem4 = new FoodItem(4, "French Fries", "For winning flavour and texture, we only use premium Russet Burbank variety potatoes for that fluffy inside, crispy outside taste of our world-famous fries.", 1, "Available");
                allFoodItems.Add(foodItem4);

                FoodItem foodItem5 = new FoodItem(5, "Apple Slices", "Go fruity with fresh, ready-to-eat apple slices!", 1, "Available");
                allFoodItems.Add(foodItem5);

                FoodItem foodItem6 = new FoodItem(6, "Coca-Cola", "Icy cold cola.", 1, "Available");
                allFoodItems.Add(foodItem6);

                FoodItem foodItem7 = new FoodItem(7, "100% Pure Orange Juice", "Pure orange juice, with Vitamin C.", 1, "Available");
                allFoodItems.Add(foodItem7);

                // SetMenu
                SetMenu setMenu1 = new SetMenu(1, "Buttermilk Crispy Chicken Set", "Buttermilk Crispy Chicken with French Fries and Coca-Cola", 1, "Available");
                setMenu1.add(foodItem1);
                setMenu1.add(foodItem4);
                setMenu1.add(foodItem6);
                allSetMenus.Add(setMenu1);

                SetMenu setMenu2 = new SetMenu(2, "Original Angus Cheeseburger Set", "Original Angus Cheeseburger with Apple Slices and 100% Pure Orange Juice", 1, "Available");
                setMenu2.add(foodItem2);
                setMenu2.add(foodItem5);
                setMenu2.add(foodItem7);
                allSetMenus.Add(setMenu1);

                // Order
                Order order1 = new Order(1, DateTime.Now);
                order1.orderItemList.Add(new OrderItem(1, 1, setMenu1));
                order1.orderItemList.Add(new OrderItem(1, 2, foodItem1));
                allOrders.Add(order1);
                customer1.orderList.Add(order1);

                Order order2 = new Order(2, DateTime.Now);
                order2.orderItemList.Add(new OrderItem(1, 1, setMenu2));
                order2.orderItemList.Add(new OrderItem(1, 2, foodItem2));
                allOrders.Add(order2);
                customer1.orderList.Add(order2);

                Order order3 = new Order(3, DateTime.Now);
                order3.orderItemList.Add(new OrderItem(1, 1, setMenu1));
                order3.orderItemList.Add(new OrderItem(1, 2, foodItem3));
                allOrders.Add(order3);
                customer1.orderList.Add(order3);

                Order order4 = new Order(4, DateTime.Now);
                order4.orderItemList.Add(new OrderItem(1, 1, setMenu1));
                order4.orderItemList.Add(new OrderItem(1, 2, foodItem4));
                order4.state = order4.preparingOrderState;
                allOrders.Add(order4);
                customer1.orderList.Add(order4);
            }
        }
    }
}
