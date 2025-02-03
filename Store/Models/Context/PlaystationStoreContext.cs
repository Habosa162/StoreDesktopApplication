using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Models.User;
using Store.Models.ProductModels;
using Store.Models.InvoiceModels;
using Store.Models.TransactionModel;

namespace Store.Models.Context
{
    public class PlaystationStoreContext : DbContext
    {
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<DeviceMaintenance> DeviceMaintenances { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-BPQ7J2U\\SQLEXPRESS;Database=PlaystationStore;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<StudentCourse>().HasKey(t => new { t.StudentID, t.CoursetID });
        }
    }
}
