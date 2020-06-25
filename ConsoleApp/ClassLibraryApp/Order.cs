using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp
{
    /// <summary>
    /// This class holds information pertaining the order.
    /// </summary>
    public class Order : IDisplay
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
        /// <summary>
        /// This method displays order details. It implements display method from IDisplay interface
        /// </summary>
        public void display()
        {
            Console.WriteLine("The order was placed");
            Console.WriteLine("Order Details");
            Console.WriteLine($"Customer's full name; {Customer.FirstName} {Customer.LastName}");
            Console.WriteLine($"Location were the order was placed: {Location}");
            Console.WriteLine($"The order was the following products");
            Cart.ForEach(product => Console.WriteLine(product.Name));
            Console.WriteLine($"The order was placed on {DateTime.Now.ToString()}");



        }


    }
}
