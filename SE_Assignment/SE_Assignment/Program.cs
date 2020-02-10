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

            InitData(accountList, customerList, employeeList);
            foreach (Account c in accountList)
            {
                Console.WriteLine(c.Email);
            }
            Console.WriteLine(accountList.Count);

            bool login = false;
            while (!login)
            {
                Console.WriteLine("Login");
                Console.WriteLine("=====");
                Console.WriteLine("1    Customer");
                Console.WriteLine("2    Employee");

                string loginType = Console.ReadLine();
                string email = "";
                string password = "";

                if (loginType == "1" || loginType == "2")
                {
                    login = HandleLogin(loginType, email, password, customerList, employeeList);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option!");
                }
            }

            Console.ReadKey();
        }

        static void InitData(List<Account> accountList, List<Customer> customerList, List<Employee> employeeList)
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

            //Order order1 = new Order()
        }

        static bool HandleLogin(string loginType, string email, string password, List<Customer> customerList, List<Employee> employeeList)
        {
            Console.WriteLine("Email:");
            email = Console.ReadLine();

            Console.WriteLine("Password:");
            password = Console.ReadLine();

            bool success = false;

            if (loginType == "1")
            {
                foreach (Customer c in customerList)
                {
                    if (c.Account.Email == email && c.Account.Password == password)
                    {
                        success = true;
                        Console.WriteLine("Logged in successfully!");
                        Console.WriteLine($"Welcome, {c.Name}!");
                    }
                }
            }
            else if (loginType == "2")
            {
                foreach (Employee e in employeeList)
                {
                    if (e.Account.Email == email && e.Account.Password == password)
                    {
                        success = true;
                        Console.WriteLine("Logged in successfully!");
                        Console.WriteLine($"Welcome, {e.Name}!");
                    }
                }
            }
            return success;
        }
    }
}
