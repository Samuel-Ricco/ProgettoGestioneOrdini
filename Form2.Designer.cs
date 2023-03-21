namespace ProgettoGruppo2
{
    partial class Form2
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
            this.lbl_inputShippedDate = new System.Windows.Forms.Label();
            this.lbl_inputRequiredDate = new System.Windows.Forms.Label();
            this.lbl_inputOrderDate = new System.Windows.Forms.Label();
            this.lbl_inputOrderStatus = new System.Windows.Forms.Label();
            this.lbl_inputStaff = new System.Windows.Forms.Label();
            this.lbl_inputStore = new System.Windows.Forms.Label();
            this.lbl_inputCustomer = new System.Windows.Forms.Label();
            this.btn_insertOrder = new System.Windows.Forms.Button();
            this.dtp_inputRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.cbx_inputOrderStatus = new System.Windows.Forms.ComboBox();
            this.dtp_inputShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_inputOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cbx_inputStaff = new System.Windows.Forms.ComboBox();
            this.cbx_inputStore = new System.Windows.Forms.ComboBox();
            this.cbx_inputCustomer = new System.Windows.Forms.ComboBox();
            this.lbl_titleInsertOrderData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_inputShippedDate
            // 
            this.lbl_inputShippedDate.AutoSize = true;
            this.lbl_inputShippedDate.Location = new System.Drawing.Point(819, 201);
            this.lbl_inputShippedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputShippedDate.Name = "lbl_inputShippedDate";
            this.lbl_inputShippedDate.Size = new System.Drawing.Size(107, 20);
            this.lbl_inputShippedDate.TabIndex = 35;
            this.lbl_inputShippedDate.Text = "Shipped Date";
            // 
            // lbl_inputRequiredDate
            // 
            this.lbl_inputRequiredDate.AutoSize = true;
            this.lbl_inputRequiredDate.Location = new System.Drawing.Point(469, 201);
            this.lbl_inputRequiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputRequiredDate.Name = "lbl_inputRequiredDate";
            this.lbl_inputRequiredDate.Size = new System.Drawing.Size(113, 20);
            this.lbl_inputRequiredDate.TabIndex = 34;
            this.lbl_inputRequiredDate.Text = "Required Date";
            // 
            // lbl_inputOrderDate
            // 
            this.lbl_inputOrderDate.AutoSize = true;
            this.lbl_inputOrderDate.Location = new System.Drawing.Point(138, 201);
            this.lbl_inputOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputOrderDate.Name = "lbl_inputOrderDate";
            this.lbl_inputOrderDate.Size = new System.Drawing.Size(88, 20);
            this.lbl_inputOrderDate.TabIndex = 33;
            this.lbl_inputOrderDate.Text = "Order Date";
            // 
            // lbl_inputOrderStatus
            // 
            this.lbl_inputOrderStatus.AutoSize = true;
            this.lbl_inputOrderStatus.Location = new System.Drawing.Point(1131, 84);
            this.lbl_inputOrderStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputOrderStatus.Name = "lbl_inputOrderStatus";
            this.lbl_inputOrderStatus.Size = new System.Drawing.Size(100, 20);
            this.lbl_inputOrderStatus.TabIndex = 32;
            this.lbl_inputOrderStatus.Text = "Order Status";
            // 
            // lbl_inputStaff
            // 
            this.lbl_inputStaff.AutoSize = true;
            this.lbl_inputStaff.Location = new System.Drawing.Point(819, 84);
            this.lbl_inputStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputStaff.Name = "lbl_inputStaff";
            this.lbl_inputStaff.Size = new System.Drawing.Size(44, 20);
            this.lbl_inputStaff.TabIndex = 31;
            this.lbl_inputStaff.Text = "Staff";
            // 
            // lbl_inputStore
            // 
            this.lbl_inputStore.AutoSize = true;
            this.lbl_inputStore.Location = new System.Drawing.Point(487, 84);
            this.lbl_inputStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputStore.Name = "lbl_inputStore";
            this.lbl_inputStore.Size = new System.Drawing.Size(48, 20);
            this.lbl_inputStore.TabIndex = 30;
            this.lbl_inputStore.Text = "Store";
            // 
            // lbl_inputCustomer
            // 
            this.lbl_inputCustomer.AutoSize = true;
            this.lbl_inputCustomer.Location = new System.Drawing.Point(138, 84);
            this.lbl_inputCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inputCustomer.Name = "lbl_inputCustomer";
            this.lbl_inputCustomer.Size = new System.Drawing.Size(78, 20);
            this.lbl_inputCustomer.TabIndex = 29;
            this.lbl_inputCustomer.Text = "Customer";
            // 
            // btn_insertOrder
            // 
            this.btn_insertOrder.Location = new System.Drawing.Point(1104, 210);
            this.btn_insertOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_insertOrder.Name = "btn_insertOrder";
            this.btn_insertOrder.Size = new System.Drawing.Size(188, 88);
            this.btn_insertOrder.TabIndex = 28;
            this.btn_insertOrder.Text = "Insert Order";
            this.btn_insertOrder.UseVisualStyleBackColor = true;
            this.btn_insertOrder.Click += new System.EventHandler(this.btn_insertOrder_Click);
            // 
            // dtp_inputRequiredDate
            // 
            this.dtp_inputRequiredDate.Location = new System.Drawing.Point(376, 239);
            this.dtp_inputRequiredDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_inputRequiredDate.Name = "dtp_inputRequiredDate";
            this.dtp_inputRequiredDate.Size = new System.Drawing.Size(298, 26);
            this.dtp_inputRequiredDate.TabIndex = 27;
            // 
            // cbx_inputOrderStatus
            // 
            this.cbx_inputOrderStatus.FormattingEnabled = true;
            this.cbx_inputOrderStatus.Location = new System.Drawing.Point(1032, 124);
            this.cbx_inputOrderStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_inputOrderStatus.Name = "cbx_inputOrderStatus";
            this.cbx_inputOrderStatus.Size = new System.Drawing.Size(298, 28);
            this.cbx_inputOrderStatus.TabIndex = 26;
            // 
            // dtp_inputShippedDate
            // 
            this.dtp_inputShippedDate.Location = new System.Drawing.Point(723, 239);
            this.dtp_inputShippedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_inputShippedDate.Name = "dtp_inputShippedDate";
            this.dtp_inputShippedDate.Size = new System.Drawing.Size(298, 26);
            this.dtp_inputShippedDate.TabIndex = 25;
            // 
            // dtp_inputOrderDate
            // 
            this.dtp_inputOrderDate.Location = new System.Drawing.Point(33, 239);
            this.dtp_inputOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_inputOrderDate.Name = "dtp_inputOrderDate";
            this.dtp_inputOrderDate.Size = new System.Drawing.Size(298, 26);
            this.dtp_inputOrderDate.TabIndex = 24;
            // 
            // cbx_inputStaff
            // 
            this.cbx_inputStaff.FormattingEnabled = true;
            this.cbx_inputStaff.Location = new System.Drawing.Point(692, 124);
            this.cbx_inputStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_inputStaff.Name = "cbx_inputStaff";
            this.cbx_inputStaff.Size = new System.Drawing.Size(298, 28);
            this.cbx_inputStaff.TabIndex = 23;
            // 
            // cbx_inputStore
            // 
            this.cbx_inputStore.FormattingEnabled = true;
            this.cbx_inputStore.Location = new System.Drawing.Point(362, 124);
            this.cbx_inputStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_inputStore.Name = "cbx_inputStore";
            this.cbx_inputStore.Size = new System.Drawing.Size(298, 28);
            this.cbx_inputStore.TabIndex = 22;
            // 
            // cbx_inputCustomer
            // 
            this.cbx_inputCustomer.FormattingEnabled = true;
            this.cbx_inputCustomer.Location = new System.Drawing.Point(28, 124);
            this.cbx_inputCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_inputCustomer.Name = "cbx_inputCustomer";
            this.cbx_inputCustomer.Size = new System.Drawing.Size(298, 28);
            this.cbx_inputCustomer.TabIndex = 21;
            // 
            // lbl_titleInsertOrderData
            // 
            this.lbl_titleInsertOrderData.AutoSize = true;
            this.lbl_titleInsertOrderData.Location = new System.Drawing.Point(630, 28);
            this.lbl_titleInsertOrderData.Name = "lbl_titleInsertOrderData";
            this.lbl_titleInsertOrderData.Size = new System.Drawing.Size(133, 20);
            this.lbl_titleInsertOrderData.TabIndex = 36;
            this.lbl_titleInsertOrderData.Text = "Insert Order Data";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 392);
            this.Controls.Add(this.lbl_titleInsertOrderData);
            this.Controls.Add(this.lbl_inputShippedDate);
            this.Controls.Add(this.lbl_inputRequiredDate);
            this.Controls.Add(this.lbl_inputOrderDate);
            this.Controls.Add(this.lbl_inputOrderStatus);
            this.Controls.Add(this.lbl_inputStaff);
            this.Controls.Add(this.lbl_inputStore);
            this.Controls.Add(this.lbl_inputCustomer);
            this.Controls.Add(this.btn_insertOrder);
            this.Controls.Add(this.dtp_inputRequiredDate);
            this.Controls.Add(this.cbx_inputOrderStatus);
            this.Controls.Add(this.dtp_inputShippedDate);
            this.Controls.Add(this.dtp_inputOrderDate);
            this.Controls.Add(this.cbx_inputStaff);
            this.Controls.Add(this.cbx_inputStore);
            this.Controls.Add(this.cbx_inputCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inputShippedDate;
        private System.Windows.Forms.Label lbl_inputRequiredDate;
        private System.Windows.Forms.Label lbl_inputOrderDate;
        private System.Windows.Forms.Label lbl_inputOrderStatus;
        private System.Windows.Forms.Label lbl_inputStaff;
        private System.Windows.Forms.Label lbl_inputStore;
        private System.Windows.Forms.Label lbl_inputCustomer;
        private System.Windows.Forms.Button btn_insertOrder;
        private System.Windows.Forms.DateTimePicker dtp_inputRequiredDate;
        private System.Windows.Forms.ComboBox cbx_inputOrderStatus;
        private System.Windows.Forms.DateTimePicker dtp_inputShippedDate;
        private System.Windows.Forms.DateTimePicker dtp_inputOrderDate;
        private System.Windows.Forms.ComboBox cbx_inputStaff;
        private System.Windows.Forms.ComboBox cbx_inputStore;
        private System.Windows.Forms.ComboBox cbx_inputCustomer;
        private System.Windows.Forms.Label lbl_titleInsertOrderData;
    }
}