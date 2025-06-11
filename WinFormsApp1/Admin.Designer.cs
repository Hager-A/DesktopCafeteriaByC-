namespace WinFormsApp1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            btnuser = new Button();
            btnproduct = new Button();
            btnorder = new Button();
            btnexit = new Button();
            lbluser = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnuser
            // 
            btnuser.BackColor = Color.FromArgb(128, 64, 0);
            btnuser.FlatStyle = FlatStyle.Flat;
            btnuser.Font = new Font("Segoe UI", 12F);
            btnuser.ForeColor = Color.White;
            btnuser.Location = new Point(39, 96);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(170, 53);
            btnuser.TabIndex = 0;
            btnuser.Text = "User";
            btnuser.UseVisualStyleBackColor = false;
            btnuser.Click += btnuser_Click;
            // 
            // btnproduct
            // 
            btnproduct.BackColor = Color.FromArgb(128, 64, 0);
            btnproduct.FlatStyle = FlatStyle.Flat;
            btnproduct.Font = new Font("Segoe UI", 12F);
            btnproduct.ForeColor = Color.White;
            btnproduct.Location = new Point(39, 182);
            btnproduct.Name = "btnproduct";
            btnproduct.Size = new Size(170, 53);
            btnproduct.TabIndex = 1;
            btnproduct.Text = "Product";
            btnproduct.UseVisualStyleBackColor = false;
            btnproduct.Click += btnproduct_Click;
            // 
            // btnorder
            // 
            btnorder.BackColor = Color.FromArgb(128, 64, 0);
            btnorder.FlatStyle = FlatStyle.Flat;
            btnorder.Font = new Font("Segoe UI", 12F);
            btnorder.ForeColor = Color.White;
            btnorder.Location = new Point(39, 276);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(170, 53);
            btnorder.TabIndex = 2;
            btnorder.Text = "Order";
            btnorder.UseVisualStyleBackColor = false;
            btnorder.Click += btnorder_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(128, 64, 0);
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Segoe UI", 12F);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(39, 358);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(170, 53);
            btnexit.TabIndex = 3;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(98, 44);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(50, 20);
            lbluser.TabIndex = 4;
            lbluser.Text = "label1";
            lbluser.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbluser);
            Controls.Add(btnexit);
            Controls.Add(btnorder);
            Controls.Add(btnproduct);
            Controls.Add(btnuser);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnuser;
        private Button btnproduct;
        private Button btnorder;
        private Button btnexit;
        private Label lbluser;
        private PictureBox pictureBox1;
    }
}