using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.ProductModels
{
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }


        //public ICollection<Product> Products { get; set; } = new List<Product>();
        //public ICollection<DeviceMaintenance> DeviceMaintenances { get; set; } = new List<DeviceMaintenance>();
        //public ICollection<DigitalCard> DigitalCards { get; set; } = new List<DigitalCard>(); 
    }
}
