namespace Store.ViewControl.CashierViews
{
    partial class InventoryView
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
            Search = new Button();
            SerachtextBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(942, 417);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Search
            // 
            Search.BackColor = Color.YellowGreen;
            Search.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            Search.Location = new Point(694, 88);
            Search.Name = "Search";
            Search.Size = new Size(102, 37);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // SerachtextBox
            // 
            SerachtextBox.Location = new Point(496, 96);
            SerachtextBox.Name = "SerachtextBox";
            SerachtextBox.Size = new Size(183, 23);
            SerachtextBox.TabIndex = 2;
            SerachtextBox.TextChanged += SerachtextBox_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            button1.Location = new Point(802, 88);
            button1.Name = "button1";
            button1.Size = new Size(88, 37);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // InventoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 560);
            Controls.Add(button1);
            Controls.Add(SerachtextBox);
            Controls.Add(Search);
            Controls.Add(dataGridView1);
            Name = "InventoryView";
            Text = "InventoryView";
            Load += InventoryView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Search;
        private TextBox SerachtextBox;
        private Button button1;
    }
}