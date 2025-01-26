using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
using Store.Models.ProductModels;
using Store.Models.User;
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
    public partial class UserViewControl : Form
    {
        PlaystationStoreContext _context;
        string _userName;
        public UserViewControl()
        {
            InitializeComponent();
            _context = new PlaystationStoreContext();
        }
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

        private void LoadPlatformsforData()
        {
            try
            {
                var Roles = _context.Roles
                    .Select(role => new { ID = role.ID, Name = role.Name })
                    .ToList();
                PermessionComboBox.DataSource = Roles;
                PermessionComboBox.DisplayMember = "Name";
                PermessionComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Roles: {ex.Message}");
            }
        }

        private void LoadUsersData()
        {
            try
            {
                var systemUsers = _context.SystemUsers
                    .Include(u => u.Branch)
                    .Include(u => u.Role)
                    .Select(user => new
                    {
                        username = user.UserName,
                        Password = user.PassWord,
                        Branch = user.Branch.BranchName,
                        Permession = user.Role.Name,
                        isActive = user.isActive
                    })
                    .ToList();
                dataGridView1.DataSource = systemUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Categories: {ex.Message}");
            }
        }

        private void UserViewControl_Load(object sender, EventArgs e)
        {
            LoadUsersData();
            LoadPlatformsforData();
            LoadBranchesforDataAtComboBox();
        }

        private void ResetForm()
        {
            usernameTextBox.Text = "";
            PasstextBox.Text = "";
            PermessionComboBox.SelectedValue = -1;
            BranchComboBox.SelectedValue = -1;
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                var _username = usernameTextBox.Text;
                var _password = PasstextBox.Text;

                if (PermessionComboBox.SelectedValue is int roleID &&
                    BranchComboBox.SelectedValue is int branchId)
                {
                    var systemUser = new SystemUser
                    {
                        UserName = _username,
                        PassWord = _password,
                        isActive = isActive.Checked,
                        BranchId = branchId,
                        RoleId = roleID
                    };

                    _context.SystemUsers.Add(systemUser);
                    _context.SaveChanges(); // Ensure you save changes to the context

                    LoadUsersData();

                    // Reset the form for the next input
                    ResetForm();

                    MessageBox.Show("User inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Please select valid values for Role and Branch.");
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
                usernameTextBox.Text = selectedRow.Cells["username"].Value?.ToString();
                PasstextBox.Text = selectedRow.Cells["Password"].Value?.ToString();
                isActive.Checked = (bool)selectedRow.Cells["isActive"].Value;
                PermessionComboBox.SelectedValue = selectedRow.Cells["Permession"]?.Value;
                BranchComboBox.SelectedValue = selectedRow.Cells["Branch"]?.Value;

                string username = selectedRow.Cells["username"].Value?.ToString();
                _userName = username;
            }
        }

        private void updateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(usernameTextBox.Text) &&
                    !string.IsNullOrEmpty(PasstextBox.Text) &&
                    PermessionComboBox.SelectedValue is int roleID &&
                    BranchComboBox.SelectedValue is int branchId)
                {
                    var user = _context.SystemUsers.FirstOrDefault(u => u.UserName == _userName);

                    if (user != null)
                    {
                        user.UserName = usernameTextBox.Text;
                        user.PassWord = PasstextBox.Text;
                        user.isActive = isActive.Checked; 
                        user.BranchId = branchId;
                        user.RoleId = roleID;

                        _context.SystemUsers.Update(user);
                        _context.SaveChanges();

                        LoadUsersData();
                        ResetForm();

                        MessageBox.Show("User updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields and select valid values for Role and Branch.");
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
                // Retrieve the user by username (or use an ID if available)
                var user = _context.SystemUsers.FirstOrDefault(u => u.UserName == _userName);

                if (user != null)
                {
                    _context.SystemUsers.Remove(user);

                    _context.SaveChanges();

                    LoadUsersData();

                    ResetForm();

                    MessageBox.Show("User deleted successfully!");
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



    }
}
