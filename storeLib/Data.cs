using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Data
    {

        public List<Customer> Customers { get; }


        public List<Store> Stores { get; set; }

        public Data()
        {
            //initializing a store list
            this.Stores = new List<Store>();

            Product p1 = new Product("milk");
            Product p2 = new Product("bananas");
            Product p3 = new Product("brocolli");
            Product p4 = new Product("yogurt");

            //inventory 1
            List<Product> inventory1 = new List<Product>();
            inventory1.Add(p1);
            inventory1.Add(p2);
            inventory1.Add(p3);
            inventory1.Add(p4);

            Store Walmart = new Store("New York", inventory1);

            //meat prodcuts
            Product p5 = new Product("liver");
            Product p6 = new Product("fish");
            Product p7 = new Product("beef");
            Product p8 = new Product("chicken");

            //inventory2
            List<Product> inventory2 = new List<Product>();
            inventory2.Add(p5);
            inventory2.Add(p6);
            inventory2.Add(p7);
            inventory2.Add(p8);

            Store Kroger = new Store("London", inventory2);

           

            //adding stores to the storeList
            Stores.Add(Walmart);
            Stores.Add(Kroger);










        }


    }
}
