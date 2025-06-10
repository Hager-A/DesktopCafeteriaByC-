namespace WinFormsApp1
{
    partial class Users
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
            txtname = new TextBox();
            label1 = new Label();
            txtpassword = new TextBox();
            label2 = new Label();
            txtcomfirm = new TextBox();
            txtemail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnadd = new Button();
            btnedit = new Button();
            dgvemployee = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            cmbrole = new ComboBox();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).BeginInit();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.None;
            txtname.Location = new Point(12, 42);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(222, 36);
            txtname.TabIndex = 0;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(12, 116);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(219, 36);
            txtpassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 93);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txtcomfirm
            // 
            txtcomfirm.BorderStyle = BorderStyle.None;
            txtcomfirm.Location = new Point(12, 187);
            txtcomfirm.Multiline = true;
            txtcomfirm.Name = "txtcomfirm";
            txtcomfirm.PasswordChar = '*';
            txtcomfirm.Size = new Size(219, 36);
            txtcomfirm.TabIndex = 4;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Location = new Point(12, 268);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(219, 36);
            txtemail.TabIndex = 5;
            txtemail.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 164);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 7;
            label3.Text = "Comfirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 245);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 325);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "Role";
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(128, 64, 0);
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(12, 409);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 10;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.FromArgb(128, 64, 0);
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.ForeColor = Color.White;
            btnedit.Location = new Point(137, 409);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 11;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            // 
            // dgvemployee
            // 
            dgvemployee.BackgroundColor = SystemColors.Info;
            dgvemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvemployee.Location = new Point(292, 42);
            dgvemployee.Name = "dgvemployee";
            dgvemployee.RowHeadersWidth = 51;
            dgvemployee.Size = new Size(509, 406);
            dgvemployee.TabIndex = 12;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(292, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(402, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Employee";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // cmbrole
            // 
            cmbrole.FormattingEnabled = true;
            cmbrole.Location = new Point(12, 348);
            cmbrole.Name = "cmbrole";
            cmbrole.Size = new Size(222, 28);
            cmbrole.TabIndex = 15;
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(128, 64, 0);
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(694, 10);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 16;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnback);
            Controls.Add(cmbrole);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dgvemployee);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtemail);
            Controls.Add(txtcomfirm);
            Controls.Add(label2);
            Controls.Add(txtpassword);
            Controls.Add(label1);
            Controls.Add(txtname);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)dgvemployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private Label label1;
        private TextBox txtpassword;
        private Label label2;
        private TextBox txtcomfirm;
        private TextBox txtemail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnadd;
        private Button btnedit;
        private DataGridView dgvemployee;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox cmbrole;
        private Button btnback;
    }
}