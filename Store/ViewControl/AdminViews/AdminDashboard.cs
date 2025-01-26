using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
using Store.ViewControl.AdminViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.ViewControl
{
    public partial class AdminDashboard : Form
    {
        PlaystationStoreContext context;
        public AdminDashboard()
        {
            InitializeComponent();
            context = new PlaystationStoreContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadBranchDataAtComboBox()
        {
            var branches = context.Branches
                .Select(b => new { ID = b.BranchId, Name = b.BranchName })
                .ToList();

            //comboBox1.DataSource = branches;
            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = "ID";
        }

        private void LoadPlatformDataAtComboBox()
        {
            var platforms = context.Platforms
                .Select(p => new { ID = p.PlatformId, Name = p.PlatformName })
                .ToList();
            //comboBox2.DataSource = platforms;
            //comboBox2.DisplayMember = "Name";
            //comboBox2.ValueMember = "ID";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadBranchDataAtComboBox();
            LoadPlatformDataAtComboBox();
            var allProducts = context?.Products
                .Include(c => c.Category)
                .Include(pla => pla.Platform)
                .Include(b => b.Branch)
                .Select(p => new
                {
                    ID = p.ProductId,
                    Name = p.ProductName,
                    Category = p.Category.CategoryName,
                    StockQuantity = p.StockQuantity,
                    Platform = p.Platform.PlatformName,
                    Branch = p.Branch.BranchName
                }).ToList();

            //dataGridView1.DataSource = allProducts;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            AddProductViewControl page = new AddProductViewControl();
            page.ShowDialog();
        }

        private void platforms_Click(object sender, EventArgs e)
        {
            PlatformViewControl platformViewControl = new PlatformViewControl();
            platformViewControl.ShowDialog();
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            CategoryViewControl categoryViewControl = new CategoryViewControl();
            categoryViewControl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserViewControl userViewControl = new UserViewControl();
            userViewControl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BranchesViewControl branchesViewControl = new BranchesViewControl();
            branchesViewControl.ShowDialog();   
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var productName = productNameComboBox.Text;
        //    var productPrice = productPriceTextBox.Text;
        //    var productQuantity = productQuantityTextBox.Text;
        //    var productPlatform = comboBox2.SelectedValue;
        //    var productBranch = comboBox1.SelectedValue;
        //var productBranch = 
        //context.Products.Add(new {
        //    ProductName = productName ,
        //    ProductPrice = productPrice ,
        //    StockQuantity = productQuantity ,
        //    BranchId = 

        //})
        //}



        //public string ProductName { get; set; }
        //public double? ProductPrice { get; set; }
        //public int StockQuantity { get; set; }


        //[ForeignKey("Branch")]
        //public int BranchId { get; set; }

        //[ForeignKey("Platform")]
        //public int PlatformId { get; set; }

        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
    }
}
