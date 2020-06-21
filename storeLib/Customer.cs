using System;
using System.Collections.Generic;
using System.Text;

namespace storeLib
{
    class Customer
    {
     
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
