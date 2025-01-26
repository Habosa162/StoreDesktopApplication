using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Customer
    {

        [Key]
        public string phoneNo { get; set; }
        public string Name { get; set;  }

    }
}
