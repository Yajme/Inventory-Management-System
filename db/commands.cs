using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


    public static class commands
    {
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
}
        





    

