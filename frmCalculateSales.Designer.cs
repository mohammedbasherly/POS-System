namespace WindowsForms_PresentaionTier
{
    partial class frmCalculateSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculateSales));
            this.dtpDayToCalculateSales = new System.Windows.Forms.DateTimePicker();
            this.lblProfits = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDayToCalculateSales
            // 
            this.dtpDayToCalculateSales.AllowDrop = true;
            this.dtpDayToCalculateSales.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayToCalculateSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDayToCalculateSales.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDayToCalculateSales.Location = new System.Drawing.Point(55, 43);
            this.dtpDayToCalculateSales.Name = "dtpDayToCalculateSales";
            this.dtpDayToCalculateSales.RightToLeftLayout = true;
            this.dtpDayToCalculateSales.Size = new System.Drawing.Size(297, 20);
            this.dtpDayToCalculateSales.TabIndex = 0;
            this.dtpDayToCalculateSales.ValueChanged += new System.EventHandler(this.dtpDayToCalculateSales_ValueChanged);
            // 
            // lblProfits
            // 
            this.lblProfits.AutoSize = true;
            this.lblProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfits.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblProfits.Location = new System.Drawing.Point(49, 370);
            this.lblProfits.Name = "lblProfits";
            this.lblProfits.Size = new System.Drawing.Size(195, 33);
            this.lblProfits.TabIndex = 3;
            this.lblProfits.Text = "صافي الربح:   د.ل";
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(4, 86);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(397, 248);
            this.dgvSales.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Blue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(168, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "التاريخ";
            // 
            // frmCalculateSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblProfits);
            this.Controls.Add(this.dtpDayToCalculateSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculateSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جرد المبيعات";
            this.Load += new System.EventHandler(this.frmCalculateSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDayToCalculateSales;
        private System.Windows.Forms.Label lblProfits;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblDate;
    }
}