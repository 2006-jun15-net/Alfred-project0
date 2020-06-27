using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;



namespace ClassLibraryApp
{
    class Program
    {


        static void Main(string[] args)
        {

            serialize(); //serialize data from Data class

            deserialize();
            


            Functionality functionality = new Functionality();

            Console.WriteLine("welcome to the store application");
            bool choice = false;
            while (!choice)
            {

                Console.WriteLine("Press:\n 1 to add new customer\n 2 to place an order\n 3 to search a customer" +
                                   "\n 4 to quit the store system");
                string option = Console.ReadLine();
                int num = int.Parse(option);

                switch (num)
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


        /// <summary>
        /// This method serializes hardcode data from Data class.
        /// </summary>
        /// 
        const string filepath = @"../../../data.json"; //This string holds the filepath to which serialized data will be saved.
        public static void serialize()
        {
            Data data = new Data();  //object to serilaze
            Functionality functionality = new Functionality();

            
            string json = JsonConvert.SerializeObject(functionality);
            File.WriteAllText(filepath, json);

            string json1 = JsonConvert.SerializeObject(data);
            File.WriteAllText(filepath, json1);

        }

        public static void deserialize()
        {
            Data data = new Data();  //object to deserilaze
            Functionality functionality = new Functionality();
            string json1 = JsonConvert.SerializeObject(data);

            Object obj = JsonConvert.DeserializeObject<Object>(json1);

        }



       


    }
}

