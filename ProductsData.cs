using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessTier
{
    public class clsProductsData
    {
        static public bool GetProductByID(int ID, ref string Barcode, ref string Unit, ref string ProdCompany, ref string Category, ref DateTime ProdDate, ref DateTime ExpDate, ref decimal UnitCost, ref Decimal UnitPrice, ref string Name)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Products WHERE ID = @ID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    Barcode = (string)Reader["Barcode"];
                    Unit = Reader["Unit"] != DBNull.Value ? (string)Reader["Unit"] : "";
                    ProdCompany = Reader["ProdCompany"] != DBNull.Value ? (string)Reader["ProdCompany"] : "";
                    Category = Reader["Category"] != DBNull.Value ? (string)Reader["Category"] : "";
                    ProdDate = Reader["ProdDate"] != DBNull.Value ? (DateTime)Reader["ProdDate"] : ProdDate;
                    ExpDate = Reader["ExpDate"] != DBNull.Value ? (DateTime)Reader["ExpDate"] : ExpDate;
                    UnitCost = Reader["UnitCost"] != DBNull.Value ? (decimal)Reader["UnitCost"] : -1;
                    UnitPrice = (decimal)Reader["UnitPrice"];
                    Name = (string)Reader["Name"];
                }
                else
                {
                    isFound = false;
                }


            }
            catch (Exception Ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        static public bool GetProductByBarcode(string Barcode, ref int ID ,ref string Unit, ref string ProdCompany, ref string Category, ref DateTime ProdDate, ref DateTime ExpDate, ref decimal UnitCost, ref Decimal UnitPrice, ref string Name)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Products WHERE Barcode = @Barcode;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Barcode", Barcode);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ID = Convert.ToInt32(Reader["ID"]);
                    Unit = Reader["Unit"] != DBNull.Value? (string)Reader["Unit"] : "";
                    ProdCompany = Reader["ProdCompany"] != DBNull.Value? (string)Reader["ProdCompany"] : "";
                    Category = Reader["Category"] != DBNull.Value? (string)Reader["Category"] : "";
                    ProdDate = Reader["ProdDate"] != DBNull.Value? (DateTime)Reader["ProdDate"] : ProdDate;
                    ExpDate = Reader["ExpDate"] != DBNull.Value ? (DateTime)Reader["ExpDate"] : ExpDate;
                    UnitCost = Reader["UnitCost"] != DBNull.Value? (decimal)Reader["UnitCost"] : -1;
                    UnitPrice = (decimal)Reader["UnitPrice"];
                    Name = (string)Reader["Name"];
                }
                else
                {
                    isFound = false;
                }

                Reader.Close();


            }
            catch (Exception Ex)
            {
                isFound = false;
                Console.WriteLine("Error: " + Ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        static public bool GetProductByName(string Name, ref int ID, ref string Barcode, ref string Unit, ref string ProdCompany, ref string Category, ref DateTime ProdDate, ref DateTime ExpDate, ref decimal UnitCost, ref Decimal UnitPrice)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Products WHERE Name = @Name;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Name", Name);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ID = (int)Reader["ID"];
                    Barcode = (string)Reader["Barcode"];
                    Unit = Reader["Unit"] != DBNull.Value? (string)Reader["Unit"] : "";
                    ProdCompany = Reader["ProdCompany"] != DBNull.Value? (string)Reader["ProdCompany"] : "";
                    Category = Reader["Category"] != DBNull.Value? (string)Reader["Category"] : "";
                    ProdDate = Reader["ProdDate"] != DBNull.Value? (DateTime)Reader["ProdDate"] : new DateTime(1900, 1, 1);
                    ExpDate = Reader["ExpDate"] != DBNull.Value? (DateTime)Reader["ExpDate"] : new DateTime(1900, 1, 1);
                    UnitCost = Reader["UnitCost"] != DBNull.Value? (decimal)Reader["UnitCost"] : -1;
                    UnitPrice = (decimal)Reader["UnitPrice"];
                }
                else
                {
                    isFound = false;
                }
            }
            catch (Exception Ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        static public bool IsProductExist(int ID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"Select ID FROM Products WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    isFound = true;
                else
                    isFound = false;

            }
            catch (Exception Ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        static public bool IsProductExist(string Barcode)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"Select Barcode FROM Products WHERE Barcode = @Barcode";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Barcode", Barcode);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    isFound = true;
                else
                    isFound = false;

            }
            catch (Exception Ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        static public bool DeleteProduct(int ID)
        {
            bool isDeleted = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Products WHERE ID = @ID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                isDeleted = RowsAffected > 0;

            }
            catch (Exception Ex)
            {
                isDeleted = false;
            }
            finally
            {
                Connection.Close();
            }

            return isDeleted;
        }

        static public bool DeleteProduct(string Barcode)
        {
            if (!IsProductExist(Barcode))
                return false;

            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"Delete FROM Products WHERE Barcode = @Barcode";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Barcode", Barcode);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                isFound = RowsAffected > 0;

            }
            catch (Exception Ex)
            {
                isFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
        }

        static public int AddNewProduct(string Barcode, string Unit, string ProdCompany, string Category,
                                DateTime ProdDate, DateTime ExpDate, decimal UnitCost, decimal UnitPrice, string Name)
        {
            int ID = -1;

            using (SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(@"
        INSERT INTO Products(Barcode, Unit, ProdCompany, Category, ProdDate, ExpDate, UnitCost, UnitPrice, Name) 
        VALUES (@Barcode, @Unit, @ProdCompany, @Category, @ProdDate, @ExpDate, @UnitCost, @UnitPrice, @Name);
        SELECT SCOPE_IDENTITY();", Connection))
            {
                Command.Parameters.AddWithValue("@Barcode", Barcode);
                Command.Parameters.AddWithValue("@Unit", string.IsNullOrEmpty(Unit) ? (object)DBNull.Value : Unit);
                Command.Parameters.AddWithValue("@ProdCompany", string.IsNullOrEmpty(ProdCompany) ? (object)DBNull.Value : ProdCompany);
                Command.Parameters.AddWithValue("@Category", string.IsNullOrEmpty(Category) ? (object)DBNull.Value : Category);
                Command.Parameters.AddWithValue("@ProdDate", ProdDate.Year != 1900 ? (object)ProdDate : DBNull.Value);
                Command.Parameters.AddWithValue("@ExpDate", (ExpDate.Year != 1900 && ProdDate <= ExpDate) ? (object)ExpDate : DBNull.Value);
                Command.Parameters.AddWithValue("@UnitCost", UnitCost != -1 ? (object)UnitCost : DBNull.Value);
                Command.Parameters.AddWithValue("@UnitPrice", UnitPrice != -1 ? (object)UnitPrice : 0);
                Command.Parameters.AddWithValue("@Name", Name);

                try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();
                    if (Result != null)
                    {
                        ID = Convert.ToInt32(Result); // 🔥 safe conversion
                    }
                }
                catch (Exception ex)
                {
                    ID = -1;
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return ID;
        }
        static public bool UpdateProduct(int ID, string Barcode, string Unit, string ProdCompany, string Category,
                                 DateTime ProdDate, DateTime ExpDate, decimal UnitCost, decimal UnitPrice, string Name)
        {
            bool isUpdated = false;

            using (SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand Command = new SqlCommand(@"
        UPDATE Products
        SET Barcode = @Barcode,
            Unit = @Unit,
            ProdCompany = @ProdCompany,
            Category = @Category,
            ProdDate = @ProdDate,
            ExpDate = @ExpDate,
            UnitCost = @UnitCost,
            UnitPrice = @UnitPrice,
            Name = @Name
        WHERE ID = @ID;", Connection))
            {
                // Parameters with null handling
                Command.Parameters.AddWithValue("@ID", ID);
                Command.Parameters.AddWithValue("@Barcode", Barcode);
                Command.Parameters.AddWithValue("@Unit", string.IsNullOrEmpty(Unit) ? (object)DBNull.Value : Unit);
                Command.Parameters.AddWithValue("@ProdCompany", string.IsNullOrEmpty(ProdCompany) ? (object)DBNull.Value : ProdCompany);
                Command.Parameters.AddWithValue("@Category", string.IsNullOrEmpty(Category) ? (object)DBNull.Value : Category);
                Command.Parameters.AddWithValue("@ProdDate", ProdDate.Year != 1900 ? (object)ProdDate : DBNull.Value);
                Command.Parameters.AddWithValue("@ExpDate", (ExpDate.Year != 1900 && ProdDate <= ExpDate) ? (object)ExpDate : DBNull.Value);
                Command.Parameters.AddWithValue("@UnitCost", UnitCost != -1 ? (object)UnitCost : DBNull.Value);
                Command.Parameters.AddWithValue("@UnitPrice", UnitPrice != -1 ? (object)UnitPrice : 0);
                Command.Parameters.AddWithValue("@Name", Name);

                try
                {
                    Connection.Open();
                    int rowsAffected = Command.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0; // True if update succeeded
                }
                catch (Exception ex)
                {
                    isUpdated = false;
                    Console.WriteLine("Error updating product: " + ex.Message);
                }
            }

            return isUpdated;
        }
        static public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT ID, Name, Barcode, Unit, ProdCompany, Category, ProdDate, ExpDate, UnitCost, UnitPrice
                             FROM Products;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                dt.Load(Reader);
            }
            catch (Exception Ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        static public int CountOfAllProducts()
        {
            int Count = 0;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT COUNT(ID) as CountOfProducts
                             FROM Products;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    Count = Convert.ToInt32(Result);
                }
            }
            catch (Exception Ex)
            {
                
            }
            finally
            {
                Connection.Close();
            }

            return Count;
        }

    }
}
