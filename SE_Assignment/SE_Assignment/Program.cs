using System;
using System.Collections.Generic;

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

            Console.WriteLine("Login");
            Console.WriteLine("1    Customer");
            Console.WriteLine("2    Employee");

            string loginType = Console.ReadLine();
            string accountType = "";

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            if (loginType == "1")
            {
                accountType = "Customer";

            }
            else if (loginType == "2")
            {
                accountType = "Employee";
            }

            Console.ReadKey();
        }

        static void InitData(List<Account> accountList, List<Customer> customerList, List<Employee> employeeList)
        {
            string[] emailArray = { "customer1@se.com", "employee1@se.com", "manager1@se.com", "assistant1@se.com", "chef1@se.com", "dispatcher1@se.com" };

            //for (int i = 0; i < emailArray.Length; i++)
            //{
            //    string accountName = $"account{i + 1}";
            //    Console.WriteLine("Creating" + accountName);
            //    Account accountName = new Account()
            //}
            Account account1 = new Account(1, "customer1@se.com", "12345678");
            Account account2 = new Account(2, "employee1@se.com", "12345678");
            Account account3 = new Account(3, "manager1@se.com", "12345678");
            Account account4 = new Account(4, "assistant1@se.com", "12345678");
            Account account5 = new Account(5, "chef1@se.com", "12345678");
            Account account6 = new Account(6, "dispatcher1@se.com", "12345678");

        }
    }
}
