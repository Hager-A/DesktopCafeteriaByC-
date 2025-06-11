namespace WinFormsApp1
{
    partial class OrderAdmin
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
            dgvorder = new DataGridView();
            dgvemployee = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).BeginInit();
            SuspendLayout();
            // 
            // dgvorder
            // 
            dgvorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvorder.BackgroundColor = SystemColors.Info;
            dgvorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorder.Location = new Point(369, 61);
            dgvorder.Name = "dgvorder";
            dgvorder.ReadOnly = true;
            dgvorder.RowHeadersWidth = 51;
            dgvorder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvorder.Size = new Size(430, 389);
            dgvorder.TabIndex = 21;
            dgvorder.CellMouseDoubleClick += dgvorder_CellMouseDoubleClick;
            // 
            // dgvemployee
            // 
            dgvemployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvemployee.BackgroundColor = SystemColors.Info;
            dgvemployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvemployee.Location = new Point(2, 61);
            dgvemployee.Name = "dgvemployee";
            dgvemployee.ReadOnly = true;
            dgvemployee.RowHeadersWidth = 51;
            dgvemployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvemployee.Size = new Size(276, 389);
            dgvemployee.TabIndex = 22;
            dgvemployee.CellContentClick += dgvemployee_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(2, 22);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 23;
            label2.Text = "Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(369, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 24;
            label1.Text = "Order List";
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(128, 64, 0);
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(705, 16);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 25;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // OrderAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnback);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvemployee);
            Controls.Add(dgvorder);
            Name = "OrderAdmin";
            Text = "OrderAdmin";
            Load += OrderAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvemployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvorder;
        private DataGridView dgvemployee;
        private Label label2;
        private Label label1;
        private Button btnback;
    }
}