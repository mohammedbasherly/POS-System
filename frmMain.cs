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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        static public clsReceipt _Receipt;

        static public clsOrder _Order;

        static public clsProduct _Product;

        static private decimal _GrandTotal = 0;
        

        private void _LoadOrders()
        {
            dgvOrders.DataSource = clsOrder.LoadReceiptOrdersJoinedWithProducts(_Receipt.ID);

            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrders.Columns["Name"].HeaderText = "الصنف";
            dgvOrders.Columns["Quantity"].HeaderText = "الكمية";
            dgvOrders.Columns["Unit"].HeaderText = "الوحدة";
            dgvOrders.Columns["UnitPrice"].HeaderText = "السعر";
            dgvOrders.Columns["TotalPrice"].HeaderText = "السعر الإجمالي";

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //_LoadOrders(Receipt.ID);
            _Receipt = clsReceipt.CreateReceipt();
            if (_Receipt == null)
            {
                MessageBox.Show("Failed to create receipt.");
                this.Close(); // or disable POS
                return;
            }
            _Order = new clsOrder();
            _Product = new clsProduct();

            lblReceiptNumber.Text = "رقم الفاتورة: " + _Receipt.ID.ToString();
            lblTodayDate.Text = "التاريخ: " + DateTime.Today.ToShortDateString(); ;

            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White; // your color
                }
            }

            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.MultiSelect = false;

            tbBarcode.Focus();

        }

        private void CalculateGrandTotalPrice()
        {
            _GrandTotal = 0;
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    _GrandTotal += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }
            lblReceiptTotalPrice.Text = "السعر الكلي: " + _GrandTotal.ToString() + " د.ل";
        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Barcode = tbBarcode.Text.Trim();
                if (clsProduct.IsProductExist(Barcode))
                {
                    // MessageBox.Show("Product Exists");
                    _Product = clsProduct.Find(Barcode);
                    if (_Product == null)
                    {
                        MessageBox.Show("Product not found!");
                        return;
                    }

                    if (_Receipt == null)
                    {
                        MessageBox.Show("Receipt is null!");
                        return;
                    }

                    //Order = new clsOrder();

                    if (clsOrder.IsOrderExist(_Product.ID, _Receipt.ID))
                    {
                        _Order = clsOrder.Find(_Product.ID, _Receipt.ID);
                        if (_Order != null)
                        {
                            _Order.Quantity++;
                        }
                        else
                        {
                            MessageBox.Show("Order not found");
                        }
                    }
                    else
                    {
                        _Order = clsOrder.CreateOrder(1, _Product.ID, _Receipt.ID);
                    }

                    _Order.ReceiptID = _Receipt.ID;

                    try
                    {
                        _Order.Save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Product does not exist!");
                }

                _LoadOrders();

                tbBarcode.Text = string.Empty;

                CalculateGrandTotalPrice();
            }
            tbBarcode.Focus();
        }

        private void btnSaveAndCreateNewReceipt_Click(object sender, EventArgs e)
        {
            _Receipt = clsReceipt.CreateReceipt();
            dgvOrders.DataSource = new DataTable();
            _Product = new clsProduct();
            _Order = new clsOrder();

            lblReceiptNumber.Text = "فاتورة رقم: " + _Receipt.ID.ToString();

            tbBarcode.Focus();

            MessageBox.Show("تم الحفظ بنجاح");

            CalculateGrandTotalPrice();

        }

        private bool ClearReceipt()
        {
            return clsReceipt.ClearReceipt(_Receipt.ID);
        }

        private void btnClearReceipt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("متأكد تبي تمسح الفاتورة؟", "تأكيد العملية", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (ClearReceipt())
                {
                    _LoadOrders();
                    _Product = null;
                    _Order = new clsOrder();
                    _GrandTotal = 0;
                    lblReceiptTotalPrice.Text = "السعر الكلي: " + _GrandTotal.ToString() + " د.ل";
                }
            }
            tbBarcode.Focus();
        }

        private bool _DeleteRow(DataGridViewRow SelectedRow)
        {
            string ProductName = Convert.ToString(SelectedRow.Cells["Name"].Value);
            _Order = clsOrder.Find(ProductName, _Receipt.ID);
            if (_Order != null)
            {
                if (clsOrder.DeleteOrder(_Order.ID))
                {
                    return true;
                }
                else
                {
                    //MessageBox.Show("Order Deletion is Failed");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("متأكد تبي تحذف الصنف؟", "تأكيد العملية", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    DataGridViewRow SelectedRow = dgvOrders.SelectedRows[0];

                    if (_DeleteRow(SelectedRow))
                    {
                        _LoadOrders();
                        CalculateGrandTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("Order Deletion is Failed.");
                    }

                }
            }
            tbBarcode.Focus();
        }

        private bool _EditRow(DataGridViewRow SelectedRow)
        {
            string ProductName = Convert.ToString(SelectedRow.Cells["Name"].Value);
            _Order = clsOrder.Find(ProductName, _Receipt.ID);
            if (_Order != null)
            {
                frmEditOrder frmEdit = new frmEditOrder(_Order.ID);
                frmEdit.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = dgvOrders.SelectedRows[0];

                if (_EditRow(SelectedRow))
                {
                    _LoadOrders();
                    CalculateGrandTotalPrice();
                }
                else
                {
                    MessageBox.Show("Order Deletion is Failed.");
                }

            }
            tbBarcode.Focus();
        }

        private bool _IncreaseQuantity(DataGridViewRow SelectedRow)
        {
            string ProductName = Convert.ToString(SelectedRow.Cells["Name"].Value);
            _Order = clsOrder.Find(ProductName, _Receipt.ID);
            if (_Order != null)
            {
                _Order.Quantity++;
                return _Order.Save();
            }
            else
                return false;
            
        }

        private bool _DecreaseQuantity(DataGridViewRow SelectedRow)
        {
            string ProductName = Convert.ToString(SelectedRow.Cells["Name"].Value);
            _Order = clsOrder.Find(ProductName, _Receipt.ID);
            if (_Order != null)
            {
                if (_Order.Quantity > 1)
                {
                    _Order.Quantity--;
                }
                else
                {
                    if (MessageBox.Show("تبي تحذف الصنف؟", "تأكيد العملية", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (clsOrder.DeleteOrder(_Order.ID))
                        {
                            _Order = null;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Order Deletion is Failed");
                            return false;
                        }
                    }
                }

                return _Order.Save();
            }
            else
                return false;
        }

        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = dgvOrders.SelectedRows[0];

                if (_IncreaseQuantity(SelectedRow))
                {
                    _LoadOrders();
                    CalculateGrandTotalPrice();
                }
                else
                {
                    MessageBox.Show("Order increasing is failed.");
                }

            }
            tbBarcode.Focus();
        }

        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = dgvOrders.SelectedRows[0];

                if (_DecreaseQuantity(SelectedRow))
                {
                    _LoadOrders();
                    CalculateGrandTotalPrice();
                }
                else
                {
                    MessageBox.Show("Order Deletion is Failed.");
                }

            }
            tbBarcode.Focus();
        }

        private void btnOpenStorage_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.Show();
        }

        private void _GetProductButtonPressed(object sender, EventArgs e)
        {
            MessageBox.Show("سيتم إضافة هذه الميزة قريبا", "الميزة ليست متوفرة بعد", MessageBoxButtons.OK);

            // string[] Barcodes = { "", "", "", "", "", "", "", "", "", "" };




        
        }

        private void btnCalculateSales_Click(object sender, EventArgs e)
        {
            frmCalculateSales formCalculateSales = new frmCalculateSales();
            formCalculateSales.ShowDialog();
        }
    }
}
