using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessLogicLib
{
    class Store
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
