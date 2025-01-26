using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.ProductModels
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public int StockQuantity { get; set; }
        public string? SerialNo { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }

        [ForeignKey("Platform")]
        public int PlatformId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }


        public virtual Branch Branch { get; set; }
        public virtual Category Category { get; set; }
        public virtual Platform Platform { get; set; }

    }
}
