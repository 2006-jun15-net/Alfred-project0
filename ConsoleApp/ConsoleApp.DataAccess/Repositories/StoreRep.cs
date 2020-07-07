using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using ConsoleApp.DataAccess.Entities;

namespace ConsoleApp.DataAccess.Repositories
{

    /// <summary>
    /// Repository for store class: includes a method to display all available stores 
    /// </summary>
    public static class StoreRep
    {
        /// <summary>
        /// A void method that dissplays the stores to the console.
        /// </summary>
        public static void display()
        {
            
            using (var dbContext = new storeApplicationContext())
            {
                Console.WriteLine("These are stores in the system:");
                Console.WriteLine("----------------------------------");
                foreach (var store in dbContext.Store)
                {
                    
                    Console.WriteLine(store.Location);
                }


            }


        }
    
    }


        
}
