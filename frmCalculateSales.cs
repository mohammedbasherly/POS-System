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
    public partial class frmCalculateSales : Form
    {
        public frmCalculateSales()
        {
            InitializeComponent();
        }

        private void _CalculateProfit()
        {
            decimal profit = 0;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                // Skip the new empty row at bottom
                //if (row.IsNewRow) continue;

                decimal totalSales = Convert.ToDecimal(row.Cells["TotalSales"].Value);
                decimal totalCosts = Convert.ToDecimal(row.Cells["TotalCosts"].Value);

                profit += (totalSales - totalCosts);
            }

            lblProfits.Text = "صافي الربح: " + profit.ToString() + " د.ل";

        }

        private void _RefreshDataSource()
        {
            dgvSales.DataSource = clsOrder.GetAllOrdersOfDate(dtpDayToCalculateSales.Value);

            dgvSales.Columns["Name"].HeaderText = "الصنف";
            dgvSales.Columns["Quantity"].HeaderText = "الكمية";
            dgvSales.Columns["TotalCosts"].HeaderText = "إجمالي التكلفة";
            dgvSales.Columns["TotalSales"].HeaderText = "إجمالي المباع";
            dgvSales.Columns["Date"].HeaderText = "التاريخ والوقت";


            _CalculateProfit();
        }

        private void frmCalculateSales_Load(object sender, EventArgs e)
        {
            _RefreshDataSource();
        }

        private void dtpDayToCalculateSales_ValueChanged(object sender, EventArgs e)
        {
            _RefreshDataSource();
        }
    }
}
