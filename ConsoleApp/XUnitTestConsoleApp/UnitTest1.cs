using System;
using Xunit;
using System.Collections.Generic;
using ClassLibraryApp;






namespace ConsoleAapp
{
    public class UnitTest1
    {
       
        

        List<Customer> customers = new List<Customer>();

       
       [Fact]
        public void TestNumberOfCustomers()
        {
            Functionality functionality = new Functionality();

            //creating creating to add to the list
            Customer customer1 = new Customer("Alfred", "Rwagaju");
            Customer customer2 = new Customer("Marcus", "Rashford");
            Customer customer3 = new Customer("Gabriel", "Jesus");
            Customer customer4 = new Customer("Mane", "Sadio");
            Customer customer5 = new Customer("Christian", "Pullisic");
            Customer customer6 = new Customer("Jose", "Mourinho");

            //adding the csutomers to the list
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);
            customers.Add(customer6);

            Assert.Equal(expected: 6, actual: customers.Count);
            
















        }
    }
}
