namespace Store.ViewControl.AdminViews
{
    partial class PlatformViewControl
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
            updatePlatform = new Button();
            AddPlatform = new Button();
            platformTextBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Brown;
            DeleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(637, 125);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(91, 45);
            DeleteBtn.TabIndex = 45;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // updatePlatform
            // 
            updatePlatform.Location = new Point(525, 125);
            updatePlatform.Name = "updatePlatform";
            updatePlatform.Size = new Size(100, 45);
            updatePlatform.TabIndex = 44;
            updatePlatform.Text = "Update";
            updatePlatform.UseVisualStyleBackColor = true;
            updatePlatform.Click += updatePlatform_Click;
            // 
            // AddPlatform
            // 
            AddPlatform.Location = new Point(415, 125);
            AddPlatform.Name = "AddPlatform";
            AddPlatform.Size = new Size(94, 45);
            AddPlatform.TabIndex = 43;
            AddPlatform.Text = "Create New";
            AddPlatform.UseVisualStyleBackColor = true;
            AddPlatform.Click += AddPlatform_Click;
            // 
            // platformTextBox
            // 
            platformTextBox.Location = new Point(154, 70);
            platformTextBox.Name = "platformTextBox";
            platformTextBox.Size = new Size(160, 23);
            platformTextBox.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 70);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 33;
            label1.Text = "Platform Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(1, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 255);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(415, 125);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 43;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddPlatform_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(525, 125);
            button2.Name = "button2";
            button2.Size = new Size(100, 45);
            button2.TabIndex = 44;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += updatePlatform_Click;
            // 
            // PlatformViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(updatePlatform);
            Controls.Add(AddPlatform);
            Controls.Add(platformTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "PlatformViewControl";
            Text = "PlatformViewControl";
            Load += PlatformViewControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button updatePlatform;
        private Button AddPlatform;
        private TextBox platformTextBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}