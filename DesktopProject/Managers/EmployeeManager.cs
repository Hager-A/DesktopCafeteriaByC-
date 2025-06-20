﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject
{
    public static class EmployeeManager
    {
        static DBManager db = new DBManager();
        public static Employee GetEmployee(string email, string pass)
        {
            DataTable dt = db.GetDataTable($"select *from Employees where Email='{email}' and Password='{pass}'");
            Employee res = new Employee();

            foreach (DataRow dr in dt.Rows)
            {
                res = ConvertFromDataRowToEmp(dr);

            }
            return res;
        }
        //////
        public static Employee CheckEmployee(string email)
        {
            DataTable dt = db.GetDataTable($"select *from Employees where Email='{email}'");
            Employee res = new Employee();

            foreach (DataRow dr in dt.Rows)
            {
                res = ConvertFromDataRowToEmp(dr);

            }
            return res;
        }


        public static Employee CheckEmployee(int id)
        {
            DataTable dt = db.GetDataTable($"select *from Employees where Id='{id}'");
            Employee res = new Employee();

            foreach (DataRow dr in dt.Rows)
            {
                res = ConvertFromDataRowToEmp(dr);

            }
            return res;
        }
        //////////////
        public static EmployeeList GetListEmployee( string Role)
        {
            DataTable dt = db.GetDataTable($"select *from Employees where Role='{Role}'");
            //Employee res = new Employee();
            var res = ConvertFormDataToDaptList(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    res = ConvertFromDataRowToEmp(dr);

            //}
            return res;
        }


        internal static EmployeeList ConvertFormDataToDaptList(DataTable dt)
        {
            var res = new EmployeeList();
            foreach (DataRow dr in dt.Rows)
                res.Add(ConvertFromDataRowToEmp(dr));
            return res;
        }
        ////////////
        internal static Employee ConvertFromDataRowToEmp(DataRow dr)
        {
            var res = new Employee();
            int.TryParse(dr[0]?.ToString() ?? "-1", out int x);
            res.Id = x;

            res.Email = dr[1]?.ToString() ?? "ND";
            res.Name = dr[2]?.ToString() ?? "ND";
            res.Password = dr[3]?.ToString() ?? "ND";
            res.Role = dr[4]?.ToString() ?? "ND";

            return res;
        }


        public static int Insert(Employee employee)
        {
            int x = db.ExecuteNonQuery($"insert into Employees(Email,Name,Password,Role) values('{employee.Email}','{employee.Name}','{employee.Password}','{employee.Role}')");
            return x;
        }

        public static int Update(Employee employee)
        {
            int x = db.ExecuteNonQuery($"UPDATE employees SET Email = '{employee.Email}', Name = '{employee.Name}' ,Password='{employee.Password}',Role='{employee.Role}' WHERE Id = {employee.Id};");
            return x;
        }
        public static int Delete(Employee employee)
        {
            int x = db.ExecuteNonQuery($"delete from Employees where Id = {employee.Id};");
            return x;
        }
    }
}
