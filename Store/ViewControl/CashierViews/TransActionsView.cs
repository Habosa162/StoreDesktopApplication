using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
using Store.Models.InvoiceModels;
using Store.Models.TransactionModel;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Store.ViewControl.CashierViews
{
    public partial class TransActionsView : Form
    {
        PlaystationStoreContext _context = new PlaystationStoreContext();
        CurrentUser user = CurrentUser.Instance;
        public TransActionsView()
        {
            InitializeComponent();
        }

        void LoadTransactionsData()
        {
             var transactions = _context
                .Transactions
                .Where(t => t.BranchID == user.BranchId)
                .Where(t=>t.Date <=  DateTime.Now)
                .Include(t => t.Branch)
                .Include(t => t.TransactionType)
                .Select(transaction => new
                {
                    ID = transaction.Id,
                    type = transaction.TransactionType.type,
                    Amount = transaction.value,
                    Date = transaction.Date,
                    Description = transaction.Description
                }).ToList(); 

            dataGridView1.DataSource = transactions;
        }
        private void LoadTransactionTypeComboBox()
        {
            try
            {
                var TransActionTypes = _context.TransactionTypes
                    .Select(type => new { ID = type.Id, Name = type.type })
                    .ToList();
                TypeComboBox.DataSource = TransActionTypes;
                TypeComboBox.DisplayMember = "Name";
                TypeComboBox.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading TransActionTypes: {ex.Message}");
            }
        }
        private void TransActionsView_Load(object sender, EventArgs e)
        {
            LoadTransactionTypeComboBox();
            LoadTransactionsData(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Transaction transaction = new Transaction()
            {
                BranchID = user.BranchId,
                Description = DescRichTextBox.Text,
                Date = DateTime.Now,
                value = double.Parse(AmountTextBox.Text),
                TransactionTypeID = (int)TypeComboBox.SelectedValue,
                username = user.UserName
            };
            _context.Transactions.Add(transaction);

            _context.SaveChanges();
            ResetInput(); 
            LoadTransactionsData(); 
        }
        void ResetInput()
        {
            DescRichTextBox.Text = "";
            AmountTextBox.Text = ""; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
