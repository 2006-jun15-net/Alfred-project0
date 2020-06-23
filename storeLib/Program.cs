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
            
       

            placeOrder();  //placing orders
            

            /*
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
            */
            
            

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

        //placing an order
        public static void placeOrder()
        {
            Console.WriteLine("Select a store from the options below:");
            Console.WriteLine();

            display(); //displaying the stores

            //reading the input from the user
            string selectedStore = Console.ReadLine();

            Data data = new Data();  //instatiating an object that will call a list of stores from the Data class

            foreach(Store store in data.Stores)
            {
                if(selectedStore.Equals(store.Name))
                {
                    //display all the products in the selected store
                    store.Inventory.ForEach(product => Console.WriteLine(product.Name));
                }
            }


        }

        //displaying store locations
        public static void display()
        {
            Data data = new Data();
            foreach(Store store in data.Stores)
            {
                Console.WriteLine(store.Name);

            }


        }
    }
}
