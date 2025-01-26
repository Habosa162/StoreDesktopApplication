namespace Store.ViewControl.AdminViews
{
    partial class CategoryViewControl
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
            updateCategory = new Button();
            AddCategory = new Button();
            categoryTextBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Brown;
            DeleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(631, 83);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(97, 48);
            DeleteBtn.TabIndex = 51;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // updateCategory
            // 
            updateCategory.BackColor = Color.Chocolate;
            updateCategory.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            updateCategory.ForeColor = SystemColors.ControlLightLight;
            updateCategory.Location = new Point(515, 83);
            updateCategory.Name = "updateCategory";
            updateCategory.Size = new Size(110, 48);
            updateCategory.TabIndex = 50;
            updateCategory.Text = "Update";
            updateCategory.UseVisualStyleBackColor = false;
            updateCategory.Click += updateCategory_Click;
            // 
            // AddCategory
            // 
            AddCategory.BackColor = Color.YellowGreen;
            AddCategory.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            AddCategory.ForeColor = SystemColors.ControlLightLight;
            AddCategory.Location = new Point(407, 83);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(102, 48);
            AddCategory.TabIndex = 49;
            AddCategory.Text = "Create";
            AddCategory.UseVisualStyleBackColor = false;
            AddCategory.Click += AddCategory_Click;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(167, 59);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(160, 23);
            categoryTextBox.TabIndex = 48;
            categoryTextBox.TextChanged += categoryTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 47;
            label1.Text = "Category Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(1, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 290);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // CategoryViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(updateCategory);
            Controls.Add(AddCategory);
            Controls.Add(categoryTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CategoryViewControl";
            Text = "CategoryViewControl";
            Load += CategoryViewControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button updateCategory;
        private Button AddCategory;
        private TextBox categoryTextBox;
        private Label label1;
        private DataGridView dataGridView1;
    }
}