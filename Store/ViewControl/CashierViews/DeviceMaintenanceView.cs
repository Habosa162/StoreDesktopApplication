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

namespace Store.ViewControl
{
    public partial class DeviceMaintenanceView : Form
    {
        PlaystationStoreContext _context = new PlaystationStoreContext();
        CurrentUser user = CurrentUser.Instance; 
        public DeviceMaintenanceView()
        {
            InitializeComponent();
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


        private void DeviceMaintenance_Load(object sender, EventArgs e)
        {
            LoadPlatformsforDataAtComboBox();
            LoadCategoryDataAtComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _SerialNo = SerialTextBox.Text;
            string _Description = DescRichTextBox.Text;

            int.TryParse(PricetextBox.Text, out int _Price);

            // Getting the Delivery Date
            DateTime? _DeliveryDate = DeliverydateTimePicker.Value;

            // Cast SelectedValue to int
            int _PlatformID = (int)PlatFormComboBox.SelectedValue;
            int _CategoryID = (int)CategoryComboBox.SelectedValue;

            try
            {
                _context.DeviceMaintenances.Add(new DeviceMaintenance()
                {
                    DeviceSerialNo = _SerialNo,
                    Description = _Description,
                    Price = _Price,
                    DeliveryDate = _DeliveryDate,
                    PlatformId = _PlatformID,
                    CategoryId = _CategoryID,
                    BranchId = user.BranchId
                });

                _context.SaveChanges(); // Save changes to persist the data
                MessageBox.Show("Device maintenance record added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



    }
}
