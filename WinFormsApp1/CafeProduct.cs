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
    public partial class CafeProduct : Form
    {
        Employee em = new Employee();
        public CafeProduct(Employee e)
        {
            em = e;
            InitializeComponent();
        }

        private void CafeProduct_Load(object sender, EventArgs e)
        {
            cmbtype.Items.Add("Food");
            cmbtype.Items.Add("Drinks");
            cmbtype.Items.Add("Sweets");
            cmbtype.SelectedIndex = 0;

            ProductList Products = ProductManager.GetProductById("Food");
            dgvproduct.DataSource = Products;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            ProductList Products = ProductManager.GetProductById("Food");
            dgvproduct.DataSource = Products;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ProductList Products = ProductManager.GetProductById("Drinks");
            dgvproduct.DataSource = Products;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ProductList Products = ProductManager.GetProductById("Sweets");
            dgvproduct.DataSource = Products;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(em);
            admin.ShowDialog();
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtprice.Text = "";
            txtProduct.Text = "";
            txtquantity.Text = "";
            cmbtype.Text = "";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.ProductName = txtProduct.Text;
            product.UnitPrice = int.Parse(txtprice.Text);
            product.Quantity = int.Parse(txtquantity.Text);
            product.Type = cmbtype.Text;
            //int x=p
            txtprice.Text = "";
            txtProduct.Text = "";
            txtquantity.Text = "";
            cmbtype.Text = "";
        }
    }
}
