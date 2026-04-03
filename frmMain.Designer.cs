namespace WindowsForms_PresentaionTier
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblBarcodeSearch = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblReceiptNumber = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnSaveAndCreateNewReceipt = new System.Windows.Forms.Button();
            this.btnClearReceipt = new System.Windows.Forms.Button();
            this.btnIncreaseQuantity = new System.Windows.Forms.Button();
            this.btnDecreaseQuantity = new System.Windows.Forms.Button();
            this.lblReceiptTotalPrice = new System.Windows.Forms.Label();
            this.btnGetProduct1 = new System.Windows.Forms.Button();
            this.btnGetProduct2 = new System.Windows.Forms.Button();
            this.btnGetProduct3 = new System.Windows.Forms.Button();
            this.btnGetProduct4 = new System.Windows.Forms.Button();
            this.btnGetProduct5 = new System.Windows.Forms.Button();
            this.btnGetProduct6 = new System.Windows.Forms.Button();
            this.btnGetProduct7 = new System.Windows.Forms.Button();
            this.btnGetProduct8 = new System.Windows.Forms.Button();
            this.btnGetProduct9 = new System.Windows.Forms.Button();
            this.btnGetProduct10 = new System.Windows.Forms.Button();
            this.btnOpenStorage = new System.Windows.Forms.Button();
            this.btnCalculateSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcodeSearch
            // 
            this.lblBarcodeSearch.AutoSize = true;
            this.lblBarcodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcodeSearch.ForeColor = System.Drawing.Color.Blue;
            this.lblBarcodeSearch.Location = new System.Drawing.Point(704, 587);
            this.lblBarcodeSearch.Name = "lblBarcodeSearch";
            this.lblBarcodeSearch.Size = new System.Drawing.Size(86, 31);
            this.lblBarcodeSearch.TabIndex = 2;
            this.lblBarcodeSearch.Text = "باركود:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(809, 591);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(171, 20);
            this.tbBarcode.TabIndex = 0;
            this.tbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBarcode_KeyDown);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(650, 38);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(712, 529);
            this.dgvOrders.TabIndex = 6;
            // 
            // lblReceiptNumber
            // 
            this.lblReceiptNumber.AutoSize = true;
            this.lblReceiptNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumber.Location = new System.Drawing.Point(840, 9);
            this.lblReceiptNumber.Name = "lblReceiptNumber";
            this.lblReceiptNumber.Size = new System.Drawing.Size(89, 24);
            this.lblReceiptNumber.TabIndex = 7;
            this.lblReceiptNumber.Text = "رقم الفاتورة: ";
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(1132, 9);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(61, 24);
            this.lblTodayDate.TabIndex = 8;
            this.lblTodayDate.Text = "التاريخ: ";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Location = new System.Drawing.Point(586, 38);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(58, 56);
            this.btnDeleteOrder.TabIndex = 9;
            this.btnDeleteOrder.Text = "حذف";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.SlateGray;
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(586, 106);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(58, 56);
            this.btnEditOrder.TabIndex = 10;
            this.btnEditOrder.Text = "تعديل";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnSaveAndCreateNewReceipt
            // 
            this.btnSaveAndCreateNewReceipt.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveAndCreateNewReceipt.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndCreateNewReceipt.Location = new System.Drawing.Point(751, 645);
            this.btnSaveAndCreateNewReceipt.Name = "btnSaveAndCreateNewReceipt";
            this.btnSaveAndCreateNewReceipt.Size = new System.Drawing.Size(200, 36);
            this.btnSaveAndCreateNewReceipt.TabIndex = 11;
            this.btnSaveAndCreateNewReceipt.Text = "حفظ وإنشاء فاتورة جديدة";
            this.btnSaveAndCreateNewReceipt.UseVisualStyleBackColor = false;
            this.btnSaveAndCreateNewReceipt.Click += new System.EventHandler(this.btnSaveAndCreateNewReceipt_Click);
            // 
            // btnClearReceipt
            // 
            this.btnClearReceipt.BackColor = System.Drawing.Color.Yellow;
            this.btnClearReceipt.ForeColor = System.Drawing.Color.Gray;
            this.btnClearReceipt.Location = new System.Drawing.Point(1027, 645);
            this.btnClearReceipt.Name = "btnClearReceipt";
            this.btnClearReceipt.Size = new System.Drawing.Size(200, 36);
            this.btnClearReceipt.TabIndex = 12;
            this.btnClearReceipt.Text = "مسح الفاتورة";
            this.btnClearReceipt.UseVisualStyleBackColor = false;
            this.btnClearReceipt.Click += new System.EventHandler(this.btnClearReceipt_Click);
            // 
            // btnIncreaseQuantity
            // 
            this.btnIncreaseQuantity.BackColor = System.Drawing.Color.Blue;
            this.btnIncreaseQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseQuantity.ForeColor = System.Drawing.Color.White;
            this.btnIncreaseQuantity.Location = new System.Drawing.Point(586, 200);
            this.btnIncreaseQuantity.Name = "btnIncreaseQuantity";
            this.btnIncreaseQuantity.Size = new System.Drawing.Size(58, 60);
            this.btnIncreaseQuantity.TabIndex = 13;
            this.btnIncreaseQuantity.Text = "+";
            this.btnIncreaseQuantity.UseVisualStyleBackColor = false;
            this.btnIncreaseQuantity.Click += new System.EventHandler(this.btnIncreaseQuantity_Click);
            // 
            // btnDecreaseQuantity
            // 
            this.btnDecreaseQuantity.BackColor = System.Drawing.Color.Blue;
            this.btnDecreaseQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseQuantity.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseQuantity.Location = new System.Drawing.Point(586, 278);
            this.btnDecreaseQuantity.Name = "btnDecreaseQuantity";
            this.btnDecreaseQuantity.Size = new System.Drawing.Size(58, 58);
            this.btnDecreaseQuantity.TabIndex = 14;
            this.btnDecreaseQuantity.Text = "-";
            this.btnDecreaseQuantity.UseVisualStyleBackColor = false;
            this.btnDecreaseQuantity.Click += new System.EventHandler(this.btnDecreaseQuantity_Click);
            // 
            // lblReceiptTotalPrice
            // 
            this.lblReceiptTotalPrice.AutoSize = true;
            this.lblReceiptTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptTotalPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblReceiptTotalPrice.Location = new System.Drawing.Point(1033, 584);
            this.lblReceiptTotalPrice.Name = "lblReceiptTotalPrice";
            this.lblReceiptTotalPrice.Size = new System.Drawing.Size(177, 37);
            this.lblReceiptTotalPrice.TabIndex = 15;
            this.lblReceiptTotalPrice.Text = "السعر الكلي: 0";
            // 
            // btnGetProduct1
            // 
            this.btnGetProduct1.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct1.Location = new System.Drawing.Point(316, 52);
            this.btnGetProduct1.Name = "btnGetProduct1";
            this.btnGetProduct1.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct1.TabIndex = 17;
            this.btnGetProduct1.Text = "اختصار صنف";
            this.btnGetProduct1.UseVisualStyleBackColor = true;
            this.btnGetProduct1.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct2
            // 
            this.btnGetProduct2.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct2.Location = new System.Drawing.Point(51, 52);
            this.btnGetProduct2.Name = "btnGetProduct2";
            this.btnGetProduct2.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct2.TabIndex = 18;
            this.btnGetProduct2.Text = "اختصار صنف";
            this.btnGetProduct2.UseVisualStyleBackColor = true;
            this.btnGetProduct2.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct3
            // 
            this.btnGetProduct3.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct3.Location = new System.Drawing.Point(316, 160);
            this.btnGetProduct3.Name = "btnGetProduct3";
            this.btnGetProduct3.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct3.TabIndex = 19;
            this.btnGetProduct3.Text = "اختصار صنف";
            this.btnGetProduct3.UseVisualStyleBackColor = true;
            this.btnGetProduct3.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct4
            // 
            this.btnGetProduct4.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct4.Location = new System.Drawing.Point(51, 160);
            this.btnGetProduct4.Name = "btnGetProduct4";
            this.btnGetProduct4.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct4.TabIndex = 20;
            this.btnGetProduct4.Text = "اختصار صنف";
            this.btnGetProduct4.UseVisualStyleBackColor = true;
            this.btnGetProduct4.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct5
            // 
            this.btnGetProduct5.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct5.Location = new System.Drawing.Point(316, 260);
            this.btnGetProduct5.Name = "btnGetProduct5";
            this.btnGetProduct5.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct5.TabIndex = 21;
            this.btnGetProduct5.Text = "اختصار صنف";
            this.btnGetProduct5.UseVisualStyleBackColor = true;
            this.btnGetProduct5.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct6
            // 
            this.btnGetProduct6.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct6.Location = new System.Drawing.Point(51, 260);
            this.btnGetProduct6.Name = "btnGetProduct6";
            this.btnGetProduct6.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct6.TabIndex = 22;
            this.btnGetProduct6.Text = "اختصار صنف";
            this.btnGetProduct6.UseVisualStyleBackColor = true;
            this.btnGetProduct6.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct7
            // 
            this.btnGetProduct7.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct7.Location = new System.Drawing.Point(316, 364);
            this.btnGetProduct7.Name = "btnGetProduct7";
            this.btnGetProduct7.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct7.TabIndex = 23;
            this.btnGetProduct7.Text = "اختصار صنف";
            this.btnGetProduct7.UseVisualStyleBackColor = true;
            this.btnGetProduct7.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct8
            // 
            this.btnGetProduct8.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct8.Location = new System.Drawing.Point(51, 364);
            this.btnGetProduct8.Name = "btnGetProduct8";
            this.btnGetProduct8.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct8.TabIndex = 24;
            this.btnGetProduct8.Text = "اختصار صنف";
            this.btnGetProduct8.UseVisualStyleBackColor = true;
            this.btnGetProduct8.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct9
            // 
            this.btnGetProduct9.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct9.Location = new System.Drawing.Point(316, 471);
            this.btnGetProduct9.Name = "btnGetProduct9";
            this.btnGetProduct9.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct9.TabIndex = 25;
            this.btnGetProduct9.Text = "اختصار صنف";
            this.btnGetProduct9.UseVisualStyleBackColor = true;
            this.btnGetProduct9.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnGetProduct10
            // 
            this.btnGetProduct10.ForeColor = System.Drawing.Color.Blue;
            this.btnGetProduct10.Location = new System.Drawing.Point(51, 471);
            this.btnGetProduct10.Name = "btnGetProduct10";
            this.btnGetProduct10.Size = new System.Drawing.Size(194, 54);
            this.btnGetProduct10.TabIndex = 26;
            this.btnGetProduct10.Text = "اختصار صنف";
            this.btnGetProduct10.UseVisualStyleBackColor = true;
            this.btnGetProduct10.Click += new System.EventHandler(this._GetProductButtonPressed);
            // 
            // btnOpenStorage
            // 
            this.btnOpenStorage.BackColor = System.Drawing.Color.Blue;
            this.btnOpenStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenStorage.ForeColor = System.Drawing.Color.White;
            this.btnOpenStorage.Location = new System.Drawing.Point(37, 591);
            this.btnOpenStorage.Name = "btnOpenStorage";
            this.btnOpenStorage.Size = new System.Drawing.Size(221, 86);
            this.btnOpenStorage.TabIndex = 36;
            this.btnOpenStorage.Text = "فتح المخزن";
            this.btnOpenStorage.UseVisualStyleBackColor = false;
            this.btnOpenStorage.Click += new System.EventHandler(this.btnOpenStorage_Click);
            // 
            // btnCalculateSales
            // 
            this.btnCalculateSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculateSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSales.ForeColor = System.Drawing.Color.White;
            this.btnCalculateSales.Location = new System.Drawing.Point(298, 591);
            this.btnCalculateSales.Name = "btnCalculateSales";
            this.btnCalculateSales.Size = new System.Drawing.Size(221, 86);
            this.btnCalculateSales.TabIndex = 38;
            this.btnCalculateSales.Text = "حساب المباع والأرباح";
            this.btnCalculateSales.UseVisualStyleBackColor = false;
            this.btnCalculateSales.Click += new System.EventHandler(this.btnCalculateSales_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnCalculateSales);
            this.Controls.Add(this.btnOpenStorage);
            this.Controls.Add(this.btnGetProduct10);
            this.Controls.Add(this.btnGetProduct9);
            this.Controls.Add(this.btnGetProduct8);
            this.Controls.Add(this.btnGetProduct7);
            this.Controls.Add(this.btnGetProduct6);
            this.Controls.Add(this.btnGetProduct5);
            this.Controls.Add(this.btnGetProduct4);
            this.Controls.Add(this.btnGetProduct3);
            this.Controls.Add(this.btnGetProduct2);
            this.Controls.Add(this.btnGetProduct1);
            this.Controls.Add(this.lblReceiptTotalPrice);
            this.Controls.Add(this.btnDecreaseQuantity);
            this.Controls.Add(this.btnIncreaseQuantity);
            this.Controls.Add(this.btnClearReceipt);
            this.Controls.Add(this.btnSaveAndCreateNewReceipt);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.lblReceiptNumber);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lblBarcodeSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شركة كفاحي اللامحدودة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBarcodeSearch;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblReceiptNumber;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnSaveAndCreateNewReceipt;
        private System.Windows.Forms.Button btnClearReceipt;
        private System.Windows.Forms.Button btnIncreaseQuantity;
        private System.Windows.Forms.Button btnDecreaseQuantity;
        private System.Windows.Forms.Label lblReceiptTotalPrice;
        private System.Windows.Forms.Button btnGetProduct1;
        private System.Windows.Forms.Button btnGetProduct2;
        private System.Windows.Forms.Button btnGetProduct3;
        private System.Windows.Forms.Button btnGetProduct4;
        private System.Windows.Forms.Button btnGetProduct5;
        private System.Windows.Forms.Button btnGetProduct6;
        private System.Windows.Forms.Button btnGetProduct7;
        private System.Windows.Forms.Button btnGetProduct8;
        private System.Windows.Forms.Button btnGetProduct9;
        private System.Windows.Forms.Button btnGetProduct10;
        private System.Windows.Forms.Button btnOpenStorage;
        private System.Windows.Forms.Button btnCalculateSales;
    }
}

