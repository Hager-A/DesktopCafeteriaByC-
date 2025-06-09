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
                dataGridView2.
            }
        }
    }
}
