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
    public partial class CategoryViewControl : Form
    {
        PlaystationStoreContext _context;
        int _CategoryID;
        public CategoryViewControl()
        {
            InitializeComponent();
            _context = new PlaystationStoreContext();
        }

        private void LoadCategoriesData()
        {
            try
            {
                var Categories = _context.Categories
                    .Select(p => new { ID = p.CategoryId, Category = p.CategoryName })
                    .ToList();
                dataGridView1.DataSource = Categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Categories: {ex.Message}");
            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var CategorymName = categoryTextBox.Text;

                if (!string.IsNullOrEmpty(CategorymName))
                {
                    var newCategory = new Category
                    {
                        CategoryName = CategorymName
                    };

                    _context.Categories.Add(newCategory);
                    _context.SaveChanges(); // Save changes to the database

                    LoadCategoriesData(); // Reload platforms to update the ComboBox

                    // Reset form fields
                    categoryTextBox.Clear();
                    MessageBox.Show("Category added successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Category name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];

                // Retrieve data from the selected row
                categoryTextBox.Text = selectedRow.Cells["Category"].Value?.ToString();

                // Retrieve the Product ID from the selected row
                int CategoryID = (int)selectedRow.Cells["ID"].Value;
                _CategoryID = CategoryID;
            }
        }

        private void updateCategory_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(categoryTextBox.Text))
                {
                    var Category = _context.Categories.
                        SingleOrDefault(c => c.CategoryId == _CategoryID);

                    if (Category != null)
                    {
                        Category.CategoryName = categoryTextBox.Text;

                        _context.Categories.Update(Category); 
                        _context.SaveChanges();

                        LoadCategoriesData();

                        categoryTextBox.Clear();

                        MessageBox.Show("Category updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Category not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Category ID and name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var category = _context.Categories.FirstOrDefault(c => c.CategoryId == _CategoryID);

                if (category != null)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();

                    // Refresh ComboBox data
                    LoadCategoriesData();

                    // Reset form fields
                    categoryTextBox.Clear();

                    MessageBox.Show("Category deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Category not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CategoryViewControl_Load(object sender, EventArgs e)
        {
            LoadCategoriesData();
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
