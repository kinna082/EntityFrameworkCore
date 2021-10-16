using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryManagement
{
   public class Products
    {
        [Key]
        public int ProductIds { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int Quantity { get; set; }
    }
}
