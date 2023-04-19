using DAL.Context.Config;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class DataContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Invoice> invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=forma-VDI1202\TFTIC;"
                                        + "Database=API_LABO2;"
                                        + "Trusted_Connection=True;"
                                        + "TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }

    }
}
