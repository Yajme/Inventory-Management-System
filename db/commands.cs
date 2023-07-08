using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static Inventory_Management_System.db.db;
using Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms.frmReciept.DataSetFiles;
public static class commands
{

    public static void dbclose()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }



    public static void insertInventory(string[] product)
    {

        con.Open();
        SqlTransaction t = con.BeginTransaction();

        try
        {
            cmd = new SqlCommand("INSERT INTO Products(ProductID,ProductName,Description,CategoryID,SupplierID,UnitPrice) VALUES(@PRODUCTID,@PRODUCTNAME,@DESCRIPTION,@CATEGORYID,@SUPPLIERID,@UNITPRICE)", con, t);
            cmd.Parameters.AddWithValue("@PRODUCTID", product[0]);
            cmd.Parameters.AddWithValue("@PRODUCTNAME", product[1]);
            cmd.Parameters.AddWithValue("@DESCRIPTION", product[2]);
            cmd.Parameters.AddWithValue("@CATEGORYID", product[3]);
            cmd.Parameters.AddWithValue("@SUPPLIERID", product[4]);
            cmd.Parameters.AddWithValue("@UNITPRICE", product[5]);
            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }

    }
    public static DataTable loadsuppliers()
    {
        DataTable dt = new DataTable();
        con.Open();
        cmd = new SqlCommand("SELECT * FROM SUPPLIERS", con);
        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }
    public static DataTable loadcategories()
    {
        con.Open();
        cmd = new SqlCommand("SELECT * FROM CATEGORIES", con);
        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }
    public static void insertcategories(string category)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("INSERT INTO CATEGORIES(CATEGORYNAME) VALUES(@CATEGORYNAME)", con, t);
            cmd.Parameters.AddWithValue("@CATEGORYNAME", category);

            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }


    }
    public static void updatecategories(string category, int id)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("UPDATE CATEGORIES SET CATEGORYNAME= @CATEGORYNAME WHERE CATEGORYID= @CATEGORYID", con, t);
            cmd.Parameters.AddWithValue("@CATEGORYNAME", category);
            cmd.Parameters.AddWithValue("@CATEGORYID", id);


            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }


    }
    public static void deletecategories(int id)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("DELETE FROM CATEGORIES WHERE CATEGORYID= @CATEGORYID", con, t);
            cmd.Parameters.AddWithValue("@CATEGORYID", id);


            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }


    }
    public static int categoryValidator(string category)
    {
        int id = 0;
        con.Open();
        cmd = new SqlCommand("SELECT CategoryID FROM Categories WHERE CategoryName= @CategoryName", con);
        cmd.Parameters.AddWithValue("@CategoryName", category);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            id = (int)dr[0];
        }
        con.Close();
        return id;
    }

    public static int supplierValidator(string supplier)
    {
        int id = 0;
        con.Open();
        cmd = new SqlCommand("SELECT SupplierID FROM Suppliers WHERE SupplierName= @SupplierName", con);
        cmd.Parameters.AddWithValue("@SupplierName", supplier);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            id = (int)dr[0];
        }
        con.Close();
        return id;
    }
    public static void insertsuppliers(string[] supplier)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("INSERT INTO SUPPLIERS(SUPPLIERNAME,CONTACTPERSON,PHONE,EMAIL) VALUES(@SUPPLIERNAME,@CONTACTPERSON,@PHONE,@EMAIL) ", con, t);
            cmd.Parameters.AddWithValue("@SUPPLIERNAME", supplier[0]);
            cmd.Parameters.AddWithValue("@CONTACTPERSON", supplier[1]);
            cmd.Parameters.AddWithValue("@PHONE", supplier[2]);
            cmd.Parameters.AddWithValue("@EMAIL", supplier[3]);

            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public static void updatesuppliers(string[] supplier, int supplierid)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("UPDATE SUPPLIERS SET SUPPLIERNAME=@SUPPLIERNAME, CONTACTPERSON= @CONTACTPERSON, PHONE= @PHONE, EMAIL= @EMAIL WHERE SUPPLIERID= @SUPPLIERID ", con, t);
            cmd.Parameters.AddWithValue("@SUPPLIERNAME", supplier[0]);
            cmd.Parameters.AddWithValue("@CONTACTPERSON", supplier[1]);
            cmd.Parameters.AddWithValue("@PHONE", supplier[2]);
            cmd.Parameters.AddWithValue("@EMAIL", supplier[3]);
            cmd.Parameters.AddWithValue("@SUPPLIERID", supplierid);

            cmd.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }

    }
    public static void deletesuppliers(int id)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("DELETE FROM SUPPLIERS WHERE SUPPLIERID= @SUPPLIERID", con, t);
            cmd.Parameters.AddWithValue("@SUPPLIERID", id);

            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }



    }

    public static string[] itemEncode(string id)
    {
        string[] items = new string[4];
        con.Open();
        cmd = new SqlCommand("SELECT ProductID, Description, UnitPrice, QuantityInStock FROM PRODUCTS WHERE PRODUCTID= @PRODUCTID", con);
        cmd.Parameters.AddWithValue("@PRODUCTID", id);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            items[0] = dr[0].ToString(); // productid
            items[1] = dr[1].ToString(); //desc
            items[2] = dr[2].ToString(); //unitprice
            items[3] = dr[3].ToString(); //quantityinstock
        }
        else
        {
            dr.Close();
            con.Close();
            var empty3 = Array.Empty<string>();
            return empty3;
        }
        dr.Close();
        con.Close();
        return items;
    }

    public static DataTable loadMovementStock()
    {
        con.Open();
        cmd = new SqlCommand("SELECT StockMovements.MovementID, StockMovements.ProductID, Warehouses.WarehouseName, StockMovements.MovementType,StockMovements.MovementDate, StockMovements.Quantity FROM StockMovements JOIN Warehouses ON StockMovements.WarehouseID = Warehouses.WarehouseID", con);
        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }
    public static DataTable loadWarehouses()
    {
        con.Open();
        cmd = new SqlCommand("SELECT * FROM Warehouses", con);

        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();
        return dt;
    }
    public static int selectWarehouse(string warehousename)
    {
        int id = 0;

        con.Open();
        cmd = new SqlCommand("SELECT WarehouseID FROM Warehouses WHERE WarehouseName=@WarehouseName", con);
        cmd.Parameters.AddWithValue("@WarehouseName", warehousename);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            id = (int)dr[0];
        }
        dr.Close();
        con.Close();
        return id;
    }
    public static void insertMovementStock(string[] stock)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();



        try
        {
            cmd = new SqlCommand("INSERT INTO StockMovements(ProductID, WarehouseID, MovementType, Quantity) VALUES(@PRODUCTID, @WAREHOUSEID, @MOVEMENTTYPE,@QUANTITY)", con, t);
            cmd.Parameters.AddWithValue("@PRODUCTID", stock[0]);//productid
            cmd.Parameters.AddWithValue("@WAREHOUSEID", stock[1]);//warehouseid
            cmd.Parameters.AddWithValue("@QUANTITY", stock[2]);//quantity
            cmd.Parameters.AddWithValue("@MOVEMENTTYPE", stock[3]);//movementtype

            cmd.ExecuteNonQuery();

            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }

    }
    public static void insertStocktoWarehouse(string[] stock)
    {

        con.Open();
        SqlTransaction t = con.BeginTransaction();

        try
        {
            cmd = new SqlCommand("INSERT INTO WarehouseStock(ProductID, WarehouseID, QuantityStock) VALUES (@ProductID, @WarehouseID, @Quantity)", con, t);
            cmd.Parameters.AddWithValue("@ProductID", stock[0]); // productid
            cmd.Parameters.AddWithValue("@WarehouseID", stock[1]); // warehouseid
            cmd.Parameters.AddWithValue("@Quantity", stock[2]); // quantity


            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }


    }
    public static int stockWarehouseValidator(string[] stock)
    {
        int query = -1;
        con.Open();
        cmd = new SqlCommand("SELECT QuantityStock FROM WarehouseStock WHERE ProductID= @ProductID AND WarehouseID= @WarehouseID", con);
        cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
        cmd.Parameters.AddWithValue("@WarehouseID", stock[1]);//warehouseid
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            query = (int)dr[0];
        }



        con.Close();
        return query;
    }
    public static void updateStocktoWarehouse(string[] stock)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();

        try
        {
            cmd = new SqlCommand("UPDATE WarehouseStock SET QuantityStock= QuantityStock+@Quantity WHERE ProductID=@ProductID AND WarehouseID=@WarehouseID", con, t);
            cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
            cmd.Parameters.AddWithValue("@WarehouseID", stock[1]);//warehouseid
            cmd.Parameters.AddWithValue("@Quantity", stock[2]);//quantity

            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public static void updateProductsStocks(string[] stock)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("UPDATE Products SET QuantityInStock= QuantityInStock+@Quantity WHERE PRODUCTID= @PRODUCTID", con, t);
            cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
            cmd.Parameters.AddWithValue("@Quantity", stock[2]);//quantity

            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }



    }

    public static DataTable viewWarehouseStock()
    {
        DataTable dt = new DataTable();
        con.Open();
        cmd = new SqlCommand("SELECT WarehouseStock.ProductStockID, Warehouses.WarehouseName, WarehouseStock.ProductID, WarehouseStock.QuantityStock FROM WarehouseStock JOIN Warehouses ON WarehouseStock.WarehouseID = Warehouses.WarehouseID", con);
        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }
    public static DataTable searchWarehouseStock(string[] stock)
    {

        DataTable dt = new DataTable();
        con.Open();
        cmd = new SqlCommand("SELECT WarehouseStock.ProductStockID, Warehouses.WarehouseName, WarehouseStock.ProductID, WarehouseStock.QuantityStock FROM WarehouseStock JOIN Warehouses ON WarehouseStock.WarehouseID = Warehouses.WarehouseID  WHERE WarehouseStock.ProductID = @ProductID AND Warehouses.WarehouseName= @Warehouse", con);
        cmd.Parameters.AddWithValue("@ProductID", stock[0]);
        cmd.Parameters.AddWithValue("@Warehouse", stock[1]);

        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }

    public static DataTable selectWarehouseStock(string warehouse)
    {

        DataTable dt = new DataTable();
        con.Open();
        cmd = new SqlCommand("SELECT WarehouseStock.ProductStockID, Warehouses.WarehouseName, WarehouseStock.ProductID, WarehouseStock.QuantityStock FROM WarehouseStock JOIN Warehouses ON WarehouseStock.WarehouseID = Warehouses.WarehouseID WHERE Warehouses.WarehouseName= @Warehouse", con);
        cmd.Parameters.AddWithValue("@Warehouse", warehouse);

        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }
    public static DataTable selecthWarehouseProduct(string productID)
    {

        DataTable dt = new DataTable();
        con.Open();
        cmd = new SqlCommand("SELECT WarehouseStock.ProductStockID, Warehouses.WarehouseName, WarehouseStock.ProductID, WarehouseStock.QuantityStock FROM WarehouseStock JOIN Warehouses ON WarehouseStock.WarehouseID = Warehouses.WarehouseID WHERE WarehouseStock.ProductID = @ProductID", con);
        cmd.Parameters.AddWithValue("@ProductID", productID);

        dt.Load(cmd.ExecuteReader());
        con.Close();
        return dt;
    }
    public static DataTable demo()
    {

        con.Open();
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID", con);

        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();

        return dt;
    }

    public static DataTable loadInventory()
    {

        con.Open();
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName,Products.ReorderLevel\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID", con);

        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();

        return dt;
    }

    public static DataTable searchInventory(string query, string filter)
    {

        con.Open();
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName,Products.ReorderLevel\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID WHERE Products.ProductID= @ProductID AND Categories.CategoryName= @CategoryName", con);
        cmd.Parameters.AddWithValue("@ProductID", query);

        cmd.Parameters.AddWithValue("@CategoryName", filter);



        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();

        return dt;
    }

    public static DataTable searchInventoryWOC(string query)
    {

        con.Open();
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName,Products.ReorderLevel\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID WHERE Products.ProductID= @ProductID", con);
        cmd.Parameters.AddWithValue("@ProductID", query);




        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();

        return dt;
    }
    public static DataTable filterCategory(string filter)
    {
        con.Open();
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID WHERE Categories.CategoryName= @CategoryName", con);
        cmd.Parameters.AddWithValue("@CategoryName", filter);

        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();

        return dt;

    }
    //public static int OrderID = 0;


    public static void insertOrder(string[] data, DataTable OrderItems)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();

        try
        {

            //Order
            /*
             CREATE PROCEDURE InsertOrder --ProcedureName
	@CustomerID INT, -- ParameterName with DataType
	@SaleAmount DECIMAL(18,2), --ParameterName with DataType 
	@OrderID INT OUTPUT -- ID Fetched
AS
BEGIN

	INSERT INTO Orders(CustomerID, SaleAmount) VALUES(@CustomerID,@SaleAmount);

	SET @OrderID= SCOPE_IDENTITY();

	SELECT OrderID FROM Orders WHERE OrderID= @OrderID;

END
             */
            string ordercommand = "DECLARE @ReturnedID INT;\r\n\r\nEXEC InsertOrder \r\n\t@CustomerID,\r\n\t@SaleAmount,\r\n\t@OrderID = @ReturnedID OUTPUT;\r\n\r\nSELECT @ReturnedID as 'ReturnedID';";
            //cmd = new SqlCommand(ordercommand, con, t);

            int orderid = 0;
            //cmd.ExecuteNonQuery();
            using (cmd = new SqlCommand(ordercommand, con, t))
            {
                // cmd.Parameters.AddWithValue("@CustomerID", data[0]);
                //cmd.Parameters.AddWithValue("@SaleAmount", data[1]);


                cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = data[0];
                cmd.Parameters.Add("@SaleAmount", SqlDbType.Decimal).Value = data[1];



                orderid = (int)cmd.ExecuteScalar();
            }


            //cmd = new SqlCommand("SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC", con, t);
            /*
            using (cmd = new SqlCommand("SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC", con, t)) 
            {
                orderid += Convert.ToInt32(cmd.ExecuteScalar());
            }*/

            cmd.Parameters.Clear();
            int p = 1;
            int batch = 0;
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in OrderItems.Rows)
            {
                //Parameter Name
                string orderID = string.Format("@p{0}", p);
                string productID = string.Format("@p{0}", p + 1);
                string quantity = string.Format("@p{0}", p + 2);
                string total = string.Format("@p{0}", p + 3);
                p += 4;

                //row
                String row = String.Format("({0}, {1}, {2}, {3})", orderID, productID, quantity, total);

                //add row
                if (batch > 0)
                {
                    sb.AppendLine(",");
                }
                sb.Append(row);
                batch++;

                //add parameters
                cmd.Parameters.Add(orderID, SqlDbType.Int).Value = orderid;
                cmd.Parameters.Add(productID, SqlDbType.VarChar).Value = dr[0];
                cmd.Parameters.Add(quantity, SqlDbType.Int).Value = dr[1];
                cmd.Parameters.Add(total, SqlDbType.Decimal).Value = dr[2];

                if (batch >= 5)
                {
                    string sql = "INSERT INTO OrderItems(OrderID,ProductID,Quantity,UnitPrice) VALUES" + "\r\n" + sb.ToString();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    sb.Clear();
                    batch = 0;
                    p = 1;
                }
            }
            if (batch > 0)
            {
                string sql = "INSERT INTO OrderItems(OrderID,ProductID,Quantity,UnitPrice) VALUES" + "\r\n" + sb.ToString();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }

            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }


    public static void insertWarehouse(string[] warehouse)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("INSERT INTO Warehouses(WarehouseName, Location) VALUES(@WarehouseName, @Location)", con, t);
            cmd.Parameters.AddWithValue("@WarehouseName", warehouse[0]);
            cmd.Parameters.AddWithValue("@Location", warehouse[1]);

            cmd.ExecuteNonQuery();


            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }

    }
    public static void updateWarehouse(string[] warehouse, int warehouseID)
    {

        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("UPDATE Warehouses SET WarehouseName= @WarehouseName, Location= @Location WHERE WarehouseID= @WarehouseID", con, t);
            cmd.Parameters.AddWithValue("@WarehouseName", warehouse[0]);
            cmd.Parameters.AddWithValue("@Location", warehouse[1]);
            cmd.Parameters.AddWithValue("@WarehouseID", warehouseID);
            con.Open();
            cmd.ExecuteNonQuery();



            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public static void deleteWarehouse(int warehouseID)
    {
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("DELETE FROM Warehouses WHERE WarehouseID= @WarehouseID", con, t);
            cmd.Parameters.AddWithValue("@WarehouseID", warehouseID);
            con.Open();
            cmd.ExecuteNonQuery();

            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }

    }

    public static DataTable loadEligibleExchangeReturn()
    {
        DataTable dt = new DataTable();
        con.Open();

        cmd = new SqlCommand("SELECT Orders.OrderID, Customers.CustomerName ,Orders.TransactionDateTime FROM Orders JOIN Customers ON Orders.CustomerID = Customers.CustomerID where Orders.TransactionDateTime >= CURRENT_TIMESTAMP -30\r\n", con);
        dt.Load(cmd.ExecuteReader());

        con.Close();
        return dt;
    }

    public static DataTable loadEligbleItems(int OrderID)
    {


        DataTable dt = new DataTable();
        con.Open();

        cmd = new SqlCommand("SELECT OrderItems.OrderItemID, Products.Description, OrderItems.Quantity, OrderItems.UnitPrice FROM OrderItems JOIN Products ON OrderItems.ProductID = Products.ProductID WHERE OrderItems.OrderID = @OrderID;", con);
        cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = OrderID;
        dt.Load(cmd.ExecuteReader());

        con.Close();
        return dt;

    }

    /** 
     * 
SELECT Products.Description, SUM(OrderItems.Quantity) as TotalSold, SUM(OrderItems.UnitPrice) as TotalSale
FROM Products 
JOIN OrderItems ON Products.ProductID = OrderItems.ProductID
GROUP BY  Products.Description
ORDER BY TotalSale DESC


SELECT Products.Description, SUM(OrderItems.Quantity) as TotalSold, SUM(OrderItems.UnitPrice) as TotalSale
FROM Products 
JOIN OrderItems ON Products.ProductID = OrderItems.ProductID
GROUP BY  Products.Description
ORDER BY TotalSold DESC

SELECT COUNT (*) as lowStock FROM Products WHERE ReorderLevel > QuantityInStock

    SELECT Products.Description, Products.QuantityInStock, Products.ReorderLevel,SUM(WarehouseStock.QuantityStock) as WarehouseStock  
FROM Products 
JOIN WarehouseStock ON Products.ProductID = WarehouseStock.ProductID
GROUP BY Products.Description,Products.QuantityInStock, Products.ReorderLevel


SELECT Products.Description, Products.QuantityInStock, Products.ReorderLevel,SUM(WarehouseStock.QuantityStock) as WarehouseStocks   FROM Products  JOIN WarehouseStock ON Products.ProductID = WarehouseStock.ProductID WHERE WarehouseStock.QuantityStock+Products.QuantityInStock  < Products.ReorderLevel GROUP BY Products.Description,Products.QuantityInStock, Products.ReorderLevel 

   
     * 
     * 
     * 
     * 
     * 
     * 
     * **/


    public static DataTable saleReport()
    {
        DataTable dt = new DataTable();
        con.Open();
        //cmd = new SqlCommand("SELECT SUM(SaleAmount) as TotalSale,FORMAT(TransactionDateTime, 'MM/dd/yy') as Date FROM Orders GROUP BY FORMAT(TransactionDateTime, 'MM/dd/yy')", con);
        cmd = new SqlCommand("SELECT SUM(SaleAmount) as TotalSale, '01/'+FORMAT(TransactionDateTime, 'MM/yyyy') as Month\r\nFROM Orders\r\nWHERE TransactionDateTime BETWEEN DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0) AND DATEADD(DAY, -1, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()) + 1, 0))\r\nGROUP BY FORMAT(TransactionDateTime, 'MM/yyyy');", con);
        dt.Load(cmd.ExecuteReader());
        con.Close();


        return dt;
    }
   
    public static void returnItem(DataTable returns, string[] record)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {

            /*               
    CREATE PROCEDURE InsertReturnExchangeRecord
	@OrderID INT,
	@Status varchar(50),
	@Remarks varchar(255),
	@TransactionID INT OUTPUT
AS
BEGIN
INSERT INTO ReturnExchangeRecords (OrderID,Status,Remarks) VALUES (@OrderID, @Status,@Remarks);

SET @TransactionID=SCOPE_IDENTITY();

SELECT TransactionID FROM ReturnExchangeRecords WHERE TransactionID= @TransactionID;

END*/

            int transactionID = 0;
            using (cmd = new SqlCommand("DECLARE @ReturnedID INT;EXEC InsertReturnExchangeRecord @OrderID, @Status,@Remarks, @TransactionID= @ReturnedID OUTPUT;SELECT @ReturnedID as 'ReturnedID';", con, t))
            {
                cmd.Parameters.AddWithValue("@OrderID", SqlDbType.Int).Value = record[0];
                cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = record[1];
                cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = record[2];
                transactionID = (int)cmd.ExecuteScalar();
            }

            cmd.Parameters.Clear();
            int p = 1;
            int batch = 0;
            StringBuilder sb = new StringBuilder();
            foreach (DataRow dr in returns.Rows)
            {
                //Parameter Name
                string TransactionID = string.Format("@p{0}", p);
                string productID = string.Format("@p{0}", p + 1);
                string quantity = string.Format("@p{0}", p + 2);
                string total = string.Format("@p{0}", p + 3);
                p += 4;

                //row
                String row = String.Format("({0}, {1}, {2}, {3})", TransactionID, productID, quantity, total);

                //add row
                if (batch > 0)
                {
                    sb.AppendLine(",");
                }
                sb.Append(row);
                batch++;

                //add parameters
                cmd.Parameters.Add(TransactionID, SqlDbType.Int).Value = transactionID;
                cmd.Parameters.Add(productID, SqlDbType.VarChar).Value = dr[0];
                cmd.Parameters.Add(quantity, SqlDbType.Int).Value = dr[1];
                cmd.Parameters.Add(total, SqlDbType.Decimal).Value = dr[2];

                if (batch >= 5)
                {
                    string sql = "INSERT INTO ReturnItem(TransactionID,ProductID,Quantity,RefundAmount) VALUES" + "\r\n" + sb.ToString();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    sb.Clear();
                    batch = 0;
                    p = 1;
                }
            }
            if (batch > 0)
            {
                string sql = "INSERT INTO ReturnItem(TransactionID,ProductID,Quantity,RefundAmount) VALUES" + "\r\n" + sb.ToString();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();

            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    /*                 
     
     con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            cmd = new SqlCommand("", con, t);

            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
     
     
     
     
     
     */

    public static DataTable selectOrderID(int[] orderitemID)
    {
        DataTable dt = new DataTable();
        con.Open();
        string command = "SELECT ProductID, Quantity, UnitPrice,OrderItemID FROM OrderItems WHERE OrderItemID= @OrderItemID";
        for (int i = 0; i < orderitemID.Length; i++)
        {
            using (cmd = new SqlCommand(command, con))
            {
                cmd.Parameters.AddWithValue("@OrderItemID", SqlDbType.Int).Value = orderitemID[i];
                dt.Load(cmd.ExecuteReader());
                cmd.Parameters.Clear();
            }
        }

        con.Close();
        return dt;
    }

    public static int exchangeItem(string [] productExchanged, string[] record) //Product-> product that is returned and will be exchanged with datatable productExchanged
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        int transactionID = 0;
        try
        {
            
            using (cmd = new SqlCommand("DECLARE @ReturnedID INT;EXEC InsertReturnExchangeRecord @OrderID, @Status,@Remarks, @TransactionID= @ReturnedID OUTPUT;SELECT @ReturnedID as 'ReturnedID';", con, t))
            {
                cmd.Parameters.AddWithValue("@OrderID", SqlDbType.Int).Value = record[0];
                cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = record[1];
                cmd.Parameters.AddWithValue("@Remarks", SqlDbType.VarChar).Value = record[2];
                transactionID = (int)cmd.ExecuteScalar();
            }

            cmd.Parameters.Clear();

            cmd = new SqlCommand("INSERT INTO ExchangeItem(TransactionID,StoreCreditAmount,StoreCreditBarcode) VALUES(@TransactionID,@Amount,@Barcode);", con, t);
            
                cmd.Parameters.AddWithValue("@TransactionID", SqlDbType.Int).Value = transactionID;
                cmd.Parameters.AddWithValue("@Amount", SqlDbType.Decimal).Value = productExchanged[0]; //amount
                cmd.Parameters.AddWithValue("@Barcode", SqlDbType.VarChar).Value = productExchanged[1]; //barcode

            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }

        return transactionID;
    }

    public static DataSet1 selectExchangeItem(int transactionID)
    {
        DataSet1 ds = new DataSet1();
        con.Open();

        cmd = new SqlCommand("SELECT TransactionID, StoreCreditAmount,StoreCreditBarcode FROM ExchangeItem WHERE TransactionID= @TransactionID", con);
        cmd.Parameters.AddWithValue("@TransactionID", SqlDbType.Int).Value = transactionID;

        sda = new SqlDataAdapter(cmd);

        sda.Fill(ds.Tables["StoreCredit"]);

        con.Close();

        return ds;
    }

    public static void insertPurchaseOrder(DataTable Invoice, int SupplierID)
    {
        con.Open();
        SqlTransaction t = con.BeginTransaction();
        try
        {
            int PurchaseID = 0;
            using (cmd = new SqlCommand("DECLARE @ReturnedID INT;\r\n EXEC InsertPurchaseOrder @SupplierID, @PurchaseID= @ReturnedID OUTPUT; SELECT @ReturnedID as 'ReturnedID';  ", con, t))
            {
                cmd.Parameters.AddWithValue("@SupplierID", SqlDbType.Int).Value = SupplierID;
                PurchaseID = (int)cmd.ExecuteScalar();
            }

            int p = 1, batch = 0;
            StringBuilder sb = new StringBuilder();

            foreach(DataRow row in Invoice.Rows)
            {
                //PurchaseID, ProductID, Quantity
                string purchaseID = String.Format("@p{0}", p);
                string productID = String.Format("@p{0}", p + 1);
                string Quantity = String.Format("@p{0}", p + 2);


                p += 3;

                String Row = String.Format("({0},{1},{2})", purchaseID,productID,Quantity);
                if (batch > 0)
                {
                    sb.AppendLine(",");
                }
                sb.Append(Row);
                batch++;

                cmd.Parameters.AddWithValue(purchaseID, SqlDbType.Int).Value = PurchaseID;
                cmd.Parameters.AddWithValue(productID, SqlDbType.VarChar).Value = row[0];
                cmd.Parameters.AddWithValue(Quantity, SqlDbType.Int).Value = row[1];

                if (batch >= 5)
                {
                    string sql = "INSERT INTO PurchaseInvoice(PurchaseID, ProductID, Quantity) VALUES" + "\r\n" + sb.ToString();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    sb.Clear();
                    batch = 0;
                    p = 1;
                }
            }
            if (batch > 0)
            {
                string sql = "INSERT INTO PurchaseInvoice(PurchaseID, ProductID, Quantity) VALUES" + "\r\n" + sb.ToString();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
           
            }
            t.Commit();
        }
        catch (SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch (Exception ex)
        {
            t.Rollback();
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }
}









