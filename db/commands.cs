using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static Inventory_Management_System.db.db;

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
            cmd = new SqlCommand("INSERT INTO CATEGORIES(CATEGORYNAME) VALUES(@CATEGORYNAME)", con,t);
            cmd.Parameters.AddWithValue("@CATEGORYNAME", category);
            
            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch(Exception ex)
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
            cmd = new SqlCommand("UPDATE CATEGORIES SET CATEGORYNAME= @CATEGORYNAME WHERE CATEGORYID= @CATEGORYID", con,t);
            cmd.Parameters.AddWithValue("@CATEGORYNAME", category);
            cmd.Parameters.AddWithValue("@CATEGORYID", id);

            
            cmd.ExecuteNonQuery();
            t.Commit();
        }catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }catch(Exception ex)
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
            cmd = new SqlCommand("DELETE FROM CATEGORIES WHERE CATEGORYID= @CATEGORYID", con,t);
            cmd.Parameters.AddWithValue("@CATEGORYID", id);

            
            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }catch(Exception ex)
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
        }catch(Exception ex)
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
            cmd = new SqlCommand("UPDATE SUPPLIERS SET SUPPLIERNAME=@SUPPLIERNAME, CONTACTPERSON= @CONTACTPERSON, PHONE= @PHONE, EMAIL= @EMAIL WHERE SUPPLIERID= @SUPPLIERID ", con,t);
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
        }catch(Exception ex)
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
        catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }catch(Exception ex)
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
            cmd = new SqlCommand("INSERT INTO StockMovements(ProductID, WarehouseID, MovementType, Quantity) VALUES(@PRODUCTID, @WAREHOUSEID, @MOVEMENTTYPE,@QUANTITY)", con,t);
            cmd.Parameters.AddWithValue("@PRODUCTID", stock[0]);//productid
            cmd.Parameters.AddWithValue("@WAREHOUSEID", stock[1]);//warehouseid
            cmd.Parameters.AddWithValue("@QUANTITY", stock[2]);//quantity
            cmd.Parameters.AddWithValue("@MOVEMENTTYPE", stock[3]);//movementtype

            cmd.ExecuteNonQuery();

            t.Commit();
        }
        catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }
        catch(Exception ex)
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
            cmd = new SqlCommand("INSERT INTO WarehouseStock(ProductID, WarehouseID, QuantityStock) VALUES (@ProductID, @WarehouseID, @Quantity)", con,t);
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
        int query = 0;
        con.Open();
        cmd = new SqlCommand("SELECT QuantityStock FROM WarehouseStock WHERE ProductID= @ProductID AND WarehouseID= @WarehouseID", con);
        cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
        cmd.Parameters.AddWithValue("@WarehouseID", stock[1]);//warehouseid
        dr = cmd.ExecuteReader();
        if(dr.Read())
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
            cmd = new SqlCommand("UPDATE WarehouseStock SET QuantityStock= QuantityStock+@Quantity WHERE ProductID=@ProductID AND WarehouseID=@WarehouseID", con,t);
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
            cmd = new SqlCommand("UPDATE Products SET QuantityInStock= QuantityInStock+@Quantity WHERE PRODUCTID= @PRODUCTID", con,t);
            cmd.Parameters.AddWithValue("@ProductID", stock[0]);//productid
            cmd.Parameters.AddWithValue("@Quantity", stock[2]);//quantity
            
            cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }catch(Exception ex)
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
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID", con);

        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());

        con.Close();

        return dt;
    }

    public static DataTable searchInventory(string query, string filter)
    {

        con.Open();
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID WHERE Products.ProductID= @ProductID AND Categories.CategoryName= @CategoryName", con);
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
        cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID WHERE Products.ProductID= @ProductID", con);
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
                cmd.Parameters.AddWithValue("@CustomerID", data[0]);
                cmd.Parameters.AddWithValue("@SaleAmount", data[1]);

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
                string productID = string.Format("@p{0}", p+1);
                string quantity = string.Format("@p{0}", p+2);
                string total = string.Format("@p{0}", p+3);
                p += 4;

                //row
                String row = String.Format("({0}, {1}, {2}, {3})", orderID,productID,quantity,total);

                //add row
                if(batch > 0)
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

                if(batch >= 5)
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
            if(batch > 0)
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
        }catch(SqlException ex)
        {
            t.Rollback();
            throw ex;
        }catch(Exception ex)
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
}
        





    

