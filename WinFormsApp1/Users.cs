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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        int selectindex = 0;

        private void Users_Load(object sender, EventArgs e)
        {
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Employee");
            cmbrole.SelectedIndex = 0;
            ////dgvemployee
            EmployeeList emps = EmployeeManager.GetListEmployee("Admin");

            //dgvemployee.DataSource = emps.Select(e=>new {e.Name,e.Email,e.Password }).ToList();
            dgvemployee.DataSource = emps;
            dgvemployee.Columns["Id"].Visible = false;
            dgvemployee.Columns["Role"].Visible = false;


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(em);
            admin.ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeList emps = EmployeeManager.GetListEmployee("Admin");

            //dgvemployee.DataSource = emps.Select(e=>new {e.Name,e.Email,e.Password }).ToList();
            dgvemployee.DataSource = emps;
            dgvemployee.Columns["Id"].Visible = false;
            dgvemployee.Columns["Role"].Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeList emps = EmployeeManager.GetListEmployee("Employee");

            //dgvemployee.DataSource = emps.Select(e=>new {e.Name,e.Email,e.Password }).ToList();
            dgvemployee.DataSource = emps;
            dgvemployee.Columns["Id"].Visible = false;
            dgvemployee.Columns["Role"].Visible = false;
        }

        private void dgvemployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvemployee.Rows[e.RowIndex];
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtcomfirm.Text = row.Cells["Password"].Value.ToString();
                txtpassword.Text = row.Cells["Password"].Value.ToString();
                cmbrole.Text = row.Cells["Role"].Value.ToString();
                selectindex = int.Parse(row.Cells["Id"].Value.ToString());
                //MessageBox.Show($"{selectindex}");
                //MessageBox.Show(row.Cells["Id"].Value.ToString());

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            Employee emm = EmployeeManager.CheckEmployee(email);

            //Console.WriteLine(em.Name);

            if (emm.Name == null)
            {

                //MessageBox.Show("not Email exist");
                emm.Email = txtemail.Text;
                emm.Name = txtname.Text;
                emm.Role = cmbrole.Text;
                emm.Password = txtpassword.Text;
                //int check;
                if (txtemail.Text == "" || txtname.Text == "" || cmbrole.Text == "" || txtpassword.Text == "" || txtcomfirm.Text == "")
                {
                    MessageBox.Show("you should fill all fields");


                }
                else
                {
                    string patternEmail = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
                    string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";
                    string patternName = @"^[a-zA-Z]+$";

                    

                    if (Regex.IsMatch(txtname.Text, patternName) && txtname.Text.Length >= 2 &&
                        Regex.IsMatch(txtpassword.Text, patternPassword) && txtpassword.Text==txtcomfirm.Text &&
                        Regex.IsMatch(txtemail.Text, patternEmail))
                    {

                        int x = EmployeeManager.Insert(emm);
                        if (radioButton1.Checked)
                            dgvemployee.DataSource = EmployeeManager.GetListEmployee("Admin");
                        else if (radioButton2.Checked)
                            dgvemployee.DataSource = EmployeeManager.GetListEmployee("Employee");

                        txtemail.Text = "";
                        txtname.Text = "";
                        cmbrole.Text = "";
                        txtpassword.Text = "";
                        txtcomfirm.Text = "";
                    }
                    else
                    {
                        if(!Regex.IsMatch(txtname.Text, patternName) || txtname.Text.Length < 2 )
                            MessageBox.Show("write a valid name");
                        else if(!Regex.IsMatch(txtpassword.Text, patternPassword) || txtpassword.Text != txtcomfirm.Text)
                            MessageBox.Show("write a valid password or chech if the passord and the confirm password match");
                        else if (!Regex.IsMatch(txtemail.Text, patternEmail))
                            MessageBox.Show("write a valid email");
                    }


                }

                //em = emm;



            }
            else
            {

                MessageBox.Show("this Email exist");

            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            Employee emm = EmployeeManager.CheckEmployee(selectindex);

            if (emm.Name == null)
            {
                MessageBox.Show("you should select a user");
            }
            else
            {

                if (txtemail.Text == "" || txtname.Text == "" || cmbrole.Text == "" || txtpassword.Text == "" || txtcomfirm.Text == "")
                {
                    MessageBox.Show("you should fill all fields");


                }
                else
                {
                    string patternEmail = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
                    string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";
                    string patternName = @"^[a-zA-Z]+$";



                    if (Regex.IsMatch(txtname.Text, patternName) && txtname.Text.Length >= 2 &&
                        Regex.IsMatch(txtpassword.Text, patternPassword) && txtpassword.Text == txtcomfirm.Text &&
                        Regex.IsMatch(txtemail.Text, patternEmail))
                    {
                        emm.Email = txtemail.Text;
                        emm.Name = txtname.Text;
                        emm.Role = cmbrole.Text;
                        emm.Password = txtpassword.Text;

                        int x = EmployeeManager.Update(emm);

                        MessageBox.Show("updated succesfully");

                        if (radioButton1.Checked)
                            dgvemployee.DataSource = EmployeeManager.GetListEmployee("Admin");
                        else if (radioButton2.Checked)
                            dgvemployee.DataSource = EmployeeManager.GetListEmployee("Employee");
                        txtemail.Text = "";
                        txtname.Text = "";
                        cmbrole.Text = "";
                        txtpassword.Text = "";
                        txtcomfirm.Text = "";
                        //MessageBox.Show("your employee is update");

                        if (emm.Id == em.Id)
                        {
                            em = emm;

                        }
                    }
                    else
                    {
                        if (!Regex.IsMatch(txtname.Text, patternName) || txtname.Text.Length < 2)
                            MessageBox.Show("write a valid name");
                        else if (!Regex.IsMatch(txtpassword.Text, patternPassword) || txtpassword.Text != txtcomfirm.Text)
                            MessageBox.Show("write a valid password or chech if the passord and the confirm password match");
                        else if (!Regex.IsMatch(txtemail.Text, patternEmail))
                            MessageBox.Show("write a valid email");
                    }


                }
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            selectindex = 0;

            txtemail.Text = "";
            txtname.Text = "";
            cmbrole.Text = "";
            txtpassword.Text = "";
            txtcomfirm.Text = "";

        }

        private void dgvemployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DialogResult check = MessageBox.Show("I are your sure you want to delete it");
            //if (check == DialogResult.No)
            //{
                DataGridViewRow row = dgvemployee.Rows[e.RowIndex];
           int selected = int.Parse(row.Cells["Id"].Value.ToString());
            Employee emm = EmployeeManager.CheckEmployee(selected);
            int x = EmployeeManager.Delete(emm);

            if (radioButton1.Checked)
                dgvemployee.DataSource = EmployeeManager.GetListEmployee("Admin");
            else if (radioButton2.Checked)
                dgvemployee.DataSource = EmployeeManager.GetListEmployee("Employee");
            txtemail.Text = "";
            txtname.Text = "";
            cmbrole.Text = "";
            txtpassword.Text = "";
            txtcomfirm.Text = "";


               
            //}
        }
    }
}
