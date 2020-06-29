using System;
using System.Collections.Generic;

namespace ConsoleApp.DataAccess.Entities
{
    public partial class Store
    {
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public string Location { get; set; }

        public virtual Product Prod { get; set; }
    }
}
