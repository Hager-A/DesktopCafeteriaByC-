using DesktopProject;
using System.Text.RegularExpressions;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "";
            string password = "";
            string patternEmail = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";
            bool check = true;
            Console.WriteLine("Login");
            while (check)
            {
                Console.Write("Enter the Email : ");
                email = Console.ReadLine();
                Console.Write("Enter the password : ");
                password = Console.ReadLine();

                if (Regex.IsMatch(email, patternEmail) && Regex.IsMatch(password, patternPassword))
                {
                    Console.WriteLine("vaild");
                    check = false;
                }
                else
                {
                    Console.WriteLine("email or password  not vaild");

                }
            }

            Employee em = EmployeeManager.GetEmployee(email, password);
            Console.WriteLine(em.Name);
            Console.WriteLine(em.Name==null);
            //Console.WriteLine(em.Name.GetType());
            //Console.WriteLine(em.Name== "ND");





        }
    }
}
