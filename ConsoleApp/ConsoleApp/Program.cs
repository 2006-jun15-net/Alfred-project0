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
            Functionality functionality = new Functionality();

            Console.WriteLine("welcome to the store application");
            bool choice = false;
            while (!choice)
            {
               
                Console.WriteLine("Press:\n 1 to add new customer\n 2 to place an order\n 3 to search a customer" +
                                   "\n 4 to quit the store system");
                string option = Console.ReadLine();
                int num = int.Parse(option);

                switch(num)
                {
                    case 1:
                        functionality.addNewCustomer();
                        break;

                    case 2:
                        functionality.placeOrder();
                        break;

                    case 3:
                        functionality.searchCustomer();
                        break;

                    case 4:
                        choice = true; //quiting from the store application
                        break;
                 



                }


            }
           
        }



      
    }
}
