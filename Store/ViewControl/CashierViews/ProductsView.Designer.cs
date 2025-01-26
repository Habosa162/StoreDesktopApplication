namespace Store.ViewControl
{
    partial class ProductsView
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
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            ProductcomboBox = new ComboBox();
            QuantitytextBox = new TextBox();
            dataGridView1 = new DataGridView();
            Price = new Label();
            PricetextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(617, 119);
            button1.Name = "button1";
            button1.Size = new Size(111, 47);
            button1.TabIndex = 32;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(27, 55);
            label5.Name = "label5";
            label5.Size = new Size(106, 19);
            label5.TabIndex = 31;
            label5.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(274, 55);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 29;
            label4.Text = "Quantity";
            // 
            // ProductcomboBox
            // 
            ProductcomboBox.FormattingEnabled = true;
            ProductcomboBox.Location = new Point(139, 54);
            ProductcomboBox.Name = "ProductcomboBox";
            ProductcomboBox.Size = new Size(129, 23);
            ProductcomboBox.TabIndex = 26;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(342, 55);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(133, 23);
            QuantitytextBox.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(782, 273);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Price.Location = new Point(481, 58);
            Price.Name = "Price";
            Price.Size = new Size(43, 19);
            Price.TabIndex = 35;
            Price.Text = "Price";
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(534, 55);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(140, 23);
            PricetextBox.TabIndex = 36;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PricetextBox);
            Controls.Add(Price);
            Controls.Add(dataGridView1);
            Controls.Add(QuantitytextBox);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ProductcomboBox);
            Name = "ProductsView";
            Text = "ProductsView";
            Load += ProductsView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label label4;
        private ComboBox ProductcomboBox;
        private TextBox QuantitytextBox;
        private DataGridView dataGridView1;
        private Label Price;
        private TextBox PricetextBox;
    }
}