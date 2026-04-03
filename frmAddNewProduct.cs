using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessTier;

namespace WindowsForms_PresentaionTier
{
    public partial class frmAddNewProduct : Form
    {
        private clsProduct _Product;
        public frmAddNewProduct()
        {
            InitializeComponent();

           
        }

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {
            _Product = new clsProduct();

            tbBarcode.Text = _Product.Barcode;
            tbUnit.Text = _Product.Unit;
            tbProdCompany.Text = _Product.ProdCompany;
            tbCategory.Text = _Product.Category;
            dtpProdDate.Text = Convert.ToString(_Product.ProdDate);
            dtpProdDate.Text = Convert.ToString(_Product.ProdDate);
            tbUnitCost.Text = Convert.ToString(_Product.UnitCost);
            tbUnitPrice.Text = Convert.ToString(_Product.UnitPrice);
            tbName.Text = _Product.Name;

        }

        private void btnAddAndClose_Click(object sender, EventArgs e)
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
                //_Product.UnitCost = 0;
                MessageBox.Show("ادخل أرقام فقط!");
            }

            try
            {
                _Product.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text);
                if (_Product.UnitPrice < 0)
                {
                    MessageBox.Show("سعر البيع يجب أن يكون أكبر من صفر!!");
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
                _Product.UnitPrice = 0;
                MessageBox.Show("ادخل أرقام فقط!");
            }

            _Product.Name = tbName.Text;

            if (_Product.Save())
            {
                MessageBox.Show("تم الإضافة بنجاح.");
                this.Close();
            }
            else
            {
                MessageBox.Show("فشلت الإضافة");
            }
        }
    }
}
