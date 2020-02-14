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


            DateTime currentDate = new DateTime(2020, 2, 11);
            Manager manager1 = new Manager(1 , "Manageer", "T1236592Z", "Male", "12345678", currentDate, "Manager", account3);
            employeeList.Add(manager1);

            //Order order1 = new Order()
        }

        static bool HandleLogin(string loginType, string email, string password, List<Customer> customerList, List<Employee> employeeList)
        {
            Console.Write("Email:");
            email = Console.ReadLine();

            Console.Write("Password:");
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
                        ManagerMenu(loginType, e.Status);
                    }
                }
            }
            return success;
        }

        static void ManagerMenu(string loginType, string status)
        {
            Console.WriteLine("Choose action\n" +
                "1) Add Food Item\n" +
                "2) Update Food Item\n" +
                "3) Delete Food Item\n" +
                "4) Add Menu\n" +
                "5) Update Menu\n" +
                "6) Delete Menu\n" +
                "0) Escape from this");

            string selection = Console.ReadLine();
            switch (Convert.ToInt32(selection))
            {
                case 1:
                    Console.WriteLine("Its 1");
                    break;
                case 2:
                    Console.WriteLine("Its 2");
                    break;
                case 3:
                    Console.WriteLine("Its 3");
                    break;
                case 4:
                    Console.WriteLine("Its 4");
                    break;
                case 5:
                    Console.WriteLine("Its 5");
                    break;
                case 6:
                    Console.WriteLine("Its 6");
                    break;
                case 0:
                    break;
            }
        }
    }
}
