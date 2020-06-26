
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
    }
}

