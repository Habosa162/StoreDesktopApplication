using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ViewControl
{
    public class CurrentUser
    {
        private static CurrentUser _instance;

        public static CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentUser();
                }
                return _instance;
            }
            private set { 
            }
        }

        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public int BranchId { get; set; }
        public string Branch { get; set; }  

        private CurrentUser()
        {
        }
    }

}
