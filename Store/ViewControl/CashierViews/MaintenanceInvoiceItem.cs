using Microsoft.EntityFrameworkCore;
using Store.Migrations;
using Store.Models.Context;
using Store.Models.InvoiceModels;
using Store.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.ViewControl.CashierViews
{
    public partial class MaintenanceInvoiceItem : Form
    {
        PlaystationStoreContext _context = new PlaystationStoreContext();
        Invoice _Invoice = SingletonInvoice.invoice;
        CurrentUser user = CurrentUser.Instance;
        int _DeviceID;

        public MaintenanceInvoiceItem()
        {
            InitializeComponent();
        }
      

        void ReadOnlyInputs()
        {
            SerialtextBox.ReadOnly = true;
            PricetextBox.ReadOnly = true;
            DescriptionrichTextBox.ReadOnly = true;
            RecieveDatetextBox.ReadOnly = true;
            DeliveryDatetextBox.ReadOnly = true;
            PlatfromtextBox.ReadOnly = true;
            CategorytextBox.ReadOnly = true;
        }




        void LoadDeviceMaitenance()
        {

            var Devices = _context
                 .DeviceMaintenances
                 .Where(d => d.BranchId == user.BranchId)
                 .Where(d => d.isFixed == false)
                 .Include(d => d.Category)
                 .Include(d => d.Platform)
                 .Select(d => new
                 {
                     ID = d.DeviceMaintenanceId,
                     Serial_No = d.DeviceSerialNo,
                     Price = d.Price,
                     Description = d.Description,
                     Receive_Date = d.ReceiveDate,
                     Delivery_Date = d.DeliveryDate,
                     Platform = d.Platform.PlatformName,
                     Category = d.Category.CategoryName

                 }).ToList();
            dataGridView1.DataSource = Devices;

        }

        private void MaintenanceInvoiceItem_Load(object sender, EventArgs e)
        {
            LoadDeviceMaitenance();
            ReadOnlyInputs();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];
                _DeviceID = (int)selectedRow.Cells["ID"].Value;

                SerialtextBox.Text = selectedRow.Cells["Serial_No"].Value.ToString();
                PricetextBox.Text = selectedRow.Cells["Price"].Value.ToString();
                DescriptionrichTextBox.Text = selectedRow.Cells["Description"].Value.ToString();
                RecieveDatetextBox.Text = selectedRow.Cells["Receive_Date"].Value.ToString();
                DeliveryDatetextBox.Text = selectedRow.Cells["Delivery_Date"].Value.ToString();
                PlatfromtextBox.Text = selectedRow.Cells["Platform"].Value.ToString();
                CategorytextBox.Text = selectedRow.Cells["Category"].Value.ToString();

            }
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchtextBox.Text))
            {
                LoadDeviceMaitenance();
                return;
            }

            var SearchedDevices = _context
               .DeviceMaintenances
               .Where(d => d.DeviceSerialNo.Contains(SearchtextBox.Text))
               .Where(d => d.BranchId == user.BranchId)
               .Where(d => d.isFixed == false)
               .Include(d => d.Category)
               .Include(d => d.Platform)
               .Select(d => new
               {
                   ID = d.DeviceMaintenanceId,
                   Serial_No = d.DeviceSerialNo,
                   Price = d.Price,
                   Description = d.Description,
                   Receive_Date = d.ReceiveDate,
                   Delivery_Date = d.DeliveryDate,
                   Platform = d.Platform.PlatformName,
                   Category = d.Category.CategoryName
               })
               .ToList();

            dataGridView1.DataSource = SearchedDevices;
        }

        private void insertDevice_Click(object sender, EventArgs e)
        {
            var device = _context.DeviceMaintenances
                .FirstOrDefault(d=>d.DeviceMaintenanceId== _DeviceID && !d.isFixed);
            if (device != null) {

                InvoiceItem invoiceItem = new InvoiceItem()
                {
                    ItemQuantity = 1,
                    DeviceMaintenanceId = device.DeviceMaintenanceId,
                    InvoiceItemPrice = device.Price,
                    InvoiceItemTotal = device.Price ,
                };
                _Invoice.invoiceItems.Add(invoiceItem); 
                if (_Invoice.InvoiceId == 0)
                {
                    _context.Invoices.Add(_Invoice);
                }
                else
                {
                    _context.Invoices.Update(_Invoice); 
                }
                _context.SaveChanges();
                InvoiceView InvoiceViewPage = new InvoiceView();
                InvoiceViewPage.Show();
                this.Close();
            }
        }
    }
}
