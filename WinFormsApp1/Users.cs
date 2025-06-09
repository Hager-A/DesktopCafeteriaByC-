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
    public partial class Users : Form
    {
        Employee em = new Employee();
        public Users(Employee e)
        {
            em = e;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Employee");
            cmbrole.SelectedIndex = 0;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(em);
            admin.ShowDialog();
            this.Close();
        }
    }
}
