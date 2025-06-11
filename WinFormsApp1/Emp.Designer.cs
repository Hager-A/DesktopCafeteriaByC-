namespace WinFormsApp1
{
    partial class Emp
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            SweetsBtn = new RadioButton();
            radioButton2 = new RadioButton();
            drinksBtn = new RadioButton();
            Cancel = new Button();
            OkBtn = new Button();
            productBox = new TextBox();
            AddBtn = new Button();
            Product = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            totalBox = new TextBox();
            total = new Label();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(466, 37);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(198, 181);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(24, 59);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(373, 224);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // SweetsBtn
            // 
            SweetsBtn.AutoSize = true;
            SweetsBtn.Location = new Point(275, 24);
            SweetsBtn.Margin = new Padding(3, 2, 3, 2);
            SweetsBtn.Name = "SweetsBtn";
            SweetsBtn.Size = new Size(61, 19);
            SweetsBtn.TabIndex = 2;
            SweetsBtn.TabStop = true;
            SweetsBtn.Text = "Sweets";
            SweetsBtn.UseVisualStyleBackColor = true;
            SweetsBtn.CheckedChanged += SweetsBtn_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(158, 24);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Food";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // drinksBtn
            // 
            drinksBtn.AutoSize = true;
            drinksBtn.Location = new Point(34, 24);
            drinksBtn.Margin = new Padding(3, 2, 3, 2);
            drinksBtn.Name = "drinksBtn";
            drinksBtn.Size = new Size(58, 19);
            drinksBtn.TabIndex = 4;
            drinksBtn.TabStop = true;
            drinksBtn.Text = "Drinks";
            drinksBtn.UseVisualStyleBackColor = true;
            drinksBtn.CheckedChanged += drinksBtn_CheckedChanged;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(128, 64, 0);
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(452, 299);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(100, 25);
            Cancel.TabIndex = 6;
            Cancel.Text = "Cancel Order";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // OkBtn
            // 
            OkBtn.BackColor = Color.FromArgb(128, 64, 0);
            OkBtn.FlatStyle = FlatStyle.Flat;
            OkBtn.ForeColor = Color.White;
            OkBtn.Location = new Point(570, 299);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(106, 25);
            OkBtn.TabIndex = 7;
            OkBtn.Text = "Confirm Order";
            OkBtn.UseVisualStyleBackColor = false;
            OkBtn.Click += OkBtn_Click;
            // 
            // productBox
            // 
            productBox.Location = new Point(67, 303);
            productBox.Name = "productBox";
            productBox.Size = new Size(100, 23);
            productBox.TabIndex = 8;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(128, 64, 0);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(311, 302);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Product
            // 
            Product.AutoSize = true;
            Product.Location = new Point(12, 306);
            Product.Name = "Product";
            Product.Size = new Size(49, 15);
            Product.TabIndex = 11;
            Product.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 307);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Count";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(221, 303);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // totalBox
            // 
            totalBox.Location = new Point(540, 236);
            totalBox.Name = "totalBox";
            totalBox.Size = new Size(100, 23);
            totalBox.TabIndex = 14;
            totalBox.TextChanged += totalBox_TextChanged;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(486, 239);
            total.Name = "total";
            total.Size = new Size(39, 15);
            total.TabIndex = 15;
            total.Text = "TOTAL";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(128, 64, 0);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(601, -1);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 33);
            BackBtn.TabIndex = 16;
            BackBtn.Text = "log out";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // Emp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(700, 338);
            Controls.Add(BackBtn);
            Controls.Add(total);
            Controls.Add(totalBox);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(Product);
            Controls.Add(AddBtn);
            Controls.Add(productBox);
            Controls.Add(OkBtn);
            Controls.Add(Cancel);
            Controls.Add(drinksBtn);
            Controls.Add(radioButton2);
            Controls.Add(SweetsBtn);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Emp";
            Text = "Emp";
            Load += Emp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private RadioButton SweetsBtn;
        private RadioButton radioButton2;
        private RadioButton drinksBtn;
        private Button Cancel;
        private Button OkBtn;
        private TextBox productBox;
        private Button AddBtn;
        private Label Product;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox totalBox;
        private Label total;
        private Button BackBtn;
    }
}