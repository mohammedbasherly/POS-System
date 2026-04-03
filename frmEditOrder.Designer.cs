namespace WindowsForms_PresentaionTier
{
    partial class frmEditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditOrder));
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnEnsure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            resources.ApplyResources(this.lblQuantity, "lblQuantity");
            this.lblQuantity.ForeColor = System.Drawing.Color.Blue;
            this.lblQuantity.Name = "lblQuantity";
            // 
            // tbQuantity
            // 
            resources.ApplyResources(this.tbQuantity, "tbQuantity");
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantity_KeyDown);
            // 
            // btnEnsure
            // 
            this.btnEnsure.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEnsure.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnEnsure, "btnEnsure");
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.UseVisualStyleBackColor = false;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // frmEditOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnsure);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditOrder";
            this.Load += new System.EventHandler(this.frmEditOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnEnsure;
    }
}