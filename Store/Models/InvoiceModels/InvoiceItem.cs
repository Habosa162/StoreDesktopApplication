using Store.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.InvoiceModels
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }
        
        public int ItemQuantity { get; set; }
        
        public double InvoiceItemPrice { get; set; }

        public double InvoiceItemTotal { get; set; }


        public int? InvoiceId { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }

        [ForeignKey("DeviceMaintenance")]
        public int? DeviceMaintenanceId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; } 
        public virtual DeviceMaintenance DeviceMaintenance { get; set; } 
    
	}
}
