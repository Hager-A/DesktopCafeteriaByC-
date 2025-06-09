using DesktopProject;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";


            //bool check = true;

            if (Regex.IsMatch(email, patternEmail) && Regex.IsMatch(password, patternPassword))
            {

                Employee em = EmployeeManager.GetEmployee(email, password);
                Console.WriteLine(em.Name);
                //Console.WriteLine(em.Name == null);

                if (em.Name == null)
                {
                    MessageBox.Show("Error  password or Email");
                }
                else
                {
                    this.Hide();
                    if (em.Role== "Admin")
                    {
                        Admin ad = new Admin(em);
                        ad.ShowDialog();

                    }
                    else
                    {
                        Emp emp = new Emp(em);
                        emp.ShowDialog();

                    }
                    this.Close();
                }

                    
              
               
                
                //Application.Exit();


            }
            else
            {
                //Console.WriteLine("email or password  not vaild");
                MessageBox.Show("Invliad  password or Email");


            }
        }
    }
}
