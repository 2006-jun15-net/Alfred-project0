using System;
using System.Collections.Generic;



namespace ClassLibraryApp
{
    class Program
    {
     

        static void Main(string[] args)
        {
            //addNewCustomer();
            //placeOrder();  //placing orders
          
            while (true)
            {
                Console.WriteLine("Press: 1 to add new customer\n       2 to place an order");
                string option = Console.ReadLine();
                int num = int.Parse(option);

                switch(num)
                {
                    case 1:
                        addNewCustomer();
                        break;

                    case 2:
                        placeOrder();
                        break;

                    case 3:
                        break;



                }


            }
           
        }



        /// <summary>
        /// This method adds a new customer in the system
        /// </summary>
        static void addNewCustomer()
        {
            Data data = new Data();  // a data object to acccess the Customer list
            while (true)
           {
               Console.WriteLine("welcome to the store application. Enter 1 to add new customer, 0 to stopping adding");
               string input = Console.ReadLine();
               int option = int.Parse(input);
               if(option == 1)
               {
                   Console.WriteLine("Enter your first and last name");

                   string firstName = Console.ReadLine();
                   string lastName = Console.ReadLine();

                   //creating a customer object
                   Customer customer = new Customer(firstName, lastName);
                   

                   //adding customers in the storage, if the customer is not in the system, go ahead and add them, otherwise they
                   //are already in the system.
                   if(searchCustomer(customer) == false)
                   {
                     
               
                        data.Customers.Add(customer);

                    }
                   else
                   {
                       Console.WriteLine("Customer already in the system");
                   }


               }

               else
               {
                   break;
               }

           }

            data.Customers.ForEach(customer => Console.WriteLine(customer.LastName));
           

        }

        /// <summary>
        /// This methods search a customer in the system. Returns true if the customer in the system otherwise false.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns bool ></returns>
        public static bool searchCustomer(Customer customer)
        {
            Data data = new Data(); // data object to access the Customer list
            foreach (Customer cust in data.Customers)
            {
                if (customer.LastName.Equals(cust.LastName))
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName} is in the system");
                    return true;



                }
            }
            return false;

        }

        
        /// <summary>
        /// This method places the order
        /// </summary>
        public static void placeOrder()
        {
            Console.WriteLine("Select a store from the options below:");
            Console.WriteLine();

            display(); //displaying the stores

            //reading the input from the user
            string selectedStore = Console.ReadLine();

            Data data = new Data();  //instatiating an object that will call a list of stores from the Data class

            foreach (Store store in data.Stores)
            {
                if (selectedStore.Equals(store.Name))
                {
                    //display all the products in the selected store
                    store.Inventory.ForEach(product => product.display());  //displays the the products
                }
            }

            //select products from the selected store and add them in your cart

            List<Product> cart = new List<Product>(); // a shopping cart for the customer

            Console.WriteLine("Enter your first and last name");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            Customer customer = new Customer(firstName, lastName);




            string timeOfOrder = " ";  //a variable to hold the timestamp at which the order was made
            Console.WriteLine("Select products to add to your cart and type placeOrder to place the order");
            while (true)
            {
                string selectedProduct = Console.ReadLine();  //reading the user input for a selected product

                Product product = new Product(selectedProduct);

                cart.Add(product);  //adding the selected product to the cart
                if (selectedProduct.Equals("placeOrder"))
                {
                    break;
                }

               

            }
            timeOfOrder = DateTime.Now.ToString(); //creating a time stamp when the order was placed
            Order order = new Order(selectedStore, customer, timeOfOrder, cart);
            order.display();

            //Console.WriteLine(customer.FirstName + " " + customer.LastName);
            //Console.WriteLine($"The selected store was {selectedStore}");
            //Console.WriteLine($"The order was placed on {timeOfOrder}");
            //Console.WriteLine("order placed");



        }

        //displaying store locations
        public static void display()
        {
            Data data = new Data();
            foreach (Store store in data.Stores)
            {
                Console.WriteLine(store.Name);

            }


        }
    }
}
