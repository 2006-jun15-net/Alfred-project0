using System;
using Xunit;
using ConsoleApp.DataAccess.Entities;
using System.Linq;
using Xunit.Sdk;

namespace XUnitTestConsoleApp
{
    public class UnitTest1
    {
       
        /// <summary>
        /// Test the number of customers in the system.
        /// </summary>
       
       [Fact]
        public void TestNumberOfCustomers()
        {
          
            using (var dbContext = new storeApplicationContext())

            { 
                int numOfCustomer  = dbContext.Customer.Count();
                Assert.Equal(expected: 13, actual: numOfCustomer);

            }

        }

        [Fact]
        public void TestNumberProducts()
        {
            using (var dbContext = new storeApplicationContext())
            {
                int numOfProducts = dbContext.Product.Count();
                Assert.Equal(expected: 8, actual: numOfProducts);
            }
           

        }

        /// <summary>
        /// Test the number of stores in the system.
        /// </summary>

        [Fact]
        public void TestNumberOfStores()
        {
            using (var dbContext = new storeApplicationContext())
            {
                int numOfStores = dbContext.Store.Count();
                Assert.Equal(expected: 7, actual: numOfStores);



            }

        }

        /// <summary>
        /// Test the existence of a particular customer in the system.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>

        [Theory]
        [InlineData("yimenez", "gomez")]
        [InlineData("alfred","rwagaju")]
        [InlineData("Jacob", "Smith")]
        [InlineData("Michael", "Madison")]
        [InlineData("Ethan", "Elizabeth")]
        [InlineData("Diana", "McCarthy")]
        [InlineData("alfred", "lioneli")]
        public void searchCustomer(string firstName, string lastName)
        {
            using (var dbContext = new storeApplicationContext())
            {
                foreach (var customer in dbContext.Customer)
                {
                    if (customer.FirstName.Equals(firstName) && customer.LastName.Equals(lastName))
                    {
                        Assert.Equal($"{firstName} {lastName}", $"{customer.FirstName} {customer.LastName}");
                    }
                }

            }

        }
    }
}
