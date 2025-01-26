using Store.Models.InvoiceModels;
using Store.Models.ProductModels;
using Store.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }


        //public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();   
        //public ICollection<Product> Products { get; set; } = new List<Product>();   
        //public ICollection<DigitalCard> DigitalCards { get; set; } = new List<DigitalCard>();
        //public ICollection<SystemUser> SystemUsers { get; set; } = new List<SystemUser>();
        //public ICollection<DeviceMaintenance> DeviceMaintenance { get; set; } = new List<DeviceMaintenance>(); 
        //public ICollection<Customer> Customers { get; set; } = new List<Customer>(); 
    }
}
