using System;
using System.Collections.Generic;

namespace ConsoleApp.DataAccess.Entities
{
    public partial class Product
    {
        public Product()
        {
            Store = new HashSet<Store>();
        }

        public int ProdId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Store> Store { get; set; }
    }
}
