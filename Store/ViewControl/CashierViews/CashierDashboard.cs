using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
using Store.Models.InvoiceModels;
using Store.ViewControl.CashierViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.ViewControl
{
    public partial class CashierDashboard : Form
    {


        public CashierDashboard()
        {
            InitializeComponent();
        }

        private void CreateInvoiceBtn_Click(object sender, EventArgs e)
        {
          
            InvoiceView InvoiceViewObj = new InvoiceView();
            InvoiceViewObj.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DeviceMaintenanceView DMpage = new DeviceMaintenanceView();
            DMpage.Show();
            this.Close();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            InventoryView inventoryView = new InventoryView();
            inventoryView.Show();
            this.Close();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            TransActionsView TransActionsView = new TransActionsView();
            TransActionsView.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransactionSummary transactionSummary = new TransactionSummary();
            string transactionsPath = @$"..\DailyReport\{DateTime.Now.ToString("yyyyMMdd_HHmmss")}TransactionSummary.pdf";
            transactionSummary.GenerateTransactionSummaryPDF(transactionsPath);
            MessageBox.Show("PDF has been saved successfully"); 
        }
    }
}
