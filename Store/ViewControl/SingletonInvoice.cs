using Store.Models.InvoiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ViewControl
{
    internal class SingletonInvoice
    {


        private static Invoice _invoice;
        private  static CurrentUser currentuser = CurrentUser.Instance;

        public static Invoice invoice
        {
            get
            {
                if (_invoice == null) {

                    _invoice = new Invoice() { 
                        Date = DateTime.Now,
                        BranchId = currentuser.BranchId
                    };
                    
                }               
                    return _invoice;
            }
        }

        public static void ClearInvoice()
        {
            _invoice = null;    
        }

        private SingletonInvoice() { }
    }
}
