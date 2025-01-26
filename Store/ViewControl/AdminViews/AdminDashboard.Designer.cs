namespace Store.ViewControl
{
    partial class AdminDashboard
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
            productBtn = new Button();
            platforms = new Button();
            Categories = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // productBtn
            // 
            productBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            productBtn.Location = new Point(600, 112);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(129, 60);
            productBtn.TabIndex = 0;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += productBtn_Click;
            // 
            // platforms
            // 
            platforms.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            platforms.Location = new Point(336, 112);
            platforms.Name = "platforms";
            platforms.Size = new Size(119, 60);
            platforms.TabIndex = 1;
            platforms.Text = "Platforms";
            platforms.UseVisualStyleBackColor = true;
            platforms.Click += platforms_Click;
            // 
            // Categories
            // 
            Categories.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            Categories.Location = new Point(472, 112);
            Categories.Name = "Categories";
            Categories.Size = new Size(108, 60);
            Categories.TabIndex = 2;
            Categories.Text = "Categories";
            Categories.UseVisualStyleBackColor = true;
            Categories.Click += Categories_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button1.Location = new Point(33, 112);
            button1.Name = "button1";
            button1.Size = new Size(145, 60);
            button1.TabIndex = 3;
            button1.Text = "System users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button2.Location = new Point(195, 112);
            button2.Name = "button2";
            button2.Size = new Size(119, 60);
            button2.TabIndex = 4;
            button2.Text = "Branches";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Categories);
            Controls.Add(platforms);
            Controls.Add(productBtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button productBtn;
        private Button platforms;
        private Button Categories;
        private Button button1;
        private Button button2;
    }
}