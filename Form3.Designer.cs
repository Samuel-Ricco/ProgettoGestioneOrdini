namespace ProgettoGruppo2
{
    partial class Form3
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
            this.lbl_inputDiscount = new System.Windows.Forms.Label();
            this.tbx_inputQuantity = new System.Windows.Forms.TextBox();
            this.lbl_inputQuantity = new System.Windows.Forms.Label();
            this.lbl_inputProduct = new System.Windows.Forms.Label();
            this.cbx_inputDiscount = new System.Windows.Forms.ComboBox();
            this.cbx_inputProduct = new System.Windows.Forms.ComboBox();
            this.lbl_titleInsertOrderItemData = new System.Windows.Forms.Label();
            this.btn_insertOrderItem = new System.Windows.Forms.Button();
            this.btn_backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_inputDiscount
            // 
            this.lbl_inputDiscount.AutoSize = true;
            this.lbl_inputDiscount.Location = new System.Drawing.Point(629, 121);
            this.lbl_inputDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputDiscount.Name = "lbl_inputDiscount";
            this.lbl_inputDiscount.Size = new System.Drawing.Size(72, 20);
            this.lbl_inputDiscount.TabIndex = 47;
            this.lbl_inputDiscount.Text = "Discount";
            // 
            // tbx_inputQuantity
            // 
            this.tbx_inputQuantity.Location = new System.Drawing.Point(348, 163);
            this.tbx_inputQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_inputQuantity.Name = "tbx_inputQuantity";
            this.tbx_inputQuantity.Size = new System.Drawing.Size(207, 26);
            this.tbx_inputQuantity.TabIndex = 46;
            // 
            // lbl_inputQuantity
            // 
            this.lbl_inputQuantity.AutoSize = true;
            this.lbl_inputQuantity.Location = new System.Drawing.Point(417, 121);
            this.lbl_inputQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputQuantity.Name = "lbl_inputQuantity";
            this.lbl_inputQuantity.Size = new System.Drawing.Size(68, 20);
            this.lbl_inputQuantity.TabIndex = 45;
            this.lbl_inputQuantity.Text = "Quantity";
            // 
            // lbl_inputProduct
            // 
            this.lbl_inputProduct.AutoSize = true;
            this.lbl_inputProduct.Location = new System.Drawing.Point(165, 123);
            this.lbl_inputProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputProduct.Name = "lbl_inputProduct";
            this.lbl_inputProduct.Size = new System.Drawing.Size(64, 20);
            this.lbl_inputProduct.TabIndex = 44;
            this.lbl_inputProduct.Text = "Product";
            // 
            // cbx_inputDiscount
            // 
            this.cbx_inputDiscount.FormattingEnabled = true;
            this.cbx_inputDiscount.Location = new System.Drawing.Point(575, 161);
            this.cbx_inputDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_inputDiscount.Name = "cbx_inputDiscount";
            this.cbx_inputDiscount.Size = new System.Drawing.Size(180, 28);
            this.cbx_inputDiscount.TabIndex = 43;
            // 
            // cbx_inputProduct
            // 
            this.cbx_inputProduct.FormattingEnabled = true;
            this.cbx_inputProduct.Location = new System.Drawing.Point(66, 163);
            this.cbx_inputProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_inputProduct.Name = "cbx_inputProduct";
            this.cbx_inputProduct.Size = new System.Drawing.Size(262, 28);
            this.cbx_inputProduct.TabIndex = 42;
            // 
            // lbl_titleInsertOrderItemData
            // 
            this.lbl_titleInsertOrderItemData.AutoSize = true;
            this.lbl_titleInsertOrderItemData.Location = new System.Drawing.Point(357, 45);
            this.lbl_titleInsertOrderItemData.Name = "lbl_titleInsertOrderItemData";
            this.lbl_titleInsertOrderItemData.Size = new System.Drawing.Size(169, 20);
            this.lbl_titleInsertOrderItemData.TabIndex = 48;
            this.lbl_titleInsertOrderItemData.Text = "Insert Order Item Data";
            // 
            // btn_insertOrderItem
            // 
            this.btn_insertOrderItem.Location = new System.Drawing.Point(786, 121);
            this.btn_insertOrderItem.Name = "btn_insertOrderItem";
            this.btn_insertOrderItem.Size = new System.Drawing.Size(144, 85);
            this.btn_insertOrderItem.TabIndex = 49;
            this.btn_insertOrderItem.Text = "Insert Order Item";
            this.btn_insertOrderItem.UseVisualStyleBackColor = true;
            this.btn_insertOrderItem.Click += new System.EventHandler(this.btn_insertOrderItem_Click);
            // 
            // btn_backToMain
            // 
            this.btn_backToMain.Location = new System.Drawing.Point(995, 121);
            this.btn_backToMain.Name = "btn_backToMain";
            this.btn_backToMain.Size = new System.Drawing.Size(144, 85);
            this.btn_backToMain.TabIndex = 50;
            this.btn_backToMain.Text = "Back To Main";
            this.btn_backToMain.UseVisualStyleBackColor = true;
            this.btn_backToMain.Click += new System.EventHandler(this.btn_backToMain_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 286);
            this.Controls.Add(this.btn_backToMain);
            this.Controls.Add(this.btn_insertOrderItem);
            this.Controls.Add(this.lbl_titleInsertOrderItemData);
            this.Controls.Add(this.lbl_inputDiscount);
            this.Controls.Add(this.tbx_inputQuantity);
            this.Controls.Add(this.lbl_inputQuantity);
            this.Controls.Add(this.lbl_inputProduct);
            this.Controls.Add(this.cbx_inputDiscount);
            this.Controls.Add(this.cbx_inputProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inputDiscount;
        private System.Windows.Forms.TextBox tbx_inputQuantity;
        private System.Windows.Forms.Label lbl_inputQuantity;
        private System.Windows.Forms.Label lbl_inputProduct;
        private System.Windows.Forms.ComboBox cbx_inputDiscount;
        private System.Windows.Forms.ComboBox cbx_inputProduct;
        private System.Windows.Forms.Label lbl_titleInsertOrderItemData;
        private System.Windows.Forms.Button btn_insertOrderItem;
        private System.Windows.Forms.Button btn_backToMain;
    }
}