using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
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

namespace Store.ViewControl.AdminViews
{
    public partial class AddProductViewControl : Form
    {
        PlaystationStoreContext _context;
        int ProductID;
        //Ctor
        public AddProductViewControl()
        {
            InitializeComponent();
            _context = new PlaystationStoreContext();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Load Products from the Context
        private void LoadProdutsData()
        {
            var AllBranchesProducts = _context.Products
                .Include(p => p.Branch)
                .Include(p => p.Category)
                .Include(p => p.Platform)
                .Include(p=>p.Condition)
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
                    Condition = p.Condition.condition
                }).ToList();
            dataGridView1.DataSource = AllBranchesProducts;
        }


        private void LoadConditionsforDataAtComboBox()
        {
            try
            {
                var conditions = _context.Conditions
                    .Select(c => new { ID = c.ConditionId, Name = c.condition})
                    .ToList();

                ConditionComboBox.DataSource = conditions;
                ConditionComboBox.DisplayMember = "Name";
                ConditionComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading conditions: {ex.Message}");
            }
        }


        //Data FOR COMBOX
        private void LoadBranchesforDataAtComboBox()
        {
            try
            {
                var branches = _context.Branches
                    .Select(b => new { ID = b.BranchId, Name = b.BranchName })
                    .ToList();

                BranchComboBox.DataSource = branches;
                BranchComboBox.DisplayMember = "Name";
                BranchComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading branches: {ex.Message}");
            }
        }
        private void LoadCategoryDataAtComboBox()
        {
            try
            {
                var categories = _context.Categories
                    .Select(c => new { ID = c.CategoryId, Name = c.CategoryName })
                    .ToList();

                CategoryComboBox.DataSource = categories;
                CategoryComboBox.DisplayMember = "Name";
                CategoryComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading categories: {ex.Message}");
            }
        }
        private void LoadPlatformsforDataAtComboBox()
        {
            try
            {
                var platforms = _context.Platforms
                    .Select(p => new { ID = p.PlatformId, Name = p.PlatformName })
                    .ToList();

                PlatFormComboBox.DataSource = platforms;
                PlatFormComboBox.DisplayMember = "Name";
                PlatFormComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading platforms: {ex.Message}");
            }
        }


        //RESET THE FROM 
        void ResetForm()
        {
            productNameTextBox.Clear();
            serialNoTextBox.Clear();
            productPriceTextBox.Clear();
            productQuantityTextBox.Clear();
            PlatFormComboBox.SelectedIndex = -1;
            CategoryComboBox.SelectedIndex = -1;
            BranchComboBox.SelectedIndex = -1;
            ConditionComboBox.SelectedIndex = -1;
        }
        
        //When the Form is Laoded 
        private void AddProductViewControl_Load(object sender, EventArgs e)
        {
            LoadProdutsData();
            LoadPlatformsforDataAtComboBox();
            LoadCategoryDataAtComboBox();
            LoadBranchesforDataAtComboBox();
            LoadConditionsforDataAtComboBox(); 
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var productName = productNameTextBox.Text;
                var productSerialNo = serialNoTextBox.Text;

                if (int.TryParse(productPriceTextBox.Text, out int productPrice) &&
                    int.TryParse(productQuantityTextBox.Text, out int productQuantity))
                {
                    if (PlatFormComboBox.SelectedValue is int platformId &&
                        CategoryComboBox.SelectedValue is int categoryId &&
                        BranchComboBox.SelectedValue is int branchId &&
                        ConditionComboBox.SelectedValue is int condID
                        )
                    {
                        var newProduct = new Product
                        {
                            ProductName = productName,
                            SerialNo = productSerialNo,
                            ProductPrice = productPrice,
                            StockQuantity = productQuantity,
                            BranchId = branchId,
                            PlatformId = platformId,
                            CategoryId = categoryId,
                            ConditionId = condID
                        };

                        _context.Products.Add(newProduct);
                        _context.SaveChanges(); // Ensure you save changes to the context

                        LoadProdutsData();

                        // Reset the form for the next input
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Please select valid values for Platform, Category, and Branch.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for price and quantity.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            var Product = _context.Products.FirstOrDefault(p => p.ProductId == ProductID);

            if (Product != null)
            {
                Product.ProductName = productNameTextBox.Text;
                Product.SerialNo = serialNoTextBox.Text;
                Product.ProductPrice = int.Parse(productPriceTextBox.Text);
                Product.StockQuantity = int.Parse(productQuantityTextBox.Text);
                Product.BranchId = (int)BranchComboBox.SelectedValue;
                Product.CategoryId = (int)CategoryComboBox.SelectedValue;
                Product.PlatformId = (int)PlatFormComboBox.SelectedValue;
                Product.ConditionId = (int)ConditionComboBox.SelectedValue;
                _context.Products.Update(Product);
                _context.SaveChanges();
                LoadProdutsData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Product Data Not Found");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];
                int _productId = (int)selectedRow.Cells["ID"].Value;
                ProductID = _productId;

                // Retrieve data from the selected row
                productNameTextBox.Text = selectedRow.Cells["Name"].Value?.ToString();
                serialNoTextBox.Text = selectedRow.Cells["Serial_Number"].Value?.ToString();
                productPriceTextBox.Text = selectedRow.Cells["Price"].Value?.ToString();
                productQuantityTextBox.Text = selectedRow.Cells["Quantity"].Value?.ToString();

                // Set the SelectedValue of the ComboBoxes
                var curentProduct  = _context.Products.FirstOrDefault(p => p.ProductId == _productId); 
                BranchComboBox.SelectedValue = curentProduct.BranchId;
                PlatFormComboBox.SelectedValue = curentProduct.PlatformId;
                CategoryComboBox.SelectedValue = curentProduct.CategoryId;
                ConditionComboBox.SelectedValue = curentProduct.ConditionId;  
                // Retrieve the Product ID from the selected row
             
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var Product = _context.Products
                .FirstOrDefault(p => p.ProductId == ProductID);

            if (Product != null)
            {
                ResetForm();
                _context.Products.Remove(Product);
                _context.SaveChanges();
                LoadProdutsData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Product Not Found !");
            }
        }

        private void PlatFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
