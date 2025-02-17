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
            optionsBuilder.UseSqlServer("Data Source=den1.mssql7.gear.host;Initial Catalog=joystick;Persist Security Info=True;User ID=joystick;Password=Fc8C~O6yuv~5;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-BPQ7J2U\\SQLEXPRESS;Initial Catalog=PlaystationStore;Integrated Security=True;Encrypt=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().HasData(SeedDataBranches());
            modelBuilder.Entity<Role>().HasData(SeedDataRoles());
            modelBuilder.Entity<SystemUser>().HasData(SeedDataUsers());
            modelBuilder.Entity<Condition>().HasData(SeedDataConditions());
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<StudentCourse>().HasKey(t => new { t.StudentID, t.CoursetID });
        }
        ICollection<Role> SeedDataRoles()
        {
            List<Role> roles = new List<Role>()
            {
                new()
                {
                    ID = 1 , 
                    Name = "admin",
                },
                new()
                {
                    ID = 2 ,
                    Name = "cashier"
                }
            }; 
            return roles;   
        }
        ICollection<Branch> SeedDataBranches()
        {
            List<Branch> branches = new List<Branch>()
            {
                new()
                {
                    BranchId= 1 ,
                  BranchName = "Hurghada"
                },
                new()
                {
                    BranchId = 2,
                    BranchName = "Cairo"
                }
            };
            return branches; 
        }
        ICollection<SystemUser> SeedDataUsers()
        {
            List<SystemUser> users = new List<SystemUser>()
            {
                new
                (){
                   UserName = "Admin",
                   PassWord = "joystick112233",
                   isActive = true ,
                   RoleId = 1 ,
                   BranchId = 1 ,
                },
                new
                (){
                   UserName = "cash",
                   PassWord = "cash",
                   isActive = true ,
                   RoleId = 2 ,
                   BranchId = 1 ,
                   }
            };
            return users; 
        }
        ICollection<Condition> SeedDataConditions()
        {
            var conditions = new List<Condition>()
            {
                new()
                {
                    ConditionId = 1 ,
                    condition = "New"
                },
                new()
                {
                    ConditionId = 2 ,   
                    condition  = "Used"
                }
            };
            return conditions; 
        }
    }
}
