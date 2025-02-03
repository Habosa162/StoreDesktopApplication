using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.ProductModels
{
    public class Condition
    {

        [Key]
        public int ConditionId { get; set; }
        public string condition { get; set; }


    }
}
