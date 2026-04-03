namespace WindowsForms_PresentaionTier
{
    partial class frmAddNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewProduct));
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpProdDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddAndClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblProdDate = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbProdCompany = new System.Windows.Forms.TextBox();
            this.lblProdCompany = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Location = new System.Drawing.Point(137, 219);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(140, 20);
            this.dtpExpDate.TabIndex = 39;
            // 
            // dtpProdDate
            // 
            this.dtpProdDate.Location = new System.Drawing.Point(137, 178);
            this.dtpProdDate.Name = "dtpProdDate";
            this.dtpProdDate.Size = new System.Drawing.Size(140, 20);
            this.dtpProdDate.TabIndex = 38;
            // 
            // btnAddAndClose
            // 
            this.btnAddAndClose.BackColor = System.Drawing.Color.Lime;
            this.btnAddAndClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddAndClose.Location = new System.Drawing.Point(56, 388);
            this.btnAddAndClose.Name = "btnAddAndClose";
            this.btnAddAndClose.Size = new System.Drawing.Size(176, 26);
            this.btnAddAndClose.TabIndex = 37;
            this.btnAddAndClose.Text = "إضافة وإنهاء";
            this.btnAddAndClose.UseVisualStyleBackColor = false;
            this.btnAddAndClose.Click += new System.EventHandler(this.btnAddAndClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(136, 344);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(141, 20);
            this.tbName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(27, 345);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 17);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "الإسم:";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(136, 303);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(141, 20);
            this.tbUnitPrice.TabIndex = 34;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Location = new System.Drawing.Point(27, 304);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(50, 17);
            this.lblUnitPrice.TabIndex = 33;
            this.lblUnitPrice.Text = "سعر البيع:";
            // 
            // tbUnitCost
            // 
            this.tbUnitCost.Location = new System.Drawing.Point(136, 262);
            this.tbUnitCost.MaxLength = 6;
            this.tbUnitCost.Name = "tbUnitCost";
            this.tbUnitCost.Size = new System.Drawing.Size(141, 20);
            this.tbUnitCost.TabIndex = 32;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.BackColor = System.Drawing.Color.White;
            this.lblUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.ForeColor = System.Drawing.Color.Black;
            this.lblUnitCost.Location = new System.Drawing.Point(27, 263);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(60, 17);
            this.lblUnitCost.TabIndex = 31;
            this.lblUnitCost.Text = "سعر الشراء:";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.BackColor = System.Drawing.Color.White;
            this.lblExpDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpDate.Location = new System.Drawing.Point(27, 222);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(100, 17);
            this.lblExpDate.TabIndex = 30;
            this.lblExpDate.Text = "تاريخ إنتهاء الصلاحية:";
            // 
            // lblProdDate
            // 
            this.lblProdDate.AutoSize = true;
            this.lblProdDate.BackColor = System.Drawing.Color.White;
            this.lblProdDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDate.ForeColor = System.Drawing.Color.Black;
            this.lblProdDate.Location = new System.Drawing.Point(27, 181);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Size = new System.Drawing.Size(63, 17);
            this.lblProdDate.TabIndex = 29;
            this.lblProdDate.Text = "تاريخ الإنتاج:";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(136, 141);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(141, 20);
            this.tbCategory.TabIndex = 28;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.White;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(27, 142);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(30, 17);
            this.lblCategory.TabIndex = 27;
            this.lblCategory.Text = "الفئة:";
            // 
            // tbProdCompany
            // 
            this.tbProdCompany.Location = new System.Drawing.Point(136, 101);
            this.tbProdCompany.Name = "tbProdCompany";
            this.tbProdCompany.Size = new System.Drawing.Size(141, 20);
            this.tbProdCompany.TabIndex = 26;
            // 
            // lblProdCompany
            // 
            this.lblProdCompany.AutoSize = true;
            this.lblProdCompany.BackColor = System.Drawing.Color.White;
            this.lblProdCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProdCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCompany.ForeColor = System.Drawing.Color.Black;
            this.lblProdCompany.Location = new System.Drawing.Point(27, 102);
            this.lblProdCompany.Name = "lblProdCompany";
            this.lblProdCompany.Size = new System.Drawing.Size(78, 17);
            this.lblProdCompany.TabIndex = 25;
            this.lblProdCompany.Text = "الشركة المصنعة:";
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(136, 61);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(141, 20);
            this.tbUnit.TabIndex = 24;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.White;
            this.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Black;
            this.lblUnit.Location = new System.Drawing.Point(27, 62);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 17);
            this.lblUnit.TabIndex = 23;
            this.lblUnit.Text = "الوحدة:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(136, 21);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(141, 20);
            this.tbBarcode.TabIndex = 22;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.BackColor = System.Drawing.Color.White;
            this.lblBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.ForeColor = System.Drawing.Color.Black;
            this.lblBarcode.Location = new System.Drawing.Point(27, 22);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(38, 17);
            this.lblBarcode.TabIndex = 21;
            this.lblBarcode.Text = "باركود:";
            // 
            // frmAddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.dtpProdDate);
            this.Controls.Add(this.btnAddAndClose);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.tbUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblProdDate);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbProdCompany);
            this.Controls.Add(this.lblProdCompany);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lblBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافة صنف جديد";
            this.Load += new System.EventHandler(this.frmAddNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.DateTimePicker dtpProdDate;
        private System.Windows.Forms.Button btnAddAndClose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbUnitCost;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblProdDate;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbProdCompany;
        private System.Windows.Forms.Label lblProdCompany;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label lblBarcode;
    }
}