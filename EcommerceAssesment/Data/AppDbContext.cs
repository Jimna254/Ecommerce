using EcommerceAssesment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAssesment.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-KDHQCIN;" +
                "Initial Catalog = EcommerceApp;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;" +
                " User Id = sa;" +
                " Password= ");
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Shipment> Shipments { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
