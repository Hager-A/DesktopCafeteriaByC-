namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(319, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(311, 156);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 1;
            label1.Text = "Login cafe";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(274, 286);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(294, 42);
            txtpassword.TabIndex = 5;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Font = new Font("Segoe UI", 12F);
            txtemail.Location = new Point(274, 218);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(294, 42);
            txtemail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(157, 232);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(148, 300);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(128, 64, 0);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(294, 364);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(169, 56);
            btnlogin.TabIndex = 10;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtemail);
            Controls.Add(txtpassword);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtpassword;
        private TextBox txtemail;
        private Label label2;
        private Label label4;
        private Button btnlogin;
    }
}
