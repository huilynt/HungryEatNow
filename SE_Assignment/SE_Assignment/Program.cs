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

                string loginType = Console.ReadLine();
                string email = "";
                string password = "";

                if (loginType == "1" || loginType == "2")
                {
                    user = HandleLogin(loginType, email, password);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option!");
                }
            }

            DisplayMenu(user);

            Console.ReadKey();

            void InitData()
            {
                string password = "12345678";

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

                Customer customer1 = new Customer(1, "Edgar", "Yew Tee", "87654321", account1);
                customerList.Add(customer1);

                Manager manager1 = new Manager(1, "Ikmaal", "T1234567A", "Male", "87654321", DateTime.Now, "Status", account3);
                employeeList.Add(manager1);

                Chef chef1 = new Chef(1, "Daniel", "T1234567A", "Male", "87654321", DateTime.Now, "Status", account5);
                employeeList.Add(chef1);

                Order order1 = new Order(1, DateTime.Now);
                Order order2 = new Order(2, DateTime.Now);
                Order order3 = new Order(3, DateTime.Now);
                orderList.Add(order1);
                orderList.Add(order2);
                orderList.Add(order3);
                customer1.orderList.Add(order1);
                customer1.orderList.Add(order2);
                customer1.orderList.Add(order3);
            }

            Object HandleLogin(string loginType, string email, string password)
            {
                Console.WriteLine("Email:");
                email = Console.ReadLine();

                Console.WriteLine("Password:");
                password = Console.ReadLine();

                Object loginUser = new Object();

                if (loginType == "1")
                {
                    foreach (Customer c in customerList)
                    {
                        if (c.account.email == email && c.account.password == password)
                        {
                            loginUser = c;
                            Console.WriteLine("Logged in successfully!");
                            Console.WriteLine($"Welcome, {c.name}!");
                        }
                    }
                }
                else if (loginType == "2")
                {
                    foreach (Employee e in employeeList)
                    {
                        if (e.account.email == email && e.account.password == password)
                        {
                            loginUser = e;
                            Console.WriteLine("Logged in successfully!");
                            Console.WriteLine($"Welcome, {e.name}!");
                        }
                    }
                }
                return loginUser;
            }

            void DisplayMenu(Object userObj)
            {
                if (userObj is Chef)
                {
                    Chef chef = (Chef)userObj;
                    Console.WriteLine("Chef Menu");
                    Console.WriteLine("=========");
                    Console.WriteLine("1 Prepare Order");
                    Console.WriteLine("2 Ready Order");

                    string option = Console.ReadLine();

                    if (option == "1")
                    {
                        Console.WriteLine("Showing all New orders");
                        DisplayOrders(new NewOrderState());
                        Console.WriteLine("Select an order");
                        string orderOption = Console.ReadLine();
                        Order chosenOrder = GetOrderById(Int32.Parse(orderOption));
                        if (chosenOrder == null)
                        {
                            Console.WriteLine("Invalid Order Id.");
                        }
                        else
                        {
                            chef.prepareOrder(chosenOrder);
                        }
                    }
                    else if (option == "2")
                    {
                        DisplayOrders(new PreparingOrderState());
                    }
                    else { Console.WriteLine("Please select a valid option!"); }
                }
            }

            void DisplayOrders(OrderState state)
            {
                if (state != null)
                {
                    foreach (Order o in orderList)
                    {
                        if (o.state.GetType() == state.GetType())
                        {
                            Console.WriteLine($"Order #{o.id}");
                            //foreach(OrderItem i in o.orderItemList)
                            //{
                            //    Console.WriteLine($"{i.quantity}");
                            //}
                        }
                    }
                }
                else
                {
                    foreach (Order o in orderList)
                    {
                        Console.WriteLine($"Order #{o.id}");
                        //foreach(OrderItem i in o.orderItemList)
                        //{
                        //    Console.WriteLine($"{i.quantity}");
                        //}
                    }
                }
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
