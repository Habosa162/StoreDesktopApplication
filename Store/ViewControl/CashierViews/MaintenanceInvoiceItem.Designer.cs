namespace Store.ViewControl.CashierViews
{
    partial class MaintenanceInvoiceItem
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
            SearchtextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DescriptionrichTextBox = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SerialtextBox = new TextBox();
            PlatfromtextBox = new TextBox();
            CategorytextBox = new TextBox();
            PricetextBox = new TextBox();
            RecieveDatetextBox = new TextBox();
            DeliveryDatetextBox = new TextBox();
            insertDevice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(937, 304);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(695, 197);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(145, 22);
            SearchtextBox.TabIndex = 1;
            SearchtextBox.TextChanged += SearchtextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label1.Location = new Point(598, 200);
            label1.Name = "label1";
            label1.Size = new Size(91, 14);
            label1.TabIndex = 3;
            label1.Text = "Serial Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(91, 14);
            label2.TabIndex = 4;
            label2.Text = "Serial Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(60, 14);
            label3.TabIndex = 5;
            label3.Text = "Platform";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(63, 14);
            label4.TabIndex = 6;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label5.Location = new Point(305, 30);
            label5.Name = "label5";
            label5.Size = new Size(36, 14);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // DescriptionrichTextBox
            // 
            DescriptionrichTextBox.Location = new Point(654, 30);
            DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            DescriptionrichTextBox.Size = new Size(225, 90);
            DescriptionrichTextBox.TabIndex = 8;
            DescriptionrichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label6.Location = new Point(572, 33);
            label6.Name = "label6";
            label6.Size = new Size(76, 14);
            label6.TabIndex = 9;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label7.Location = new Point(305, 83);
            label7.Name = "label7";
            label7.Size = new Size(79, 14);
            label7.TabIndex = 10;
            label7.Text = "Recive Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            label8.Location = new Point(305, 133);
            label8.Name = "label8";
            label8.Size = new Size(88, 14);
            label8.TabIndex = 11;
            label8.Text = "Delivery Date";
            // 
            // SerialtextBox
            // 
            SerialtextBox.Location = new Point(102, 27);
            SerialtextBox.Name = "SerialtextBox";
            SerialtextBox.Size = new Size(162, 22);
            SerialtextBox.TabIndex = 12;
            // 
            // PlatfromtextBox
            // 
            PlatfromtextBox.Location = new Point(100, 82);
            PlatfromtextBox.Name = "PlatfromtextBox";
            PlatfromtextBox.Size = new Size(162, 22);
            PlatfromtextBox.TabIndex = 13;
            // 
            // CategorytextBox
            // 
            CategorytextBox.Location = new Point(102, 137);
            CategorytextBox.Name = "CategorytextBox";
            CategorytextBox.Size = new Size(160, 22);
            CategorytextBox.TabIndex = 14;
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(397, 30);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(163, 22);
            PricetextBox.TabIndex = 15;
            // 
            // RecieveDatetextBox
            // 
            RecieveDatetextBox.Location = new Point(397, 81);
            RecieveDatetextBox.Name = "RecieveDatetextBox";
            RecieveDatetextBox.Size = new Size(163, 22);
            RecieveDatetextBox.TabIndex = 16;
            // 
            // DeliveryDatetextBox
            // 
            DeliveryDatetextBox.Location = new Point(397, 130);
            DeliveryDatetextBox.Name = "DeliveryDatetextBox";
            DeliveryDatetextBox.Size = new Size(163, 22);
            DeliveryDatetextBox.TabIndex = 17;
            // 
            // insertDevice
            // 
            insertDevice.BackColor = Color.SteelBlue;
            insertDevice.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertDevice.ForeColor = SystemColors.ControlLightLight;
            insertDevice.Location = new Point(411, 184);
            insertDevice.Name = "insertDevice";
            insertDevice.Size = new Size(117, 35);
            insertDevice.TabIndex = 18;
            insertDevice.Text = "Insert";
            insertDevice.UseVisualStyleBackColor = false;
            insertDevice.Click += insertDevice_Click;
            // 
            // MaintenanceInvoiceItem
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 532);
            Controls.Add(insertDevice);
            Controls.Add(DeliveryDatetextBox);
            Controls.Add(RecieveDatetextBox);
            Controls.Add(PricetextBox);
            Controls.Add(CategorytextBox);
            Controls.Add(PlatfromtextBox);
            Controls.Add(SerialtextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DescriptionrichTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchtextBox);
            Controls.Add(dataGridView1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold);
            Name = "MaintenanceInvoiceItem";
            Text = "MaintenanceInvoiceItem";
            Load += MaintenanceInvoiceItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox SearchtextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox DescriptionrichTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox SerialtextBox;
        private TextBox PlatfromtextBox;
        private TextBox CategorytextBox;
        private TextBox PricetextBox;
        private TextBox RecieveDatetextBox;
        private TextBox DeliveryDatetextBox;
        private Button insertDevice;
    }
}