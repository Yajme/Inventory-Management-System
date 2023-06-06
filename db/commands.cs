using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

public static class commands
    {
        public static void loadInventory()
        {
        db.con.Open();
        db.cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID", db.con);
        db.dr = db.cmd.ExecuteReader();
        }
        public static void loadsuppliers()
        {
        db.con.Open();
        db.cmd = new SqlCommand("SELECT * FROM SUPPLIERS", db.con);
        db.dr = db.cmd.ExecuteReader();
        }
        public static void loadcategories()
        {
        db.con.Open();
        db.cmd = new SqlCommand("SELECT * FROM CATEGORIES", db.con);
        db.dr = db.cmd.ExecuteReader();
        }
        public static int insertcategories(string category)
        {
         db.cmd = new SqlCommand("INSERT INTO CATEGORIES(CATEGORYNAME) VALUES(@CATEGORYNAME)", db.con);
         db.cmd.Parameters.AddWithValue("@CATEGORYNAME", category);
         db.con.Open();
            if(db.cmd.ExecuteNonQuery() == 1)
             {
            return 1;
            }
            else
            {
            return -1;
            }
        }
        public static int updatecategories(string category, int id)
        {
        db.cmd = new SqlCommand("UPDATE CATEGORIES SET CATEGORYNAME= @CATEGORYNAME WHERE CATEGORYID= @CATEGORYID",db.con);
        db.cmd.Parameters.AddWithValue("@CATEGORYNAME", category);
        db.cmd.Parameters.AddWithValue("@CATEGORYID", id);

        db.con.Open();
            if (db.cmd.ExecuteNonQuery() == 1)
            {
                 return 1;
            }
            else
            {
                return -1;
            }
         }
        public static int deletecategories(int id)
         {
        db.cmd = new SqlCommand("DELETE FROM CATEGORIES WHERE CATEGORYID= @CATEGORYID", db.con);
        db.cmd.Parameters.AddWithValue("@CATEGORYID", id);

        db.con.Open();
            if (db.cmd.ExecuteNonQuery() == 1)
            {
            return 1;
            }
             else
             {
            return -1;
             }
         }
        public static int insertsuppliers(string[] supplier)
        {
        db.cmd = new SqlCommand("INSERT INTO SUPPLIERS(SUPPLIERNAME,CONTACTPERSON,PHONE,EMAIL) VALUES(@SUPPLIERNAME,@CONTACTPERSON,@PHONE,@EMAIL) ", db.con);
        db.cmd.Parameters.AddWithValue("@SUPPLIERNAME", supplier[0]);
        db.cmd.Parameters.AddWithValue("@CONTACTPERSON", supplier[1]);
        db.cmd.Parameters.AddWithValue("@PHONE", supplier[2]);
        db.cmd.Parameters.AddWithValue("@EMAIL", supplier[3]);
        db.con.Open();
        if (db.cmd.ExecuteNonQuery() == 1)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

        public static int updatesuppliers(string[] supplier, int supplierid)
        {

        db.cmd = new SqlCommand("UPDATE SUPPLIERS SET SUPPLIERNAME=@SUPPLIERNAME, CONTACTPERSON= @CONTACTPERSON, PHONE= @PHONE, EMAIL= @EMAIL WHERE SUPPLIERID= @SUPPLIERID ", db.con);
        db.cmd.Parameters.AddWithValue("@SUPPLIERNAME", supplier[0]);
        db.cmd.Parameters.AddWithValue("@CONTACTPERSON", supplier[1]);
        db.cmd.Parameters.AddWithValue("@PHONE", supplier[2]);
        db.cmd.Parameters.AddWithValue("@EMAIL", supplier[3]);
        db.cmd.Parameters.AddWithValue("@SUPPLIERID", supplierid);
        db.con.Open();
        if (db.cmd.ExecuteNonQuery() == 1)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
        public static int deletesuppliers(int id)
        {
        db.cmd = new SqlCommand(" ", db.con);
        db.cmd.Parameters.AddWithValue("@SUPPLIERID", id);
        db.con.Open();
        if (db.cmd.ExecuteNonQuery() == 1)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    public static string[]itemEncode (string id)
    {
        string[] items = new string[3];
        db.con.Open();
        db.cmd = new SqlCommand("SELECT ProductID, Description, UnitPrice FROM PRODUCTS WHERE PRODUCTID= @PRODUCTID", db.con);
        db.cmd.Parameters.AddWithValue("@PRODUCTID", id);
        db.dr = db.cmd.ExecuteReader();
        if (db.dr.Read())
        {

            items[0] = db.dr[0].ToString(); // productid
            items[1] = db.dr[1].ToString(); //desc
            items[2] = db.dr[2].ToString(); //unitprice
        }
        db.dr.Close();
        db.con.Close();
        return items;
    }

    public static void loadMovementStock()
    {
        db.con.Open();
        db.cmd = new SqlCommand("SELECT StockMovements.MovementID, StockMovements.ProductID, Warehouses.WarehouseName, StockMovements.MovementType,StockMovements.MovementDate, StockMovements.Quantity FROM StockMovements JOIN Warehouses ON StockMovements.WarehouseID = Warehouses.WarehouseID", db.con);
        db.dr = db.cmd.ExecuteReader();
    }
    public static void loadWarehouses()
    {
        db.con.Open();
        db.cmd = new SqlCommand("SELECT * FROM Warehouses", db.con);
        db.dr = db.cmd.ExecuteReader();

    }
    public static int insertMovementStock(string[] stock)
    {


        return 1;
    }
}
        





    

