using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;

namespace BusinessTier
{
    public class clsOrder
    {
        public int ID { set; get; }
        public int Quantity { set; get; }
        public int ProductID { set; get; }
        public int ReceiptID { set; get; }
        //public enum enMode { AddNew = 1, Update = 2 };
        //enMode Mode;

        public clsOrder()
        {
            this.ID = -1;
            this.Quantity = 0;
            this.ProductID = -1;
            this.ReceiptID = -1;
        }

        private clsOrder(int ID, int Quantity, int ProductID, int ReceiptID)
        {
            this.ID = ID;
            this.Quantity = Quantity;
            this.ProductID = ProductID;
            this.ReceiptID = ReceiptID;
        }

        static public clsOrder CreateOrder(int Quantity, int ProductID, int ReceiptID)
        {
            int ID = DataAccessTier.clsOrdersData.AddNewOrder(Quantity, ProductID, ReceiptID);
            if (ID != -1)
            {
                return new clsOrder(ID, Quantity, ProductID, ReceiptID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            if (this.ID == -1)
            {
                ID = DataAccessTier.clsOrdersData.AddNewOrder(this.Quantity, this.ProductID, this.ReceiptID);
                return ID != -1;
            }

            return DataAccessTier.clsOrdersData.UpdateOrder(this.ID, this.Quantity, this.ProductID, this.ReceiptID);
        }

        static public bool DeleteOrder(int ID)
        {
            return DataAccessTier.clsOrdersData.DeleteOrder(ID);
        }

        static public DataTable LoadReceiptOrders(int ReceiptID)
        {
            return DataAccessTier.clsOrdersData.GetReceiptOrders(ReceiptID);
        }

        static public DataTable LoadReceiptOrdersJoinedWithProducts(int ReceiptID)
        {
            return DataAccessTier.clsOrdersData.GetReceiptOrdersJoinedWithProducts(ReceiptID);
        }

        static public bool IsOrderExist(int ProductID, int ReceiptID)
        {
            return DataAccessTier.clsOrdersData.IsOrderExist(ProductID, ReceiptID);
        }

        static public clsOrder Find(int ProductID, int ReceiptID)
        {
            int ID = -1, Quantity = -1;
            if (DataAccessTier.clsOrdersData.GetOrderByProductIDandReceiptID(ref ID, ref Quantity, ProductID, ReceiptID))
                return new clsOrder(ID, Quantity, ProductID, ReceiptID);
            else
                return null;
        }

        static public clsOrder Find (string ProductName, int ReceiptID)
        {
            clsProduct Product = clsProduct.FindProductByName(ProductName);

            if (Product != null)
            {
                return Find(Product.ID, ReceiptID);
            }
            else
            {
                return null;
            }


        }

        static public clsOrder Find (int OrderID)
        {
            int Quantity = -1, ProductID = -1, ReceiptID = -1;
            if (DataAccessTier.clsOrdersData.GetOrderByID(OrderID, ref Quantity, ref ProductID, ref ReceiptID))
            {
                return new clsOrder(OrderID, Quantity, ProductID, ReceiptID);
            }
            else
            {
                return null;
            }
        }

        static public DataTable GetAllOrdersOfDate(DateTime Date)
        {
            return clsOrdersData.GetAllOrdersOfDate(Date);
        }

    }

}
