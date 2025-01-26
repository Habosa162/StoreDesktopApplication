namespace Store.ViewControl
{
    partial class DeviceMaintenanceView
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
            label6 = new Label();
            label1 = new Label();
            DeliverydateTimePicker = new DateTimePicker();
            label2 = new Label();
            DescRichTextBox = new RichTextBox();
            SerialTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            PricetextBox = new TextBox();
            label5 = new Label();
            label8 = new Label();
            CategoryComboBox = new ComboBox();
            PlatFormComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(25, 70);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 18;
            label6.Text = "Serial Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(122, 23);
            label1.TabIndex = 16;
            label1.Text = "Device Maintenance";
            // 
            // DeliverydateTimePicker
            // 
            DeliverydateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeliverydateTimePicker.Location = new Point(494, 197);
            DeliverydateTimePicker.Name = "DeliverydateTimePicker";
            DeliverydateTimePicker.Size = new Size(200, 25);
            DeliverydateTimePicker.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(42, 205);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 22;
            label2.Text = "Description";
            // 
            // DescRichTextBox
            // 
            DescRichTextBox.Location = new Point(130, 202);
            DescRichTextBox.Name = "DescRichTextBox";
            DescRichTextBox.Size = new Size(245, 118);
            DescRichTextBox.TabIndex = 23;
            DescRichTextBox.Text = "";
            // 
            // SerialTextBox
            // 
            SerialTextBox.Location = new Point(130, 64);
            SerialTextBox.Name = "SerialTextBox";
            SerialTextBox.Size = new Size(245, 23);
            SerialTextBox.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(381, 203);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 25;
            label3.Text = "Delivery Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(3, 131);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 26;
            label4.Text = "Maintenance Price";
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(130, 130);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(245, 23);
            PricetextBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(414, 70);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 28;
            label5.Text = "Platform";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(412, 131);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 29;
            label8.Text = "Category";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(494, 130);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(160, 23);
            CategoryComboBox.TabIndex = 30;
            // 
            // PlatFormComboBox
            // 
            PlatFormComboBox.FormattingEnabled = true;
            PlatFormComboBox.Location = new Point(494, 64);
            PlatFormComboBox.Name = "PlatFormComboBox";
            PlatFormComboBox.Size = new Size(160, 23);
            PlatFormComboBox.TabIndex = 31;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(494, 285);
            button1.Name = "button1";
            button1.Size = new Size(160, 57);
            button1.TabIndex = 32;
            button1.Text = "Add Device";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DeviceMaintenanceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(PlatFormComboBox);
            Controls.Add(CategoryComboBox);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(PricetextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SerialTextBox);
            Controls.Add(DescRichTextBox);
            Controls.Add(label2);
            Controls.Add(DeliverydateTimePicker);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "DeviceMaintenanceView";
            Text = "DeviceMaintenance";
            Load += DeviceMaintenance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label1;
        private DateTimePicker DeliverydateTimePicker;
        private Label label2;
        private RichTextBox DescRichTextBox;
        private TextBox SerialTextBox;
        private Label label3;
        private Label label4;
        private TextBox PricetextBox;
        private Label label5;
        private Label label8;
        private ComboBox CategoryComboBox;
        private ComboBox PlatFormComboBox;
        private Button button1;
    }
}