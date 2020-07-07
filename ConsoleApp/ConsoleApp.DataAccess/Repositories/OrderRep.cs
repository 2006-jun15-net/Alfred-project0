using ClassLibraryApp;
using ConsoleApp.DataAccess.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.DataAccess.Repositories
{

    /// <summary>
    /// Repository for the orders: includes a method to place an order given customer input
    /// </summary>
    public static class OrderRep
    {
       /// <summary>
       /// places an order for the customer.
       /// </summary>
        public static void addOrder()
        {

            using(var dbContext = new storeApplicationContext())
            {
                
                StoreRep.display();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Select a store");
                Console.WriteLine("------------------------------------------");
                string selectedStore = Console.ReadLine();
                Console.WriteLine("---------------------------------------------");
                int storeID = 0; //storing this for later use
                int proID = 0; //storing the ID for later use
                int inventory = 0; //storing the stock for later use
                foreach (var store in dbContext.Store)
                {
                    if(store.Location.Equals(selectedStore))
                    {
                       
                        storeID =+ store.StoreId;
                    }
                   
                    
                }
                foreach(var inventory_stock in dbContext.InventoryStocked)
                {
                    if(inventory_stock.StoreId == storeID)
                    {
                        proID += inventory_stock.ProdId;
                        inventory += (int)inventory_stock.Stock; //casting to int
                        
                    }

                }

                foreach(var product in dbContext.Product)
                {
                    if(product.ProdId == proID)
                    {
                        Console.WriteLine($"{selectedStore} has the following product and its quantity/stock");
                        Console.WriteLine($"Product name: {product.Name}");
                        Console.WriteLine($"Stock: {inventory}");
                        Console.WriteLine("--------------------------------------------");
                    }
                }

                Console.WriteLine("Enter your first and last name to continue with order");
                string FName = Console.ReadLine();
                string LName = Console.ReadLine();
                int id = 0; //store the id of a selected customer.
                foreach(var customer in dbContext.Customer)
                {
                    if(customer.FirstName.Equals(FName) && customer.LastName.Equals(LName))
                    {
                        id += customer.CustId;
                       
                       


                    }
                }
                var order = new Orders();  // instantiate a new order
                order.CustId = id;  //Assigning the foreign key CustId in the order to the id of the selected customer.
                dbContext.Add(order); // adding the new order in the system
                dbContext.SaveChanges();
                Console.WriteLine("Enter the number of products to put in your cart:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");
                var order_details = new OrderDetails();
                order_details.OrderId = order.OrderId;
                order_details.ProdId = proID;
                order_details.Qty = num;
                dbContext.AddAsync(order_details);

                Console.WriteLine("Order has been successfully placed");
                Console.WriteLine("--------------------------------------------------");





            }

        }


    }
}
