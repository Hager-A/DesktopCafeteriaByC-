namespace WinFormsApp1
{
    partial class CafeProduct
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
            txtProduct = new TextBox();
            txtquantity = new TextBox();
            txtprice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbtype = new ComboBox();
            btnadd = new Button();
            btnedit = new Button();
            btnclear = new Button();
            dgvproduct = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvproduct).BeginInit();
            SuspendLayout();
            // 
            // txtProduct
            // 
            txtProduct.BorderStyle = BorderStyle.None;
            txtProduct.Location = new Point(12, 61);
            txtProduct.Multiline = true;
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(222, 36);
            txtProduct.TabIndex = 1;
            // 
            // txtquantity
            // 
            txtquantity.BorderStyle = BorderStyle.None;
            txtquantity.Location = new Point(12, 146);
            txtquantity.Multiline = true;
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(222, 36);
            txtquantity.TabIndex = 2;
            // 
            // txtprice
            // 
            txtprice.BorderStyle = BorderStyle.None;
            txtprice.Location = new Point(12, 235);
            txtprice.Multiline = true;
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(222, 36);
            txtprice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 5;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 201);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 291);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 8;
            label4.Text = "Type";
            // 
            // cmbtype
            // 
            cmbtype.FormattingEnabled = true;
            cmbtype.Location = new Point(12, 314);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(222, 28);
            cmbtype.TabIndex = 16;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(128, 64, 0);
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(4, 383);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(80, 29);
            btnadd.TabIndex = 17;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.FromArgb(128, 64, 0);
            btnedit.FlatStyle = FlatStyle.Flat;
            btnedit.ForeColor = Color.White;
            btnedit.Location = new Point(90, 383);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(78, 29);
            btnedit.TabIndex = 18;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(128, 64, 0);
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.ForeColor = Color.White;
            btnclear.Location = new Point(174, 383);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(83, 29);
            btnclear.TabIndex = 19;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // dgvproduct
            // 
            dgvproduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvproduct.BackgroundColor = SystemColors.Info;
            dgvproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproduct.Location = new Point(291, 42);
            dgvproduct.Name = "dgvproduct";
            dgvproduct.ReadOnly = true;
            dgvproduct.RowHeadersWidth = 51;
            dgvproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproduct.Size = new Size(509, 406);
            dgvproduct.TabIndex = 20;
            dgvproduct.CellClick += dgvproduct_CellClick;
            dgvproduct.CellMouseClick += dgvproduct_CellMouseClick;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(291, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 24);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Food";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(415, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 24);
            radioButton2.TabIndex = 22;
            radioButton2.Text = "Drinks";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(540, 12);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 24);
            radioButton3.TabIndex = 23;
            radioButton3.Text = "Sweets";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(128, 64, 0);
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(694, 10);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 24;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // CafeProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnback);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dgvproduct);
            Controls.Add(btnclear);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(cmbtype);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtprice);
            Controls.Add(txtquantity);
            Controls.Add(txtProduct);
            Name = "CafeProduct";
            Text = "CafeProduct";
            Load += CafeProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvproduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduct;
        private TextBox txtquantity;
        private TextBox txtprice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbtype;
        private Button btnadd;
        private Button btnedit;
        private Button btnclear;
        private DataGridView dgvproduct;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button btnback;
    }
}