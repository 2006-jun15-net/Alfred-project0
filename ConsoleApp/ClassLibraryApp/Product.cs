using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp
{
    /// <summary>
    /// This class holds the information of the product such as its name.
    /// </summary>
    public class Product : IDisplay
    {
        //properties
        public string Name { get; set; }

        //Constructor 
        public Product(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// public method displays the name of the product.
        /// </summary>
        public void display()
        {
            Console.WriteLine($"{Name}");
        }

        


    }
}
