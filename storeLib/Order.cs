using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLib
{
    class Order
    {
        //properties
        public string Location { get; set; }

        public Customer Customer { get; set; }

        public string Datetime { get; set; }

        public List<Product> Cart { get; set; }

        public Order(string location, Customer customer, string datetime, List<Product> cart)
        {

            this.Location = location;
            this.Customer = customer;
            this.Datetime = datetime;
            this.Cart = cart;

        

        }
    }
}
