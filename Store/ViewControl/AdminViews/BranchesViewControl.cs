using Microsoft.EntityFrameworkCore;
using Store.Models;
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
    public partial class BranchesViewControl : Form
    {
        PlaystationStoreContext _context = new PlaystationStoreContext();
        int _BranchID;
        public BranchesViewControl()
        {
            InitializeComponent();
        }

        private void LoadBranchesData()
        {
            try
            {
                var Branches = _context.Branches
                    .Select(p => new { ID = p.BranchId, Branch = p.BranchName })
                    .ToList();
                dataGridView1.DataSource = Branches;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Branches: {ex.Message}");
            }
        }
        private void CreateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                var BranchName = BranchTextBox.Text;

                if (!string.IsNullOrEmpty(BranchName))
                {
                    var newBranch = new Branch
                    {
                        BranchName = BranchName
                    };

                    _context.Branches.Add(newBranch);
                    _context.SaveChanges(); // Save changes to the database

                    LoadBranchesData();

                    // Reset form fields
                    BranchTextBox.Clear();
                    MessageBox.Show("Branch added successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Branch name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void updateBranch_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(BranchTextBox.Text))
                {
                    var Branch = _context.Branches.
                        SingleOrDefault(b => b.BranchId == _BranchID);

                    if (Branch != null)
                    {
                        Branch.BranchName = BranchTextBox.Text;

                        _context.Branches.Update(Branch);
                        _context.SaveChanges();
                        LoadBranchesData();
                        BranchTextBox.Clear();
                        MessageBox.Show("Branch updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Branch not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Branch ID and name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                var branch = _context.Branches.FirstOrDefault(b => b.BranchId == _BranchID);

                if (branch != null)
                {
                    _context.Branches.Remove(branch);
                    _context.SaveChanges();

                    // Refresh ComboBox data
                    LoadBranchesData();

                    // Reset form fields
                    BranchTextBox.Clear();

                    MessageBox.Show("Branch deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Branch not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void BranchesViewControl_Load(object sender, EventArgs e)
        {
            LoadBranchesData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];

                // Retrieve data from the selected row
                BranchTextBox.Text = selectedRow.Cells["Branch"].Value?.ToString();

                // Retrieve the Product ID from the selected row
                int BranchID = (int)selectedRow.Cells["ID"].Value;
                _BranchID = BranchID;
            }
        }

       
    }
}
