namespace Store.ViewControl.AdminViews
{
    partial class BranchesViewControl
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
            updateBranch = new Button();
            CreateBranch = new Button();
            BranchTextBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Brown;
            DeleteBtn.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(637, 96);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(91, 43);
            DeleteBtn.TabIndex = 51;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click_1;
            // 
            // updateBranch
            // 
            updateBranch.BackColor = Color.Chocolate;
            updateBranch.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            updateBranch.ForeColor = SystemColors.ControlLightLight;
            updateBranch.Location = new Point(525, 96);
            updateBranch.Name = "updateBranch";
            updateBranch.Size = new Size(100, 43);
            updateBranch.TabIndex = 50;
            updateBranch.Text = "Update";
            updateBranch.UseVisualStyleBackColor = false;
            updateBranch.Click += updateBranch_Click;
            // 
            // CreateBranch
            // 
            CreateBranch.BackColor = Color.YellowGreen;
            CreateBranch.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            CreateBranch.ForeColor = SystemColors.ControlLightLight;
            CreateBranch.Location = new Point(415, 96);
            CreateBranch.Name = "CreateBranch";
            CreateBranch.Size = new Size(94, 43);
            CreateBranch.TabIndex = 49;
            CreateBranch.Text = "Create";
            CreateBranch.UseVisualStyleBackColor = false;
            CreateBranch.Click += CreateBranch_Click;
            // 
            // BranchTextBox
            // 
            BranchTextBox.Location = new Point(125, 38);
            BranchTextBox.Name = "BranchTextBox";
            BranchTextBox.Size = new Size(160, 23);
            BranchTextBox.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 47;
            label1.Text = "Branch Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(1, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 293);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BranchesViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(updateBranch);
            Controls.Add(CreateBranch);
            Controls.Add(BranchTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "BranchesViewControl";
            Text = "BranchesViewControl";
            Load += BranchesViewControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteBtn;
        private Button updateBranch;
        private Button CreateBranch;
        private TextBox BranchTextBox;
        private Label label1;
        private DataGridView dataGridView1;
    }
}