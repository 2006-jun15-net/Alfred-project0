
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp
{
    /// <summary>
    /// This class holds the first and last name of the customer
    /// </summary>
    public class Customer
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Order> Orders { get; set; }


        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Orders = new List<Order>();
        }

        //displaying a customer's orders
       /* public void display()
        {
            for(int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"Details of order number {i+1}");
                Orders[i].display();
            }
            

        }*/
        
    }
}

