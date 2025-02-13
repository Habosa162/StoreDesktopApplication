namespace Store.ViewControl.AdminViews
{
    partial class AddProductViewControl
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
            DeleteBtn = new Button();
            button2 = new Button();
            AddProduct = new Button();
            PlatFormComboBox = new ComboBox();
            label5 = new Label();
            BranchComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            productQuantityTextBox = new TextBox();
            productPriceTextBox = new TextBox();
            label2 = new Label();
            productNameTextBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            CategoryComboBox = new ComboBox();
            label7 = new Label();
            serialNoTextBox = new TextBox();
            label8 = new Label();
            ConditionComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Brown;
            DeleteBtn.ForeColor = SystemColors.ButtonHighlight;
            DeleteBtn.Location = new Point(728, 150);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(104, 51);
            DeleteBtn.TabIndex = 27;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(600, 150);
            button2.Name = "button2";
            button2.Size = new Size(114, 51);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += update_Click;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.YellowGreen;
            AddProduct.ForeColor = SystemColors.ButtonHighlight;
            AddProduct.Location = new Point(474, 150);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(107, 51);
            AddProduct.TabIndex = 25;
            AddProduct.Text = "Create New";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // PlatFormComboBox
            // 
            PlatFormComboBox.FormattingEnabled = true;
            PlatFormComboBox.Location = new Point(455, 17);
            PlatFormComboBox.Name = "PlatFormComboBox";
            PlatFormComboBox.Size = new Size(182, 25);
            PlatFormComboBox.TabIndex = 24;
            PlatFormComboBox.SelectedIndexChanged += PlatFormComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(374, 20);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 23;
            label5.Text = "Platform";
            // 
            // BranchComboBox
            // 
            BranchComboBox.FormattingEnabled = true;
            BranchComboBox.Location = new Point(455, 60);
            BranchComboBox.Name = "BranchComboBox";
            BranchComboBox.Size = new Size(182, 25);
            BranchComboBox.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(374, 63);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 21;
            label4.Text = "Branch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(14, 153);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 20;
            label3.Text = "Quantity";
            // 
            // productQuantityTextBox
            // 
            productQuantityTextBox.Location = new Point(127, 150);
            productQuantityTextBox.Name = "productQuantityTextBox";
            productQuantityTextBox.Size = new Size(182, 25);
            productQuantityTextBox.TabIndex = 19;
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(127, 97);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(182, 25);
            productPriceTextBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(14, 101);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 17;
            label2.Text = "Price";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(127, 17);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(182, 25);
            productNameTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 15;
            label1.Text = "Product Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(1, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(912, 289);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(374, 107);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 28;
            label6.Text = "Category";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(455, 103);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(182, 25);
            CategoryComboBox.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(14, 63);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 30;
            label7.Text = "Serial No";
            // 
            // serialNoTextBox
            // 
            serialNoTextBox.Location = new Point(127, 54);
            serialNoTextBox.Name = "serialNoTextBox";
            serialNoTextBox.Size = new Size(182, 25);
            serialNoTextBox.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(658, 15);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 32;
            label8.Text = "Condition";
            // 
            // ConditionComboBox
            // 
            ConditionComboBox.FormattingEnabled = true;
            ConditionComboBox.Location = new Point(728, 12);
            ConditionComboBox.Name = "ConditionComboBox";
            ConditionComboBox.Size = new Size(182, 25);
            ConditionComboBox.TabIndex = 33;
            // 
            // AddProductViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(ConditionComboBox);
            Controls.Add(label8);
            Controls.Add(serialNoTextBox);
            Controls.Add(label7);
            Controls.Add(CategoryComboBox);
            Controls.Add(label6);
            Controls.Add(DeleteBtn);
            Controls.Add(button2);
            Controls.Add(AddProduct);
            Controls.Add(PlatFormComboBox);
            Controls.Add(label5);
            Controls.Add(BranchComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(productQuantityTextBox);
            Controls.Add(productPriceTextBox);
            Controls.Add(label2);
            Controls.Add(productNameTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "AddProductViewControl";
            Text = "AddProductViewControl";
            Load += AddProductViewControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button button2;
        private Button AddProduct;
        private ComboBox PlatFormComboBox;
        private Label label5;
        private ComboBox BranchComboBox;
        private Label label4;
        private Label label3;
        private TextBox productQuantityTextBox;
        private TextBox productPriceTextBox;
        private Label label2;
        private TextBox productNameTextBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private ComboBox CategoryComboBox;
        private Label label7;
        private TextBox serialNoTextBox;
        private Label label8;
        private ComboBox ConditionComboBox;
    }
}