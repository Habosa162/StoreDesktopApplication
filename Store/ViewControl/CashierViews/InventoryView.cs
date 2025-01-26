using Microsoft.EntityFrameworkCore;
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

namespace Store.ViewControl.CashierViews
{
    public partial class InventoryView : Form
    {
        private readonly PlaystationStoreContext _context;
        public InventoryView()
        {
            InitializeComponent();
            _context = new PlaystationStoreContext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var SearchText = SerachtextBox.Text;
            var SearchProducts = _context.Products
                 .Include(p => p.Category)
                 .Include(p => p.Platform)
                 .Where(p => p.ProductName
                 .ToLower()
                 .Contains(SearchText.ToLower()))
                 .Select(p => new
                 {
                     ID = p.ProductId,
                     Name = p.ProductName,
                     Price = p.ProductPrice,
                     Quantity = p.StockQuantity,
                     Serial_Number = p.SerialNo,
                     Branch = p.Branch.BranchName,
                     Platform = p.Platform.PlatformName,
                     Category = p.Category.CategoryName,
                 }).ToList();
            dataGridView1.DataSource = SearchProducts;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadProdutsData()
        {
            var AllBranchesProducts = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Platform)
                .Select(p => new
                {
                    ID = p.ProductId,
                    Name = p.ProductName,
                    Price = p.ProductPrice,
                    Quantity = p.StockQuantity,
                    Serial_Number = p.SerialNo,
                    Branch = p.Branch.BranchName,
                    Platform = p.Platform.PlatformName,
                    Category = p.Category.CategoryName,
                }).ToList();
            dataGridView1.DataSource = AllBranchesProducts;
        }
        private void InventoryView_Load(object sender, EventArgs e)
        {
            LoadProdutsData();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            var SearchText = SerachtextBox.Text;
            var SearchProducts = _context.Products
                 .Include(p => p.Category)
                 .Include(p => p.Platform)
                 .Where(p => p.ProductName
                 .ToLower()
                 .Contains(SearchText.ToLower()))
                 .Select(p => new
                 {
                     ID = p.ProductId,
                     Name = p.ProductName,
                     Price = p.ProductPrice,
                     Quantity = p.StockQuantity,
                     Serial_Number = p.SerialNo,
                     Branch = p.Branch.BranchName,
                     Platform = p.Platform.PlatformName,
                     Category = p.Category.CategoryName,
                 }).ToList();
            dataGridView1.DataSource = SearchProducts; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SerachtextBox.Text = ""; 
            LoadProdutsData();
        }
   
    }
}
