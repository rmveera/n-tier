using Microsoft.EntityFrameworkCore;
using System;

using OSCBOL;

namespace OSCDAL
{
    public class OSCDbContext : DbContext 
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=HCHLH1216LP1366;Database=EFCoreOSCDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
