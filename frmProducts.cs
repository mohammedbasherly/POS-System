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
    public partial class frmProducts : Form
    {
        private clsProduct _Product;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void _RefreshProducts()
        {
            dgvProducts.DataSource = clsProduct.GetAllProducts();
            lblProductsCount.Text = "عدد الأصناف: " + Convert.ToString(clsProduct.CountOfAllProducts());

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            _RefreshProducts();

            dgvProducts.Columns["ID"].HeaderText = "المعرف";
            dgvProducts.Columns["Barcode"].HeaderText = "باركود";
            dgvProducts.Columns["Unit"].HeaderText = "الوحدة";
            dgvProducts.Columns["ProdCompany"].HeaderText = "الشركة المصنعة";
            dgvProducts.Columns["Category"].HeaderText = "الفئة";
            dgvProducts.Columns["ProdDate"].HeaderText = "تاريخ الإنتاج";
            dgvProducts.Columns["ExpDate"].HeaderText = "تاريخ إنتهاء الصلاحية";
            dgvProducts.Columns["UnitCost"].HeaderText = "سعر الشراء";
            dgvProducts.Columns["UnitPrice"].HeaderText = "سعر البيع";
            dgvProducts.Columns["Name"].HeaderText = "الإسم";


        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = dgvProducts.SelectedRows[0];
                int ID = Convert.ToInt32(SelectedRow.Cells["ID"].Value);
                // MessageBox.Show("Selected ID: " + ID);
                frmUpdateProduct formUpdateProduct = new frmUpdateProduct(ID);
                formUpdateProduct.ShowDialog();

                dgvProducts.DataSource = clsProduct.GetAllProducts();
            }
            else
            {
                MessageBox.Show("حدد الصف بالكامل!");
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddNewProduct formAddNewProduct = new frmAddNewProduct();
            formAddNewProduct.ShowDialog();


            dgvProducts.DataSource = clsProduct.GetAllProducts();
        }
    }
}
