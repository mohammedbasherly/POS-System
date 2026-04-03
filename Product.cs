using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;

namespace BusinessTier
{
    public class clsProduct
    {
        public int ID { get; set; }
        public string Barcode { get; set; }
        public string Unit {  get; set; }
        public string ProdCompany { get; set; }
        public string Category { get; set; }
        public DateTime ProdDate { get; set; }
        public DateTime ExpDate { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public string Name { get; set; }

        public enum enMode { AddNew = 1, Update = 2 };
        enMode Mode;

        public clsProduct()
        {
            this.ID = -1;
            this.Barcode = string.Empty;
            this.Unit = string.Empty;
            this.ProdCompany = string.Empty;
            this.Category = string.Empty;
            this.ProdDate = new DateTime(1900, 1, 1);
            this.ExpDate = new DateTime(1900, 1, 1);
            this.UnitCost = -1;
            this.UnitPrice = -1;
            this.Name = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsProduct(int ID, string Barcode, string Unit, string ProdCompany, string Category, DateTime ProdDate, DateTime ExpDate, decimal UnitCost, Decimal UnitPrice, string Name)
        {
            this.ID = ID;
            this.Barcode = Barcode;
            this.Unit = Unit;
            this.ProdCompany = ProdCompany;
            this.Category = Category;
            this.ProdDate = ProdDate;
            this.ExpDate = ExpDate;
            this.UnitCost = UnitCost;
            this.UnitPrice = UnitPrice;
            this.Name = Name;

            Mode = enMode.Update;
        }

        static public clsProduct Find(int ID)
        {
            string Barcode = "", Unit = "", ProdCompany = "", Category = "";
            DateTime ProdDate = new DateTime(1900, 1, 1), ExpDate = new DateTime(1900,1,1);
            decimal UnitCost = 0, UnitPrice = 0;
            string Name = "";
            if (DataAccessTier.clsProductsData.GetProductByID(ID, ref Barcode, ref Unit, ref ProdCompany, ref Category, ref ProdDate, ref ExpDate, ref UnitCost, ref UnitPrice, ref Name))
            {
                return new clsProduct(ID, Barcode, Unit, ProdCompany, Category, ProdDate, ExpDate, UnitCost, UnitPrice, Name);
            }
            else
            {
                return null;
            }
        }

        static public clsProduct Find(string Barcode)
        {
            int ID = -1;
            string Unit = "", ProdCompany = "", Category = "";
            DateTime ProdDate = new DateTime(1, 1, 1), ExpDate = new DateTime(1, 1, 1);
            decimal UnitCost = 0, UnitPrice = 0;
            string Name = "";
            if (DataAccessTier.clsProductsData.GetProductByBarcode(Barcode, ref ID, ref Unit, ref ProdCompany, ref Category, ref ProdDate, ref ExpDate, ref UnitCost, ref UnitPrice, ref Name))
            {
                return new clsProduct(ID, Barcode, Unit, ProdCompany, Category, ProdDate, ExpDate, UnitCost, UnitPrice, Name);
            }
            else
            {
                return null;
            }
        }

        static public clsProduct FindProductByName(string Name)
        {
            int ID = -1;
            string Unit = "", ProdCompany = "", Category = "";
            DateTime ProdDate = new DateTime(1, 1, 1), ExpDate = new DateTime(1, 1, 1);
            decimal UnitCost = 0, UnitPrice = 0;
            string Barcode = "";
            if (DataAccessTier.clsProductsData.GetProductByName(Name, ref ID, ref Barcode, ref Unit, ref ProdCompany, ref Category, ref ProdDate, ref ExpDate, ref UnitCost, ref UnitPrice))
            {
                return new clsProduct(ID, Barcode, Unit, ProdCompany, Category, ProdDate, ExpDate, UnitCost, UnitPrice, Name);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewProduct()
        {
            this.ID = DataAccessTier.clsProductsData.AddNewProduct(this.Barcode, this.Unit, this.ProdCompany, this.Category, this.ProdDate, this.ExpDate, this.UnitCost, this.UnitPrice, this.Name);
            return this.ID != -1;
        }

        private bool _UpdateProduct()
        {
            return DataAccessTier.clsProductsData.UpdateProduct(this.ID, this.Barcode, this.Unit, this.ProdCompany, this.Category, this.ProdDate, this.ExpDate, this.UnitCost, this.UnitPrice, this.Name);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewProduct())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    if (_UpdateProduct())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return false;
        }

        static public DataTable GetAllProducts()
        {
            return DataAccessTier.clsProductsData.GetAllProducts();
        }

        static public bool DeleteProduct(int ID)
        {
            return DataAccessTier.clsProductsData.DeleteProduct(ID);
        }

        static public bool DeleteProduct(string Barcode)
        {
            return DataAccessTier.clsProductsData.DeleteProduct(Barcode);
        }

        static public bool IsProductExist(string Barcode)
        {
            return DataAccessTier.clsProductsData.IsProductExist(Barcode);
        }

        static public bool IsProductExist(int ID)
        {
            return DataAccessTier.clsProductsData.IsProductExist(ID);
        }

        static public int CountOfAllProducts()
        {
            return DataAccessTier.clsProductsData.CountOfAllProducts();
        }

        //static public clsProduct CreateProduct()
        //{
        //    string Barcode = "", Unit = "", ProdCompany = "", Category = "", Name = "";
        //    DateTime ProdDate = new DateTime(1900, 1, 1), ExpDate = new DateTime(1900, 1, 1);
        //    decimal UnitCost = -1, UnitPrice = -1;
        //    int ID = DataAccessTier.clsProductsData.AddNewProduct(ref Barcode, ref Unit, ref ProdCompany, ref Category, ref ProdDate, ref ExpDate, ref UnitCost, ref UnitPrice, ref Name);
        //    if (ID != -1)
        //    {
        //        return new clsProduct(ID, Barcode, Unit, ProdCompany, Category, ProdDate, ExpDate, UnitCost, UnitPrice, Name);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}


    }

}
