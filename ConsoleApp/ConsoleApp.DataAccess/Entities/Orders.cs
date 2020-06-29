using System;
using System.Collections.Generic;

namespace ConsoleApp.DataAccess.Entities
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
