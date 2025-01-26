using Microsoft.EntityFrameworkCore;
using Store.Migrations;
using Store.Models.Context;
using Store.Models.InvoiceModels;
using Store.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.ViewControl
{
    public partial class ProductsView : Form
    {
        PlaystationStoreContext _context = new PlaystationStoreContext();
        int _ProductID;
        Invoice invoice = SingletonInvoice.invoice;
        CurrentUser currentuser = CurrentUser.Instance;

        public ProductsView()
        {
            InitializeComponent();
            //_Invoice = invoice;
        }

        private void LoadProductsDataGrid()
        {
            var products = _context.Products
                .Include(p => p.Branch)
                .Include(p => p.Category)
                .Include(p => p.Platform)
                .Select(p => new
                {
                    ID = p.ProductId,
                    Name = p.ProductName,
                    Price = p.ProductPrice,
                    Stock = p.StockQuantity,
                    Serial_Number = p.SerialNo,
                    Branch = p.Branch.BranchName,
                    Category = p.Category.CategoryName,
                    Platform = p.Platform.PlatformName
                })
                .ToList();
            dataGridView1.DataSource = products;
        }

        void LoadProductsComboBox()
        {
            var products = _context.Products
                .Select(p => new { ID = p.ProductId, Name = p.ProductName }).ToList();

            ProductcomboBox.DataSource = products;
            ProductcomboBox.DisplayMember = "Name";
            ProductcomboBox.ValueMember = "ID";

        }




        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(QuantitytextBox.Text, out int quantityRequired);
            int.TryParse(PricetextBox.Text, out int priceRequired);


            var product = _context.Products
                .FirstOrDefault(p => p.ProductId == _ProductID && p.ProductPrice <= priceRequired && p.StockQuantity >= quantityRequired);

            if (product != null)
            {


                // Create a new invoice item and add it to the invoice
                var invoiceItem = new InvoiceItem()
                {
                    ProductId = product.ProductId,
                    ItemQuantity = quantityRequired,
                    InvoiceItemPrice = priceRequired,
                    InvoiceItemTotal = priceRequired * quantityRequired
                };

                //Add invoice Item to the invoice
                invoice.invoiceItems.Add(invoiceItem);
                 

                if (invoice.InvoiceId == 0)
                {
                    _context.Invoices.Add(invoice);
                }
                else
                {
                    _context.ChangeTracker.Clear(); 
                    _context.Invoices.Update(invoice);
                }

                _context.SaveChanges();
                InvoiceView InvoiceViewPage = new InvoiceView();
                InvoiceViewPage.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("No matching product found or insufficient stock.");
            }
        }



        private void ProductsView_Load(object sender, EventArgs e)
        {
            LoadProductsComboBox();
            LoadProductsDataGrid();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];
                _ProductID = (int)selectedRow.Cells["ID"].Value;

                // Set the SelectedValue of the ComboBoxes
                ProductcomboBox.SelectedValue = _ProductID;

                // Retrieve the Product ID from the selected row

            }
        }
    }
}
