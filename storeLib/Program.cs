using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BusinessLogicLib
{
    class Program
    {
        //create a data storage for customers
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            Product p1 = new Product("milk");
            Product p2 = new Product("bananas");
            Product p3 = new Product("brocolli");
            Product p4 = new Product("yogurt");
           
            

           


            //a list of inventory
            List<Product> inventory1 = new List<Product>();
            inventory1.Add(p1);
            inventory1.Add(p2);
            inventory1.Add(p3);
            inventory1.Add(p4);

            Store store1 = new Store("New York", inventory1);

            //meat prodcuts
            Product p5 = new Product("liver");
            Product p6 = new Product("fish");
            Product p7 = new Product("beef");
            Product p8 = new Product("chicken");


            List<Product> inventory2 = new List<Product>();
            inventory2.Add(p5);
            inventory2.Add(p6);
            inventory2.Add(p7);
            inventory2.Add(p8);

            Store store2 = new Store("London", inventory2);


            //user interface
            //entering customers in the system

   
            while (true)
            {
                Console.WriteLine("welcome to the store application. Enter 1 to add new customer, 0 to stopping adding or 3 to search a customer");
                string input = Console.ReadLine();
                int option = int.Parse(input);
                if(option == 1)
                {
                    Console.WriteLine("Enter your first and last name");

                    string firstNmae = Console.ReadLine();
                    string lastName = Console.ReadLine();

                    //creating a customer object
                    Customer customer = new Customer(firstNmae, lastName);

                    //adding customers in the storage, if the customer is not in the system, go ahead and add them, otherwise they
                    //are already in the system.
                    if(searchCustomer(customer) == false)
                    {
                        customers.Add(customer);

                    }
                    else
                    {
                        Console.WriteLine("Customer already in the system");
                    }
                    

                }
                
                else
                {
                    break;
                }

                
            }

            

        }

        //method to search customers in the system.
        public static bool searchCustomer(Customer customer)
        {
            foreach(Customer cust in customers)
            {
                if(customer.LastName.Equals(cust.LastName))
                {
                    return true;

                }
            }
            return false;
            
        }
    }
}
