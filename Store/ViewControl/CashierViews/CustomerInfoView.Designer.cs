namespace Store.ViewControl
{
    partial class CustomerInfoView
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
            NametextBox = new TextBox();
            NumbertextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SearchtextBox = new TextBox();
            label3 = new Label();
            InsertCustomerBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 159);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 292);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(136, 19);
            NametextBox.Margin = new Padding(4, 3, 4, 3);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(138, 23);
            NametextBox.TabIndex = 1;
            // 
            // NumbertextBox
            // 
            NumbertextBox.Location = new Point(136, 52);
            NumbertextBox.Margin = new Padding(4, 3, 4, 3);
            NumbertextBox.Name = "NumbertextBox";
            NumbertextBox.Size = new Size(138, 23);
            NumbertextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(11, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 3;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(14, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 4;
            label2.Text = "Mobile Number";
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(318, 130);
            SearchtextBox.Margin = new Padding(4, 3, 4, 3);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(138, 23);
            SearchtextBox.TabIndex = 5;
            SearchtextBox.TextChanged += SearchtextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(259, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 6;
            label3.Text = "Search";
            // 
            // InsertCustomerBtn
            // 
            InsertCustomerBtn.BackColor = Color.SteelBlue;
            InsertCustomerBtn.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            InsertCustomerBtn.Location = new Point(346, 25);
            InsertCustomerBtn.Margin = new Padding(4, 3, 4, 3);
            InsertCustomerBtn.Name = "InsertCustomerBtn";
            InsertCustomerBtn.Size = new Size(99, 50);
            InsertCustomerBtn.TabIndex = 7;
            InsertCustomerBtn.Text = "Insert";
            InsertCustomerBtn.UseVisualStyleBackColor = false;
            InsertCustomerBtn.Click += NewCustomerBtn_Click;
            // 
            // CustomerInfoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 453);
            Controls.Add(InsertCustomerBtn);
            Controls.Add(label3);
            Controls.Add(SearchtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumbertextBox);
            Controls.Add(NametextBox);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomerInfoView";
            Text = "CustomerInfoView";
            Load += CustomerInfoView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox NametextBox;
        private TextBox NumbertextBox;
        private Label label1;
        private Label label2;
        private TextBox SearchtextBox;
        private Label label3;
        private Button InsertCustomerBtn;
    }
}