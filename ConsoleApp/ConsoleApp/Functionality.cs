using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp
{
    class Functionality
    {
        public Functionality()
        {

        }

        /// <summary>
        /// This method adds a new customer in the system
        /// </summary>

        Data data = new Data();  // a data object to acccess the Customer list
        public void addNewCustomer()
        {
            
            while (true)
            {
                Console.WriteLine("Enter 1 to add new customer, 0 to stopping adding");
                string input = Console.ReadLine();
                int option = int.Parse(input);
                if (option == 1)
                {
                    Console.WriteLine("Enter your first and last name");

                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();

                    //creating a customer object
                    Customer customer = new Customer(firstName, lastName);


                    //adding customers in the storage, if the customer is not in the system, go ahead and add them, otherwise they
                    //are already in the system.
                    data.Customers.Add(customer);
                    /*
                    if (searchCustomer(customer) == false)
                   {
                     
               
                       

                    }
                   else
                   {
                       Console.WriteLine("Customer already in the system");
                   }
                    */


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

        public  void searchCustomer()
        {
           
            Console.WriteLine("Enter customer's first name");
            string inputfirstName = Console.ReadLine();  // first name
            Console.WriteLine("Enter customer's last name");
            string inputLastName = Console.ReadLine();   // last name
            foreach (Customer cust in data.Customers)
            {
                if (inputfirstName.Equals(cust.FirstName) && inputLastName.Equals(cust.LastName))
                {
                    Console.WriteLine($"{inputfirstName} {inputLastName} is added in the system");

                }

            }

        }


        /// <summary>
        /// This method places the order
        /// </summary>
        public  void placeOrder()
        {
            Console.WriteLine("Select a store from the options below:");
            Console.WriteLine();

            display(); //displaying the stores
            Console.WriteLine("--------------------------------------");

            //reading the input from the user
            string selectedStore = Console.ReadLine();
            Console.WriteLine("---------------------------------------");

            Data data = new Data();  //instatiating an object that will call a list of stores from the Data class

            foreach (Store store in data.Stores)
            {
                if (selectedStore.Equals(store.Name))
                {
                    Console.WriteLine("This store has the following products:");
                    //display all the products in the selected store
                    store.Inventory.ForEach(product => product.display());  //displays the products
                }
            }

            //select products from the selected store and add them in your cart

            List<Product> cart = new List<Product>(); // a shopping cart for the customer

            Console.WriteLine("Enter your first and last name to continue with your order");
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
                                    //removing product from the store after being selected

                if (selectedProduct.Equals("placeOrder"))
                {
                    break;
                }



            }
            timeOfOrder = DateTime.Now.ToString(); //creating a time stamp when the order was placed
            Order order = new Order(selectedStore, customer, timeOfOrder, cart);
            customer.Orders.Add(order); //adding orders to a customer's list
            order.display();




        }

        //displaying store locations
        public  void display()
        {
            Data data = new Data();
            foreach (Store store in data.Stores)
            {
                Console.WriteLine(store.Name);

            }


        }

    }


}
