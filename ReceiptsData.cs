using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class clsReceiptsData
    {
        static public int AddNewReceipt(string PaymentMethod = "كاش")
        {
            int ID = -1;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                                INSERT INTO Receipts (ReceiptDate, PaymentMethod)
                                VALUES (GETDATE(), @PaymentMethod);
                                SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    ID = Convert.ToInt32(Result);
                }
                else
                {
                    ID = -1;
                }

            }
            catch (Exception Ex)
            {
                ID = -1;
                Console.WriteLine("Error: " + Ex.Message); 
            }
            finally
            {
                Connection.Close();
            }

            return ID;
        }

        static public bool GetReceiptByID(int ID, ref DateTime ReceiptDate, ref string PaymentMethod)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Receipts WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    ReceiptDate = (DateTime)Reader["ReceiptDate"];
                    PaymentMethod = (string)Reader["PaymentMethod"];
                }

                isFound = true;
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

        static public bool DeleteReceiptByID(int ID)
        {
            bool isDeleted = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Receipts WHERE ID = @ID;";

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

        static public bool ClearReceipt(int ID)
        {
            bool isCleared = false;

            SqlConnection Connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Orders
                             WHERE ReceiptID = @ReceiptID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ReceiptID", ID);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                isCleared = RowsAffected > 0;

            }
            catch (Exception Ex)
            {
                isCleared = false;
            }
            finally
            {
                Connection.Close();
            }

            return isCleared;
        }

        

    }
}
