using System;
using System.Collections.Generic;

namespace BusinessLogicLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("milk");
            Product p2 = new Product("bananas");
            Product p3 = new Product("brocolli");
            Product p4 = new Product("yogurt");
            int[] arr = { 1, 2 };
            Array.Sort(arr);

           


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

           
            






        }
    }
}
