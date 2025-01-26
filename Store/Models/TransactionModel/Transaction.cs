using Store.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.TransactionModel
{
    public class Transaction
    {

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date {  get; set; }  
        public double value {  get; set; }

        [ForeignKey("Branch")]
        public int BranchID { get; set;  }

        [ForeignKey("TransactionType")]
        public int TransactionTypeID { get; set; }

        [ForeignKey("SystemUser")]
        public String username { get; set; } 



        public virtual TransactionType TransactionType { get; set; }    
        public virtual Branch Branch { get; set; }  
        public virtual SystemUser SystemUser { get; set; }

   
    }
}
