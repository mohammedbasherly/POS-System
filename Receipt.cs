using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsReceipt
    {
        public int ID { set; get; }
        public DateTime ReceiptDate { get; set; }
        public string PaymentMethod { get; set; }

        public clsReceipt(int ID, DateTime ReceiptDate, string PaymentMethod)
        {
            this.ID = ID;
            this.ReceiptDate = ReceiptDate;
            this.PaymentMethod = PaymentMethod;
        }

        static public clsReceipt Find(int ID)
        {
            DateTime ReceiptDate = new DateTime(1900, 1, 1);
            string PaymentMethod = "";
            if (DataAccessTier.clsReceiptsData.GetReceiptByID(ID, ref ReceiptDate, ref PaymentMethod))
            {
                return new clsReceipt(ID, ReceiptDate, PaymentMethod);
            }
            else
            {
                return null;
            }
        }

        static public clsReceipt CreateReceipt(string PaymentMethod = "كاش")
        {
            int ID = DataAccessTier.clsReceiptsData.AddNewReceipt(PaymentMethod);

            if (ID != -1)
            {
                return Find(ID);
            }
            else
            {
                return null;
            }

        }

        static public bool DeleteReciept(int ID)
        {
            return DataAccessTier.clsReceiptsData.DeleteReceiptByID(ID);
        }

        static public bool ClearReceipt(int ID)
        {
            return DataAccessTier.clsReceiptsData.ClearReceipt(ID);
        }

        

    }

}
