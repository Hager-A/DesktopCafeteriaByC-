//using DesktopProject.Entities;
using DesktopProject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject
{
    class ITIcontext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Product> Order_Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-DV1U283\\SQLEXPRESS01;Initial Catalog=DesktopCafe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-N3T3R6C\\SQLEXPRESS;Initial Catalog=DesktopCafe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Product>(s =>
            {
                s.HasKey(c => new { c.ProductID, c.OrderID });
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
