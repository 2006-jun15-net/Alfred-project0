using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ConsoleApp.DataAccess.Entities
{
    
    public partial class Orders
    {

        [Key]
        public int OrderId { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
