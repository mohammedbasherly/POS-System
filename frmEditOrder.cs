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
    public partial class frmEditOrder : Form
    {
        public clsOrder Order;
        public frmEditOrder(int OrderID)
        {
            InitializeComponent();

            this.Order = clsOrder.Find(OrderID);
        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {
            tbQuantity.Text = Order.Quantity.ToString();
        }

        private bool _SaveQuantity()
        {
            string input = tbQuantity.Text.Trim();
            bool isNumber = int.TryParse(input, out int Quantity);
            if (isNumber && Quantity >= 1)
            {
                Order.Quantity = Quantity;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            if (_SaveQuantity())
            {
                try
                {
                    Order.Save();
                    this.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error: " + Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("إدخال خاطئ!");
            }
        }

        private void tbQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_SaveQuantity())
                {
                    try
                    {
                        Order.Save();
                        this.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Error: " + Ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("إدخال خاطئ!");
                }
            }
        }

    }
}
