﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using ConsoleApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using ConsoleApp;
using ConsoleApp.DataAccess.Repositories;

namespace ClassLibraryApp
{
    class Program
    {
        /// <summary>
        /// Confugures the logging system
        /// </summary>
        public static readonly ILoggerFactory MyLoggerFactory
           = LoggerFactory.Create(builder => { builder.AddConsole(); });

        /// <summary>
        /// Connects to the SQL server
        /// </summary>

        public static readonly DbContextOptions<storeApplicationContext> Options = new DbContextOptionsBuilder<storeApplicationContext>()
            .UseLoggerFactory(MyLoggerFactory)
            .UseSqlServer(SecretConfiguration.ConnectionString)
            .Options;


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
                Console.WriteLine("-------------------------------------------------");
                string option = Console.ReadLine();
                int num = 0;
               

                    try
                    {
                        num = int.Parse(option);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please try again. Attempted to use wrong input character.");
                        Console.WriteLine("Press numbers 1-4 to make your selection");
                    Console.WriteLine("--------------------------------------------------");

                    }
                    finally
                    {
                        switch (num)
                        {
                            case 1:
                               
                                CustomerRepository.Add();

                               
                                break;

                            case 2:
                                OrderRep.addOrder();
                            
                                break;

                            case 3:
                        
                                CustomerRepository.searchCustomer();
                                break;


                            case 4:
                                choice = true; //quiting from the store application
                                break;

                            default:
                                Console.WriteLine("Please try again. Attempted to use wrong input character.");
                                Console.WriteLine("Press numbers 1-4 to make your selection");
                                break;


                    }

                       


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

        /// <summary>
        /// This method deserializes the data
        /// </summary>
        public static void deserialize()
        {
            Data data = new Data();  //object to deserilaze
            Functionality functionality = new Functionality();
            string json1 = JsonConvert.SerializeObject(data);

            Object obj = JsonConvert.DeserializeObject<Object>(json1);

        }



       


    }
}

