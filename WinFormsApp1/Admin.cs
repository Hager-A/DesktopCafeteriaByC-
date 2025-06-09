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
    public partial class Admin : Form
    {
        Employee em = new Employee();
        public Admin(Employee e)
        {
            em = e;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //Text = $" Admin {em.Name}";
            lbluser.Text = em.Name;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user = new Users(em);
            user.ShowDialog();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }
    }
}
