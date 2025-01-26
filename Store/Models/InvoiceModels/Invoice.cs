using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.InvoiceModels
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date{ get; set; }

        public DateTime CheckOutDate { get; set; }
        public double TotalAmount { get; set; } 
        public int BranchId { get; set; }

        [ForeignKey("Customer")]
        public string CustomerPhoneNumber { get; set;  }
        public bool IsCheckOut { get; set;  } = false;


        public virtual Customer Customer { get; set; }  
        public virtual Branch Branch { get; set; } 
        public ICollection<InvoiceItem> invoiceItems { get; set; } = new List<InvoiceItem>();
    }
}
