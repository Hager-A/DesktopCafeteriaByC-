using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject
{
    public static class ProductManager
    {
        static DBManager db = new DBManager();

        public static Product GetProductById(int Id)
        {
            DataTable dt = db.GetDataTable($"select *from Products where ProductId='{Id}'");
            Product res = new Product();

            foreach (DataRow dr in dt.Rows)
            {
                res = ConvertFromDataRowToProduct(dr);

            }
            return res;
        }
        //public static Product GetProductByType(string Type)
        //{
        //    DataTable dt = db.GetDataTable($"select *from Products where Type='{Type}'");
        //    Product res = new Product();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        res = ConvertFromDataRowToProduct(dr);

        //    }
        //    return res;
        //}
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

        internal static Product ConvertFromDataRowToProduct(DataRow dr)
        {
            var res = new Product();
            int.TryParse(dr[0]?.ToString() ?? "-1", out int x);
            res.ProductId = x;

            res.ProductName= dr[1]?.ToString() ?? "-1";

            int.TryParse(dr[2]?.ToString() ?? "-1", out x);
            res.Quantity = x;

            int.TryParse(dr[3]?.ToString() ?? "-1", out x);
            res.UnitPrice = x;

            res.Type = dr[4]?.ToString() ?? "-1";



            return res;
        }
        



    }
}
