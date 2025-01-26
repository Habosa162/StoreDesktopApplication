using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.ProductModels
{
    public class DeviceMaintenanceStatus
    {
        [Key]
        public int DeviceMaintenanceStatusId { get; set; }
        public string StatusName { get; set; }
    }
}
