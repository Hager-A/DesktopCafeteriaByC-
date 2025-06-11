using DAL;
using DesktopProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Emp : Form
    {
        static DBManager db = new DBManager();
        Employee em = new Employee();
        public Emp(Employee e)
        {
            em = e;
            InitializeComponent();
        }

        private void Emp_Load(object sender, EventArgs e)
        {
            Text = $" Employee ";
            dataGridView1.Columns.Add("Product", "Product");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.RowCount = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            totalBox.Text = "0";
        }

        private void drinksBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksBtn.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Drinks'");

                dataGridView2.DataSource = dt;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Food'");

                dataGridView2.DataSource = dt;
            }
        }

        private void SweetsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SweetsBtn.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Sweets'");

                dataGridView2.DataSource = dt;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                string value = row.Cells[0].Value?.ToString() ?? "None";
                productBox.Text = value;

                if (decimal.TryParse(row.Cells[1].Value?.ToString(), out decimal maxValue))
                {
                    numericUpDown1.Maximum = maxValue;
                }
                else
                {
                    numericUpDown1.Maximum = 0;
                    numericUpDown1.Value = 0;
                }
            }
            else
            {
                productBox.Text = "None";
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (productBox.Text != "None")
            {

                string product = productBox.Text;
                int quantity = (int)numericUpDown1.Value;
                int price = (int)db.ExecuteScalar($"select UnitPrice from Products where ProductName='{product}'") * quantity;
                dataGridView1.Rows.Add(product, quantity, price);
                db.ExecuteNonQuery($"update Products set Quantity-='{quantity}' where ProductName='{product}'");
                //here we update the quantity of the product in the database
                if (SweetsBtn.Checked)
                {
                    DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Sweets'");

                    dataGridView2.DataSource = dt;
                }
                if (radioButton2.Checked)
                {
                    DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Food'");

                    dataGridView2.DataSource = dt;
                }
                if (drinksBtn.Checked)
                {
                    DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Drinks'");

                    dataGridView2.DataSource = dt;
                }
                totalBox.Text = (price + (int.Parse)(totalBox.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Please select a product first.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int count = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            string product = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "None";
            int price = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            db.ExecuteNonQuery($"update Products set Quantity+='{count}' where ProductName='{product}'");

            if (SweetsBtn.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Sweets'");

                dataGridView2.DataSource = dt;
            }
            else if (radioButton2.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Food'");

                dataGridView2.DataSource = dt;
            }
            else if (drinksBtn.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Drinks'");

                dataGridView2.DataSource = dt;
            }
            totalBox.Text = ((int.Parse)(totalBox.Text) - price).ToString();
            dataGridView1.Rows.RemoveAt(e.RowIndex);


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            int count;
            string product;
            int price;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                count = (int)row.Cells[1].Value;
                product = row.Cells[0].Value?.ToString() ?? "None";
                price = (int)row.Cells[2].Value;
                totalBox.Text = ((int.Parse)(totalBox.Text) - price).ToString();
                db.ExecuteNonQuery($"update Products set Quantity+='{count}' where ProductName='{product}'");
                if (SweetsBtn.Checked)
                {
                    DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Sweets'");

                    dataGridView2.DataSource = dt;
                }
                else if (radioButton2.Checked)
                {
                    DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Food'");

                    dataGridView2.DataSource = dt;
                }
                else if (drinksBtn.Checked)
                {
                    DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Drinks'");

                    dataGridView2.DataSource = dt;
                }
                

            }
            dataGridView1.Rows.Clear();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            OrderManager.Insert(int.Parse(totalBox.Text), em.Id);
        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 newform = new Form1();
            newform.ShowDialog();
            this.Close();
            
        }
    }
}
