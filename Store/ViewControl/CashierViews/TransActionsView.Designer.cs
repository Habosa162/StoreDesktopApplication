namespace Store.ViewControl.CashierViews
{
    partial class TransActionsView
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
            TypeComboBox = new ComboBox();
            label5 = new Label();
            AmountTextBox = new TextBox();
            DescRichTextBox = new RichTextBox();
            label2 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(539, 80);
            button1.Name = "button1";
            button1.Size = new Size(160, 57);
            button1.TabIndex = 46;
            button1.Text = "Add Transaction";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Location = new Point(539, 23);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(160, 23);
            TypeComboBox.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(421, 23);
            label5.Name = "label5";
            label5.Size = new Size(112, 17);
            label5.TabIndex = 42;
            label5.Text = "Transaction Type";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(140, 32);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(245, 23);
            AmountTextBox.TabIndex = 38;
            // 
            // DescRichTextBox
            // 
            DescRichTextBox.Location = new Point(140, 71);
            DescRichTextBox.Name = "DescRichTextBox";
            DescRichTextBox.Size = new Size(245, 118);
            DescRichTextBox.TabIndex = 37;
            DescRichTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(35, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 36;
            label2.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(35, 32);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 34;
            label6.Text = "Amount";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 211);
            dataGridView1.TabIndex = 47;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TransActionsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 421);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(TypeComboBox);
            Controls.Add(label5);
            Controls.Add(AmountTextBox);
            Controls.Add(DescRichTextBox);
            Controls.Add(label2);
            Controls.Add(label6);
            Name = "TransActionsView";
            Text = "TransActionsView";
            Load += TransActionsView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox TypeComboBox;
        private Label label5;
        private TextBox AmountTextBox;
        private RichTextBox DescRichTextBox;
        private Label label2;
        private Label label6;
        private DataGridView dataGridView1;
    }
}