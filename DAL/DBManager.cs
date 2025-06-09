using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBManager
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        public DBManager()
        {
            //conn = new SqlConnection("Data Source=DESKTOP-DV1U283\\SQLEXPRESS01;Initial Catalog=DesktopCafe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            conn = new SqlConnection("Data Source=DESKTOP-N3T3R6C\\SQLEXPRESS;Initial Catalog=DesktopCafe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            cmd = new SqlCommand("", conn);
        }
        public DataTable GetDataTable(string cmdText)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = cmdText;
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public int ExecuteNonQuery(string cmdtext)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = cmdtext;
            conn?.Open();
            int x = cmd.ExecuteNonQuery();
            conn?.Close();
            return x;
        }

        public object ExecuteScalar(string cmdtext)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = cmdtext;
            conn?.Open();
            object x = cmd.ExecuteScalar();
            conn?.Close();
            return x;
        }

    
}
}
