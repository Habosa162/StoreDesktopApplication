namespace Store.ViewControl
{
    partial class InvoiceView
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            CheckOutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 308);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(241, 12);
            button1.Name = "button1";
            button1.Size = new Size(163, 53);
            button1.TabIndex = 24;
            button1.Text = "Device Maintenance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(419, 12);
            button3.Name = "button3";
            button3.Size = new Size(123, 53);
            button3.TabIndex = 26;
            button3.Text = "Customer Info";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(96, 12);
            button4.Name = "button4";
            button4.Size = new Size(130, 53);
            button4.TabIndex = 27;
            button4.Text = "Product";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CheckOutBtn
            // 
            CheckOutBtn.BackColor = Color.SteelBlue;
            CheckOutBtn.Cursor = Cursors.Hand;
            CheckOutBtn.FlatAppearance.BorderSize = 5;
            CheckOutBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutBtn.ForeColor = SystemColors.ControlLightLight;
            CheckOutBtn.Location = new Point(559, 81);
            CheckOutBtn.Name = "CheckOutBtn";
            CheckOutBtn.Size = new Size(125, 58);
            CheckOutBtn.TabIndex = 28;
            CheckOutBtn.Text = "CheckOut";
            CheckOutBtn.UseVisualStyleBackColor = false;
            CheckOutBtn.Click += btnGeneratePDF_Click;
            // 
            // InvoiceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 447);
            Controls.Add(CheckOutBtn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "InvoiceView";
            Text = "InvoiceView";
            Load += InvoiceView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button CheckOutBtn;
    }
}