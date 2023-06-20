using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
namespace Inventory_Management_System.db
{
    public static class db
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;
        public static string username = "admin";
        public static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Library\\Documents\\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
        public static void Connection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Library\\Documents\\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
    


