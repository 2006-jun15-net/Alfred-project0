using System;
using System.Collections.Generic;

namespace ConsoleApp.DataAccess.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
