using Store.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Models;
using Store.Models.InvoiceModels;

namespace Store.ViewControl
{
    public partial class CustomerInfoView : Form
    {
        PlaystationStoreContext _context = new PlaystationStoreContext();
        string Customer_Phone_global;
        Invoice _invoice = SingletonInvoice.invoice;
        public CustomerInfoView()
        {
            InitializeComponent();
        }
        void LoadCustomers()
        {
            var customers = _context.Customers.Select(c => new
            {
                Phone_number = c.phoneNo,
                Name = c.Name,

            }).ToList();
            dataGridView1.DataSource = customers;
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            var customers = _context.Customers
                .Where(c => c.phoneNo.Contains(SearchtextBox.Text))
                .Select(c => new
                {
                    Phone_number = c.phoneNo,
                    Name = c.Name,
                }).ToList();
            dataGridView1.DataSource = customers;
        }


        private void CustomerInfoView_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];

                NumbertextBox.Text = selectedRow.Cells["Phone_number"].Value?.ToString();
                Customer_Phone_global = NametextBox.Text = selectedRow.Cells["Name"].Value?.ToString();
            }
        }

        private void NewCustomerBtn_Click(object sender, EventArgs e)
        {
            var phNumber = NumbertextBox.Text;
            var Customer = _context.Customers.FirstOrDefault(c => c.phoneNo == phNumber);
            if (Customer == null)
            {
                var CustObj = new Customer
                {
                    phoneNo = phNumber,
                    Name = NametextBox.Text,    
                };
                _context.Customers.Add(CustObj);
                _context.SaveChanges();
                LoadCustomers();
                if (_invoice.invoiceItems.Count > 0) { 
                    _invoice.CustomerPhoneNumber = phNumber;
                    InvoiceView InvoiceViewPage = new InvoiceView();
                    InvoiceViewPage.Show();
                    this.Close();
                }
            }
            else
            {
                if (_invoice.invoiceItems.Count > 0)
                {
                    _invoice.CustomerPhoneNumber = phNumber;
                    InvoiceView InvoiceViewPage = new InvoiceView();
                    InvoiceViewPage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Isert Items To Invoice First"); 
                }
            }
        }

    }
}
