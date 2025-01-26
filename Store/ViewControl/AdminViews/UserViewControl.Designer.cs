namespace Store.ViewControl.AdminViews
{
    partial class UserViewControl
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
            AddUser = new Button();
            usernameTextBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Password = new Label();
            PasstextBox = new TextBox();
            ahs = new Label();
            BranchComboBox = new ComboBox();
            PermessionComboBox = new ComboBox();
            label2 = new Label();
            isActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Brown;
            DeleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(640, 125);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(97, 45);
            DeleteBtn.TabIndex = 57;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // updateCategory
            // 
            updateCategory.BackColor = Color.Chocolate;
            updateCategory.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            updateCategory.ForeColor = SystemColors.ControlLightLight;
            updateCategory.Location = new Point(524, 125);
            updateCategory.Name = "updateCategory";
            updateCategory.Size = new Size(110, 45);
            updateCategory.TabIndex = 56;
            updateCategory.Text = "Update";
            updateCategory.UseVisualStyleBackColor = false;
            updateCategory.Click += updateCategory_Click;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.YellowGreen;
            AddUser.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            AddUser.ForeColor = SystemColors.ControlLightLight;
            AddUser.Location = new Point(418, 125);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(100, 45);
            AddUser.TabIndex = 55;
            AddUser.Text = "Create";
            AddUser.UseVisualStyleBackColor = false;
            AddUser.Click += AddUser_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(125, 29);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(160, 23);
            usernameTextBox.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 53;
            label1.Text = "UserName";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(1, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 254);
            dataGridView1.TabIndex = 52;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Password.Location = new Point(31, 69);
            Password.Name = "Password";
            Password.Size = new Size(66, 17);
            Password.TabIndex = 58;
            Password.Text = "Password";
            // 
            // PasstextBox
            // 
            PasstextBox.Location = new Point(128, 64);
            PasstextBox.Name = "PasstextBox";
            PasstextBox.Size = new Size(157, 23);
            PasstextBox.TabIndex = 59;
            // 
            // ahs
            // 
            ahs.AutoSize = true;
            ahs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ahs.Location = new Point(316, 32);
            ahs.Name = "ahs";
            ahs.Size = new Size(50, 17);
            ahs.TabIndex = 60;
            ahs.Text = "Branch";
            // 
            // BranchComboBox
            // 
            BranchComboBox.FormattingEnabled = true;
            BranchComboBox.Location = new Point(396, 29);
            BranchComboBox.Name = "BranchComboBox";
            BranchComboBox.Size = new Size(161, 23);
            BranchComboBox.TabIndex = 61;
            // 
            // PermessionComboBox
            // 
            PermessionComboBox.FormattingEnabled = true;
            PermessionComboBox.Location = new Point(396, 69);
            PermessionComboBox.Name = "PermessionComboBox";
            PermessionComboBox.Size = new Size(161, 23);
            PermessionComboBox.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(316, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 63;
            label2.Text = "Permession";
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isActive.Location = new Point(634, 33);
            isActive.Name = "isActive";
            isActive.Size = new Size(84, 24);
            isActive.TabIndex = 64;
            isActive.Text = "is Active";
            isActive.UseVisualStyleBackColor = true;
            // 
            // UserViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(isActive);
            Controls.Add(label2);
            Controls.Add(PermessionComboBox);
            Controls.Add(BranchComboBox);
            Controls.Add(ahs);
            Controls.Add(PasstextBox);
            Controls.Add(Password);
            Controls.Add(DeleteBtn);
            Controls.Add(updateCategory);
            Controls.Add(AddUser);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UserViewControl";
            Text = "UserViewControl";
            Load += UserViewControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button updateCategory;
        private Button AddUser;
        private TextBox usernameTextBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Label Password;
        private TextBox PasstextBox;
        private Label ahs;
        private ComboBox BranchComboBox;
        private ComboBox PermessionComboBox;
        private Label label2;
        private CheckBox isActive;
    }
}