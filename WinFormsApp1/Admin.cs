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
            Text = $" Admin {em.Name}";
        }
    }
}
