using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using System.Data.Common;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public static class commands
    {
        public static void loadInventory()
        {
        db.con.Open();
        db.cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID", db.con);
        db.dr = db.cmd.ExecuteReader();
        }

        public static int insertInventory(string[] product)
        {
        
        db.cmd = new SqlCommand("INSERT INTO Products(ProductID,ProductName,Description,CategoryID,SupplierID,UnitPrice) VALUES(@PRODUCTID,@PRODUCTNAME,@DESCRIPTION,@CATEGORYID,@SUPPLIERID,@UNITPRICE)", db.con);
        db.cmd.Parameters.AddWithValue("@PRODUCTID", product[0]);
        db.cmd.Parameters.AddWithValue("@PRODUCTNAME", product[1]);
        db.cmd.Parameters.AddWithValue("@DESCRIPTION", product[2]);
        db.cmd.Parameters.AddWithValue("@CATEGORYID", product[3]);
        db.cmd.Parameters.AddWithValue("@SUPPLIERID", product[4]);
        db.cmd.Parameters.AddWithValue("@UNITPRICE", product[5]);
        db.con.Open();
        if(db.cmd.ExecuteNonQuery() == 1)
        {
            db.con.Close();
            return 1;
        }
        else
        {
            db.con.Close();
            return -1;
        }
        
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
        public static int categoryValidator(string category)
        {
        int id = 0;
        db.con.Open();
        db.cmd = new SqlCommand("SELECT CategoryID FROM Categories WHERE CategoryName= @CategoryName", db.con);
        db.cmd.Parameters.AddWithValue("@CategoryName", category);
        db.dr = db.cmd.ExecuteReader();
        if (db.dr.Read())
        {
            id = (int)db.dr[0];
        }
        db.con.Close();
        return id;
        }

        public static int supplierValidator(string supplier)
        {
        int id = 0;
        db.con.Open();
        db.cmd = new SqlCommand("SELECT SupplierID FROM Suppliers WHERE SupplierName= @SupplierName", db.con);
        db.cmd.Parameters.AddWithValue("@SupplierName", supplier);
        db.dr = db.cmd.ExecuteReader();
        if (db.dr.Read())
        {
            id = (int)db.dr[0];
        }
        db.con.Close();
        return id;
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
        string[] items = new string[4];
        db.con.Open();
        db.cmd = new SqlCommand("SELECT ProductID, Description, UnitPrice, QuantityInStock FROM PRODUCTS WHERE PRODUCTID= @PRODUCTID", db.con);
        db.cmd.Parameters.AddWithValue("@PRODUCTID", id);
        db.dr = db.cmd.ExecuteReader();
        if (db.dr.Read())
        {

            items[0] = db.dr[0].ToString(); // productid
            items[1] = db.dr[1].ToString(); //desc
            items[2] = db.dr[2].ToString(); //unitprice
            items[3] = db.dr[3].ToString(); //quantityinstock
        }
        else
        {
            db.dr.Close();
            db.con.Close();
            var empty3 = Array.Empty<string>();
            return empty3;
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
    public static int selectWarehouse(string warehousename)
    {
        int id = 0;
        db.con.Open();
        db.cmd = new SqlCommand("SELECT WarehouseID FROM Warehouses WHERE WarehouseName=@WarehouseName", db.con);
        db.cmd.Parameters.AddWithValue("@WarehouseName", warehousename);
        db.dr = db.cmd.ExecuteReader();
        if (db.dr.Read())
        {
            id = (int)db.dr[0];
        }
        db.dr.Close();
        db.con.Close();
        return id;
    }
    public static int insertMovementStock(string[] stock)
    {
        int query = 0;
        db.cmd = new SqlCommand("INSERT INTO StockMovements(ProductID, WarehouseID, MovementType, Quantity) VALUES(@PRODUCTID, @WAREHOUSEID, @MOVEMENTTYPE,@QUANTITY)", db.con);
        db.cmd.Parameters.AddWithValue("@PRODUCTID", stock[0]);//productid
        db.cmd.Parameters.AddWithValue("@WAREHOUSEID", stock[1]);//warehouseid
        db.cmd.Parameters.AddWithValue("@QUANTITY", stock[2]);//quantity
        db.cmd.Parameters.AddWithValue("@MOVEMENTTYPE", stock[3]);//movementtype
        db.con.Open();
        if(db.cmd.ExecuteNonQuery() == 1)
        {
            query = 1;
        }
        db.con.Close();
        return query;
    }
    public static int insertStocktoWarehouse(string[] stock)
    {
        int query = 0;
        db.cmd = new SqlCommand("INSERT INTO WarehouseStock(ProductID, WarehouseID,QuantityStock) VALUES (@ProductID,@WarehouseID,@Quantity)", db.con);
        db.cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
        db.cmd.Parameters.AddWithValue("@WarehouseID", stock[1]);//warehouseid
        db.cmd.Parameters.AddWithValue("@Quantity", stock[2]);//quantity
        db.con.Open();
        if (db.cmd.ExecuteNonQuery() == 1)
        {
            query = 1;
        }
        db.con.Close();
        return query;
    }
    public static int stockWarehouseValidator(string[] stock)
    {
        int query = 0;
        db.con.Open();
        db.cmd = new SqlCommand("SELECT * FROM WarehouseStock WHERE ProductID= @ProductID AND WarehouseID= @WarehouseID",db.con);
        db.cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
        db.cmd.Parameters.AddWithValue("@WarehouseID", stock[1]);//warehouseid
        db.dr = db.cmd.ExecuteReader();
        if (!db.dr.HasRows)
        {
            query= 1;

        }


        db.con.Close();
        return query;
    }
    public static int updateStocktoWarehouse(string[] stock)
    {
        int query = 0;
        db.cmd = new SqlCommand("UPDATE WarehouseStock SET QuantityStock= QuantityStock+@Quantity WHERE ProductID=@ProductID AND WarehouseID=@WarehouseID", db.con);
        db.cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
        db.cmd.Parameters.AddWithValue("@WarehouseID", stock[1]);//warehouseid
        db.cmd.Parameters.AddWithValue("@Quantity", stock[2]);//quantity
        db.con.Open();
        if(db.cmd.ExecuteNonQuery() == 1)
        {
            query = 1;
        }
        db.con.Close();
        return query;
    }

    public static string[] checkProductWarehouse(string[] stock)
    {
        string[] item = new string[2];



        return item;
    }

    public static int updateProductsStocks(string[] stock)
    {
        int query = 0;



        return query;
    }
    private static void beginTransaction()
    {

    }
}
        





    

