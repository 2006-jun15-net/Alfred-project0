using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp
{
    public class Store
    {
        public string Name { get; set; }

        public List<Product> Inventory { get; set; }

        //constructor
        public Store(string name, List<Product> inventory)
        {
            this.Name = name;
            this.Inventory = inventory;

        }
    }
}
