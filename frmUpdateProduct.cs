using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_PresentaionTier
{
    public partial class frmUpdateProduct : Form
    {
        private clsProduct _Product;

        public frmUpdateProduct(int ProductID)
        {
            InitializeComponent();
            _Product = clsProduct.Find(ProductID);
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            if (_Product == null)
            {
                MessageBox.Show("حدث خطأ !");
                this.Close();
                return;   // 🔥 VERY IMPORTANT
            }

            tbBarcode.Text = _Product.Barcode;
            tbUnit.Text = _Product.Unit;
            tbProdCompany.Text = _Product.ProdCompany;
            tbCategory.Text = _Product.Category;
            dtpProdDate.Value = _Product.ProdDate;
            dtpExpDate.Value = _Product.ExpDate;
            tbUnitCost.Text = _Product.UnitCost.ToString();
            tbUnitPrice.Text = _Product.UnitPrice.ToString();
            tbName.Text = _Product.Name;
        }

        private void btnUpdateAndClose_Click(object sender, EventArgs e)
        {
            _Product.Barcode = tbBarcode.Text;
            _Product.Unit = tbUnit.Text;
            _Product.ProdCompany = tbProdCompany.Text;
            _Product.Category = tbCategory.Text;
            _Product.ProdDate = (DateTime)dtpProdDate.Value;
            _Product.ExpDate = (DateTime)dtpExpDate.Value;
            if (_Product.ExpDate < _Product.ProdDate)
            {
                MessageBox.Show("تاريخ الإنتاج يجب أن يكون قبل تاريخ إنتهاء الصلاحية!");
                return;
            }

            try
            {
                _Product.UnitCost = Convert.ToDecimal(tbUnitCost.Text);
                if (_Product.UnitCost < 0)
                {
                    MessageBox.Show("سعر الشراء يجب أن لا يكون بالسالب!!");
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("ادخل أرقام فقط!");
                return;
            }

            try
            {
                _Product.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text);
                if (_Product.UnitPrice < 0)
                {
                    MessageBox.Show("سعر البيع يجب أن يكون أكبر من صفر!");
                    return;
                }
                else if (_Product.UnitPrice < _Product.UnitCost)
                {
                    MessageBox.Show("سعر البيع يجب أن لا يكون أصغر من سعر الشراء!");
                    return;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("ادخل أرقام فقط!");
                return;
            }

            _Product.Name = tbName.Text;

            if (_Product.Save())
            {
                MessageBox.Show("تم التعديل بنجاح.");
                this.Close();
            }
            else
            {
                MessageBox.Show("فشل التعديل!");
            }
        }
    }
}
