using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.ProductModels
{
    public class DeviceMaintenance
    {

        [Key]
        public int DeviceMaintenanceId { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReceiveDate { get; set; } = DateTime.Now;
        public string DeviceSerialNo { get; set; }
        public bool isFixed { get; set; } = false; 





        //the Category of the Device in the Maintenance Console , 
        [ForeignKey("Category")]
		public int CategoryId { get; set; }

        //[ForeignKey("DeviceStatus")]
        //public int StatusId { get; set; }

		[ForeignKey("Platform")]
		public int PlatformId { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }



        public virtual Branch Branch { get; set; }

        public virtual Category Category { get; set; }
        //public virtual DeviceMaintenanceStatus DeviceStatus { get; set; }
        public virtual Platform Platform { get; set; }  

	}
}
