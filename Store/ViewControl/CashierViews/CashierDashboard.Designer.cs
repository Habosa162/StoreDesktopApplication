namespace Store.ViewControl
{
    partial class CashierDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateInvoiceBtn = new Button();
            AddProductBtn = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Transactions = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CreateInvoiceBtn
            // 
            CreateInvoiceBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            CreateInvoiceBtn.Location = new Point(489, 51);
            CreateInvoiceBtn.Margin = new Padding(4, 3, 4, 3);
            CreateInvoiceBtn.Name = "CreateInvoiceBtn";
            CreateInvoiceBtn.Size = new Size(117, 61);
            CreateInvoiceBtn.TabIndex = 0;
            CreateInvoiceBtn.Text = "Create Invoice";
            CreateInvoiceBtn.UseVisualStyleBackColor = true;
            CreateInvoiceBtn.Click += CreateInvoiceBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            AddProductBtn.Location = new Point(369, 51);
            AddProductBtn.Margin = new Padding(4, 3, 4, 3);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(112, 61);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.Text = "Inventory";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 194);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(788, 317);
            dataGridView1.TabIndex = 2;
            dataGridView1.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(158, 51);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 3;
            button1.Text = "Device Maintenance ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Transactions
            // 
            Transactions.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Transactions.Location = new Point(40, 51);
            Transactions.Margin = new Padding(4, 3, 4, 3);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(110, 62);
            Transactions.TabIndex = 4;
            Transactions.Text = "Transactions";
            Transactions.UseVisualStyleBackColor = true;
            Transactions.Click += Transactions_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.Location = new Point(614, 51);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(116, 61);
            button2.TabIndex = 5;
            button2.Text = "Print Day Summary";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 471);
            Controls.Add(button2);
            Controls.Add(Transactions);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(AddProductBtn);
            Controls.Add(CreateInvoiceBtn);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            Click += button1_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateInvoiceBtn;
        private Button AddProductBtn;
        private DataGridView dataGridView1;
        private Button button1;
        private Button Transactions;
        private Button button2;
    }
}