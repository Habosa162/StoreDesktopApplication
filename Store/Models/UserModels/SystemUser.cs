using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.User
{
    public class SystemUser
    {
        [Key]
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool isActive { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }

        public virtual Role Role { get; set; } 
        public virtual Branch Branch { get; set; } 


    }
}
