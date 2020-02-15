using System;
using System.Collections.Generic;
using System.Text;
using static SE_Assignment.MainFunctions;

namespace SE_Assignment
{
    class HelperFunctions
    {
        // Helper functions
        // Log user in
        public static Object HandleLogin(int loginOption, string email, string password)
        {
            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();

            Console.WriteLine("");

            Object loginUser = new Object();

            if (loginOption == 1)
            {
                foreach (Customer c in allCustomers)
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
                foreach (Employee e in allEmployees)
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

        public static List<Order> DisplayOrders(List<Order> displayallOrders, OrderState state)
        {
            if (displayallOrders.Count > 0)
            {
                foreach (Order o in displayallOrders)
                {
                    Console.WriteLine($"Order {o.id}");
                }
            }
            else
            {
                // 2.1 System displays ‘There are no New Orders at the moment’
                // 2.2 Use case ends
                // 2.1 System displays ‘There are no “Preparing” Orders at the moment’
                // 2.2 Use case ends
                Console.WriteLine($"There are no {state.ToString()} Orders at the moment.");
            }
            return displayallOrders;
        }

        public static List<Order> GetOrdersByState(OrderState state)
        {
            List<Order> orderByStateList = new List<Order>();
            if (state != null)
            {
                foreach (Order o in allOrders)
                {
                    if (o.state.GetType() == state.GetType())
                    {
                        orderByStateList.Add(o);
                    }
                }
            }
            else
            {
                foreach (Order o in allOrders)
                {
                    orderByStateList.Add(o);
                }
            }
            return orderByStateList;
        }

        public static Order GetOrderById(int id)
        {
            foreach (Order o in allOrders)
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
