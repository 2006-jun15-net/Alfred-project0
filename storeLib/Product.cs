using System;
using System.Collections.Generic;
using System.Text;

namespace storeLib
{
    class Product
    {

        //name of the product
        private string name;

        //properties
        public string Name { get; set; }

        //Constructor 
        public Product(string name)
        {
            this.Name = name;
        }

    }
}
