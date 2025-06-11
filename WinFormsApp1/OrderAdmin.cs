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
    public partial class OrderAdmin : Form
    {
        Employee em = new Employee();
        public OrderAdmin(Employee e)
        {
            em = e;
            InitializeComponent();
        }
        int select = -1;
        private void dgvemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvemployee.Rows[e.RowIndex];
                 select = int.Parse(row.Cells["Id"].Value.ToString());
                //Employee emp = EmployeeManager.CheckEmployee(selectindex);
                OrderList orderlist = OrderManager.GetOrderList(select);
                dgvorder.DataSource = orderlist;
                dgvorder.Columns["Employee"].Visible = false;
                //dgvorder.Columns["OrderProducts"].Visible = false;
                dgvorder.Columns["EmpId"].Visible = false;

            }


        }

        private void OrderAdmin_Load(object sender, EventArgs e)
        {
            EmployeeList emps = EmployeeManager.GetListEmployee("Employee");
            dgvemployee.DataSource = emps;
            dgvemployee.Columns["Id"].Visible = false;
            dgvemployee.Columns["Role"].Visible = false;
            dgvemployee.Columns["Password"].Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(em);
            admin.ShowDialog();
            this.Close();
        }

        private void dgvorder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvorder.Rows[e.RowIndex];
                int selectindex = int.Parse(row.Cells["OrderId"].Value.ToString());
                //OrderId
                int x = OrderManager.Delete(selectindex);

                //if (e.RowIndex >= 0)
                //{
                //DataGridViewRow rowemp = dgvemployee.Rows[e.RowIndex];
                //select = int.Parse(rowemp.Cells["Id"].Value.ToString());
                //Employee emp = EmployeeManager.CheckEmployee(select);
                ///
                OrderList orderlist = OrderManager.GetOrderList(select);
                    dgvorder.DataSource = orderlist;
                    //dgvorder.Columns["EmpId"].Visible = false;
                    dgvorder.Columns["Employee"].Visible = false;
                    //dgvorder.Columns["OrderProducts"].Visible = false;
                    dgvorder.Columns["EmpId"].Visible = false;
                //}

            }
            }
    }
}
