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
                int price= (int)db.ExecuteScalar($"select UnitPrice from Products where ProductName='{product}'")*quantity;
                dataGridView1.Rows.Add(product, quantity, price);
                db.ExecuteNonQuery($"update Products set Quantity-='{quantity}' where ProductName='{product}'");
                //here we update the quantity of the product in the database
                //عايزه اكررها 3 مرات 
                DataTable dt = db.GetDataTable("select ProductName,Quantity,UnitPrice from Products where Type='Drinks'");
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please select a product first.");
            }
        }
    }
}
