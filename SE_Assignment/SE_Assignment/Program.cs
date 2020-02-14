using System;
using System.Collections.Generic;
using System.Linq;

namespace SE_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountList = new List<Account>();
            List<Customer> customerList = new List<Customer>();
            List<Employee> employeeList = new List<Employee>();
            List<Order> orderList = new List<Order>();

            InitData();
            //foreach (Account c in accountList)
            //{
            //    Console.WriteLine(c.email);
            //}
            //Console.WriteLine(accountList.Count);

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

                    string email = "";
                    string password = "";

                    if (loginOption == 1 || loginOption == 2)
                    {
                        user = HandleLogin(loginOption, email, password);
                        if (user is Chef)
                        {
                            DisplayChefMenu((Chef)user);
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
            // Console.ReadKey();

            // Functions

            // Initialize all data here
            void InitData()
            {
                string password = "123";

                // Account
                Account account1 = new Account(1, "customer1@se.com", password);
                Account account2 = new Account(2, "employee1@se.com", password);
                Account account3 = new Account(3, "manager1@se.com", password);
                Account account4 = new Account(4, "assistant1@se.com", password);
                Account account5 = new Account(5, "chef1@se.com", password);
                Account account6 = new Account(6, "dispatcher1@se.com", password);
                accountList.Add(account1);
                accountList.Add(account2);
                accountList.Add(account3);
                accountList.Add(account4);
                accountList.Add(account5);
                accountList.Add(account6);

                // Customer
                Customer customer1 = new Customer(1, "Edgar", "Yew Tee", "87654321", account1);
                customerList.Add(customer1);

                // Manager
                Manager manager1 = new Manager(1, "Ikmaal", "T1234567A", "Male", "87654321", DateTime.Now, "Status", account3);
                employeeList.Add(manager1);

                // Chef
                Chef chef1 = new Chef(1, "Daniel", "T1234567A", "Male", "87654321", DateTime.Now, "Status", account5);
                employeeList.Add(chef1);

                // Order
                Order order1 = new Order(1, DateTime.Now);
                Order order2 = new Order(2, DateTime.Now);
                Order order3 = new Order(3, DateTime.Now);
                Order order4 = new Order(4, DateTime.Now);
                order4.state = order4.preparingOrderState;
                orderList.Add(order1);
                orderList.Add(order2);
                orderList.Add(order3);
                orderList.Add(order4);
                customer1.orderList.Add(order1);
                customer1.orderList.Add(order2);
                customer1.orderList.Add(order3);
                customer1.orderList.Add(order4);
            }

            // Log user in
            Object HandleLogin(int loginOption, string email, string password)
            {
                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                Console.WriteLine("");

                Object loginUser = new Object();

                if (loginOption == 1)
                {
                    foreach (Customer c in customerList)
                    {
                        if (c.account.email == email && c.account.password == password)
                        {
                            loginUser = c;
                            Console.WriteLine("Logged in successfully!");
                            Console.WriteLine($"Welcome, {c.name}!\n");
                        }
                    }
                }
                else if (loginOption == 2)
                {
                    foreach (Employee e in employeeList)
                    {
                        if (e.account.email == email && e.account.password == password)
                        {
                            loginUser = e;
                            Console.WriteLine("Logged in successfully!");
                            Console.WriteLine($"Welcome, {e.name}!\n");
                        }
                    }
                }
                else { Console.WriteLine("Please select a valid option!\n"); }
                return loginUser;
            }

            void DisplayChefMenu(Chef chef)
            {
                while (true)
                {
                    Console.WriteLine("Chef Menu");
                    Console.WriteLine("=========");
                    Console.WriteLine("1 Prepare Order");
                    Console.WriteLine("2 Ready Order");
                    Console.WriteLine("0 Exit");
                    Console.Write("Please select an option: ");

                    int option = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (option == 1)
                    {
                        Console.WriteLine("Showing all New orders");
                        List<Order> orderByStateList = GetOrdersByState(new NewOrderState());
                        DisplayOrders(orderByStateList, new NewOrderState());
                        Console.Write("Select an order: ");

                        int orderOption = -1;
                        try
                        {
                            orderOption = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("");

                            Order chosenOrder = GetOrderById(orderOption);

                            if (chosenOrder == null)
                            {
                                Console.WriteLine("Invalid Order.");
                            }
                            else
                            {
                                Console.WriteLine($"Change Order {orderOption} to Preparing?");
                                Console.WriteLine("1 Confirm");
                                Console.WriteLine("2 Cancel");
                                Console.Write("Select an option: ");

                                int confirmOption = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("");

                                if (confirmOption == 1)
                                {
                                    chef.prepareOrder(chosenOrder);
                                }
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
                        catch
                        {
                            Console.WriteLine("Please select a valid option!\n");
                        }
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Showing all Preparing orders");
                        List<Order> orderByStateList = GetOrdersByState(new NewOrderState());
                        DisplayOrders(orderByStateList, new NewOrderState());
                        Console.Write("Select an order: ");

                        int orderOption = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("");

                        Order chosenOrder = GetOrderById(orderOption);

                        if (chosenOrder == null)
                        {
                            Console.WriteLine("Invalid Order.");
                        }
                        else
                        {
                            Console.WriteLine($"Change Order {orderOption} to Ready?");
                            Console.WriteLine("1 Confirm");
                            Console.WriteLine("2 Cancel");
                            Console.Write("Select an option: ");

                            int confirmOption = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("");

                            if (confirmOption == 1)
                            {
                                chef.readyOrder(chosenOrder);
                            }
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
                    else if (option == 0) { break; }
                    else { Console.WriteLine("Please select a valid option!"); }
                }
            }

            List<Order> DisplayOrders(List<Order> displayOrderList, OrderState state)
            {
                if (displayOrderList.Count > 0)
                {
                    foreach (Order o in displayOrderList)
                    {
                        Console.WriteLine($"Order {o.id}");
                    }
                }
                else
                {
                    Console.WriteLine($"No {state.ToString()} orders");
                }
                return displayOrderList;
            }

            List<Order> GetOrdersByState(OrderState state)
            {
                List<Order> orderByStateList = new List<Order>();
                if (state != null)
                {
                    foreach (Order o in orderList)
                    {
                        if (o.state.GetType() == state.GetType())
                        {
                            orderByStateList.Add(o);
                        }
                    }
                }
                else
                {
                    foreach (Order o in orderList)
                    {
                        orderByStateList.Add(o);
                    }
                }
                return orderByStateList;
            }

            Order GetOrderById(int id)
            {
                foreach (Order o in orderList)
                {
                    if (o.id == id)
                    {
                        return o;
                    }
                }
                return null;
            }
        }
    }
}
