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
        }

        private void drinksBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (drinksBtn.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName from Products where Type='Drinks'");

                dataGridView2.DataSource = dt;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName from Products where Type='Food'");

                dataGridView2.DataSource = dt;
            }
        }

        private void SweetsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SweetsBtn.Checked)
            {
                DataTable dt = db.GetDataTable("select ProductName from Products where Type='Sweets'");

                dataGridView2.DataSource = dt;
            }
        }
    }
}
