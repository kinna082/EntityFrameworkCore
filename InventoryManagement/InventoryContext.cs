using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
   public class InventoryContext :DbContext
    {
      
        private const string connectionString = "Server=servername;Database=ProductInventory;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Products> Products { get; set; }
    }
}
