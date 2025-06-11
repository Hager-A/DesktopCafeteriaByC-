using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject
{
    public static class OrderManager
    {
        static DBManager db = new DBManager();
        public static Order GetOrder(int Id)
        {
            DataTable dt = db.GetDataTable($"select *from Orders where OrderId='{Id}'");
            Order res = new Order();

            foreach (DataRow dr in dt.Rows)
            {
                res = ConvertFromDataRowToOrder(dr);

            }
            return res;
        }
        //public static List<Order> GetAllOrders()
        //{
        //    DataTable dt = db.GetDataTable("select *from Orders");
        //    List<Order> res = new List<Order>();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        res.Add(ConvertFromDataRowToOrder(dr));
        //    }
        //    return res;
        //}

        internal static Order ConvertFromDataRowToOrder(DataRow dr)
        {
            var res = new Order();
            int.TryParse(dr[0]?.ToString() ?? "-1", out int x);
            res.OrderId = x;

            int.TryParse(dr[1]?.ToString() ?? "-1", out x);
            res.TotalPrice = x;

            int.TryParse(dr[2]?.ToString() ?? "-1", out x);
            res.EmpId = x;


            return res;
        }


        public static int Insert(int totalprice, int empid)
        {
            int x = db.ExecuteNonQuery($"insert into Orders(TotalPrice,EmpId) values('{totalprice}','{empid}')");
            return x;
        }
    }
}
