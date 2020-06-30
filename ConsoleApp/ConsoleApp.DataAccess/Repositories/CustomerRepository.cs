using ConsoleApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryApp.Interfaces;
namespace ConsoleApp.DataAccess.Repositories
{ 
    public  static class CustomerRepository

    {
        public static void Add()
        {
            using(var dbContext = new storeApplicationContext())
            {
                var customer = new Customer();
                Console.WriteLine("Enter a customer's first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter a customer's last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter a customer's gender");
                string sex = Console.ReadLine();
               customer.FirstName = firstName;
               customer.LastName = lastName;
               customer.Sex = sex;

                
                dbContext.Add(customer);
                dbContext.SaveChanges();
            }
        }

        //searching a customer in the system
        public static bool searchCustomer()
        {
            using (var dbContext = new storeApplicationContext())
            {
                Console.WriteLine("Enter customer's first name");
                string inputfirstName = Console.ReadLine();  // first name
                Console.WriteLine("Enter customer's last name");
                string inputLastName = Console.ReadLine();   // last name

                var customer = new Customer();
                customer.FirstName = inputfirstName;
                customer.LastName = inputLastName;
                foreach (var cust in dbContext.Customer)
                {
                    if (customer.FirstName.Equals(cust.FirstName) && customer.LastName.Equals(cust.LastName))
                    {
                        Console.WriteLine($"{customer.FirstName} {customer.LastName} is in the system");
                        return true;
                    }
                }


            }Console.WriteLine("The customer is not in the system");
            return false;

        }
    }
}
