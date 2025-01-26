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
    public partial class PlatformViewControl : Form
    {
        PlaystationStoreContext _context;
        int _PlatformID;
        public PlatformViewControl()
        {
            InitializeComponent();
            _context = new PlaystationStoreContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];

                // Retrieve data from the selected row
                platformTextBox.Text = selectedRow.Cells["Platform"].Value?.ToString();

                // Retrieve the Product ID from the selected row
                int PlatformID = (int)selectedRow.Cells["ID"].Value;
                _PlatformID = PlatformID;
            }
        }
        private void LoadPlatformsforData()
        {
            try
            {
                var platforms = _context.Platforms
                    .Select(p => new { ID = p.PlatformId, Platform = p.PlatformName })
                    .ToList();
                dataGridView1.DataSource = platforms;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading platforms: {ex.Message}");
            }
        }
        private void PlatformViewControl_Load(object sender, EventArgs e)
        {
            LoadPlatformsforData();
        }

        private void AddPlatform_Click(object sender, EventArgs e)
        {
            try
            {
                var platformName = platformTextBox.Text;

                if (!string.IsNullOrEmpty(platformName))
                {
                    var newPlatform = new Platform
                    {
                        PlatformName = platformName
                    };

                    _context.Platforms.Add(newPlatform);
                    _context.SaveChanges(); // Save changes to the database

                    LoadPlatformsforData(); // Reload platforms to update the ComboBox

                    // Reset form fields
                    platformTextBox.Clear();

                    MessageBox.Show("Platform added successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a valid platform name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void updatePlatform_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(platformTextBox.Text))
                {
                    var platform = _context.Platforms.
                        SingleOrDefault(p => p.PlatformId == _PlatformID);

                    if (platform != null)
                    {
                        platform.PlatformName = platformTextBox.Text;
                        _context.Platforms.Update(platform); 
                        _context.SaveChanges();
                        LoadPlatformsforData();
                        platformTextBox.Clear();
                        MessageBox.Show("Platform updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Platform not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid platform ID and name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1?.Rows[e.RowIndex];

                // Retrieve data from the selected row
                platformTextBox.Text = selectedRow.Cells["Platform"].Value?.ToString();

                // Retrieve the Product ID from the selected row
                int PlatformID = (int)selectedRow.Cells["ID"].Value;
                _PlatformID = PlatformID;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var platform = _context.Platforms.FirstOrDefault(p => p.PlatformId == _PlatformID);

                if (platform != null)
                {
                    _context.Platforms.Remove(platform);
                    _context.SaveChanges();

                    // Refresh ComboBox data
                    LoadPlatformsforData();

                    // Reset form fields
                    platformTextBox.Clear();

                    MessageBox.Show("Platform deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Platform not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
