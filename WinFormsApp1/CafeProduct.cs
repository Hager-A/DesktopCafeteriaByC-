using DesktopProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

            dgvproduct.Columns["ProductId"].Visible = false;
            dgvproduct.Columns["Type"].Visible = false;


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

            if (txtProduct.Text == "" || txtprice.Text == "" || txtquantity.Text == "" || cmbtype.Text == "")
            {
                MessageBox.Show("you should fill all fields");


            }
            else
            {
                string patternName = @"^[a-zA-Z\s]+$";



                if (Regex.IsMatch(txtProduct.Text, patternName)&&int.TryParse(txtprice.Text,out int number )&& int.TryParse(txtquantity.Text, out int number1))
                {

                    Product product = new Product();

                    product.ProductName = txtProduct.Text;
                    product.UnitPrice = int.Parse(txtprice.Text);
                    product.Quantity = int.Parse(txtquantity.Text);
                    product.Type = cmbtype.Text;
                    int x = ProductManager.Insert(product);
                    if (radioButton1.Checked)
                        dgvproduct.DataSource = ProductManager.GetProductById("Food");
                    else if (radioButton2.Checked)
                        dgvproduct.DataSource = ProductManager.GetProductById("Drinks");
                    else if (radioButton3.Checked)
                        dgvproduct.DataSource = ProductManager.GetProductById("Sweets");

                    txtprice.Text = "";
                    txtProduct.Text = "";
                    txtquantity.Text = "";
                    cmbtype.Text = "";
                
                }
                else
                {
                    if (!Regex.IsMatch(txtProduct.Text, patternName) )
                        MessageBox.Show("write a valid product name");
                    
                    else if (!int.TryParse(txtquantity.Text, out number1))
                        MessageBox.Show("write a valid quantity value");
                    else if (!int.TryParse(txtprice.Text, out number))
                        MessageBox.Show("write a valid price value");
                }


            }
        }
        int selectindex = -1;






        
        private void btnedit_Click(object sender, EventArgs e)
        {
            Product product = ProductManager.GetProductById(selectindex);

            if (product.ProductName != null)
            {
                if (txtProduct.Text == "" || txtprice.Text == "" || txtquantity.Text == "" || cmbtype.Text == "")
                {
                    MessageBox.Show("you should fill all fields");


                }
                else
                {
                    string patternName = @"^[a-zA-Z\s]+$";



                    if (Regex.IsMatch(txtProduct.Text, patternName) && int.TryParse(txtprice.Text, out int number) && int.TryParse(txtquantity.Text, out int number1))
                    {

                        product.ProductName = txtProduct.Text;
                        product.UnitPrice = int.Parse(txtprice.Text);
                        product.Quantity = int.Parse(txtquantity.Text);
                        product.Type = cmbtype.Text;
                        int x = ProductManager.update(product);
                        MessageBox.Show("Update is accepted");
                        selectindex = -1;

                        if (radioButton1.Checked)
                            dgvproduct.DataSource = ProductManager.GetProductById("Food");
                        else if (radioButton2.Checked)
                            dgvproduct.DataSource = ProductManager.GetProductById("Drinks");
                        else if (radioButton3.Checked)
                            dgvproduct.DataSource = ProductManager.GetProductById("Sweets");

                        txtprice.Text = "";
                        txtProduct.Text = "";
                        txtquantity.Text = "";
                        cmbtype.Text = "";

                    }
                    else
                    {
                        if (!Regex.IsMatch(txtProduct.Text, patternName))
                            MessageBox.Show("write a valid product name");
                        
                        else if (!int.TryParse(txtquantity.Text, out number1))
                            MessageBox.Show("write a valid quantity value");

                        else if (!int.TryParse(txtprice.Text, out number))
                            MessageBox.Show("write a valid price value");
                    }


                }
            }
            else
            {
                MessageBox.Show("you should select the row");
            }

        }

        private void dgvproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvproduct.Rows[e.RowIndex];
                txtprice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtProduct.Text = row.Cells["ProductName"].Value.ToString();
                txtquantity.Text = row.Cells["Quantity"].Value.ToString();
                cmbtype.Text = row.Cells["Type"].Value.ToString();
                selectindex = int.Parse(row.Cells["ProductId"].Value.ToString());



            }


        }

        private void dgvproduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgvproduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvproduct.Rows[e.RowIndex];
            int selected = int.Parse(row.Cells["ProductId"].Value.ToString());

            Product product = ProductManager.GetProductById(selectindex);
            int x = ProductManager.Delete(product);

            if (radioButton1.Checked)
                dgvproduct.DataSource = ProductManager.GetProductById("Food");
            else if (radioButton2.Checked)
                dgvproduct.DataSource = ProductManager.GetProductById("Drinks");
            else if (radioButton3.Checked)
                dgvproduct.DataSource = ProductManager.GetProductById("Sweets");

            txtprice.Text = "";
            txtProduct.Text = "";
            txtquantity.Text = "";
            cmbtype.Text = "";

        }
    }
}
