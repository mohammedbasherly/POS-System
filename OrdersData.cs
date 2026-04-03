using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessTier
{
    public class clsOrdersData
    {
        static public int AddNewOrder(int Quantity, int ProductID, int ReceiptID)
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Orders VALUES
                             (@Quantity, @ProductID, @ReceiptID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            Command.Parameters.AddWithValue("@ReceiptID", ReceiptID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    ID = Convert.ToInt32(Result);
                else
                    ID = -1;

            }
            catch (Exception Ex)
            {
                ID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return ID;
        }

        static public bool UpdateOrder(int ID, int Quantity, int ProductID, int ReceiptID)
        {
            bool isUpdated = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"Update Orders
                             SET Quantity = @Quantity,
                                 ProductID = @ProductID,
                                 ReceiptID = @ReceiptID
                             WHERE ID = @ID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            Command.Parameters.AddWithValue("@ReceiptID", ReceiptID);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                isUpdated = RowsAffected > 0;

            }
            catch (Exception Ex)
            {
                isUpdated = false;
            }
            finally
            {
                Connection.Close();
            }


            return isUpdated;
        }

        static public bool DeleteOrder(int ID)
        {
            bool isDeleted = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Orders WHERE ID = @ID;";

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

        static public DataTable GetReceiptOrders(int ReceiptID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Orders WHERE ReceiptID = @ReceiptID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ReceiptID", ReceiptID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                dt.Load(Reader);

                Reader.Close();

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

        static public DataTable GetReceiptOrdersJoinedWithProducts(int ReceiptID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT Products.Name, Orders.Quantity, Products.Unit, Products.UnitPrice, Products.UnitPrice * Orders.Quantity as TotalPrice
                             FROM Orders
                             JOIN Products
                             ON Orders.ProductID = Products.ID
                             WHERE Orders.ReceiptID = @ReceiptID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ReceiptID", ReceiptID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                dt.Load(Reader);

                Reader.Close();

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

        static public bool IsOrderExist(int ProductID, int ReceiptID)
        {
            bool isExist = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT TOP 1 ID
                             FROM Orders
                             WHERE ProductID = @ProductID and ReceiptID = @ReceiptID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);
            Command.Parameters.AddWithValue("@ReceiptID", ReceiptID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    isExist = true;


            }
            catch (Exception Ex)
            {
                isExist = false;
            }
            finally
            {
                Connection.Close();
            }

            return isExist;
        }

        static public bool GetOrderByProductIDandReceiptID(ref int ID, ref int Quantity, int ProductID, int ReceiptID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT *
                             FROM Orders
                             WHERE ProductID = @ProductID and ReceiptID = @ReceiptID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ProductID", ProductID);
            Command.Parameters.AddWithValue("@ReceiptID", ReceiptID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    ID = Convert.ToInt32(Reader["ID"]);
                    Quantity = Convert.ToInt32(Reader["Quantity"]);

                    isFound = true;
                }

                Reader.Close();


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

        static public bool GetOrderByID(int ID, ref int Quantity, ref int ProductID, ref int ReceiptID)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT *
                             FROM Orders
                             WHERE ID = @ID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    Quantity = (int)Reader["Quantity"];
                    ProductID = (int)Reader["ProductID"];
                    ReceiptID = (int)Reader["ReceiptID"];
                }

                Reader.Close();
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

        static public DataTable GetAllOrdersOfDate(DateTime Date)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT Products.Name as Name, Orders.Quantity as Quantity, Products.UnitCost * Orders.Quantity as TotalCosts, Products.UnitPrice * Orders.Quantity as TotalSales, Receipts.ReceiptDate as Date
                             FROM Orders
                             JOIN Receipts
                             ON Orders.ReceiptID = Receipts.ID
                             JOIN Products
                             ON Orders.ProductID = Products.ID
                             WHERE CAST(Receipts.ReceiptDate as Date) = CAST(@ReceiptDate as Date);";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ReceiptDate", Date);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                dt.Load(Reader);

                Reader.Close();

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

    }
}
