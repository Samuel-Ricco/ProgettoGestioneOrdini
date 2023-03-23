namespace ProgettoGruppo2
{
    partial class Form1
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
            this.cbx_customers = new System.Windows.Forms.ComboBox();
            this.dgw_orderTable = new System.Windows.Forms.DataGridView();
            this.dgw_orderDetailsTable = new System.Windows.Forms.DataGridView();
            this.btn_loadOrders = new System.Windows.Forms.Button();
            this.lbl_customers = new System.Windows.Forms.Label();
            this.btn_loadOrderDetails = new System.Windows.Forms.Button();
            this.btn_goToInsertOrder = new System.Windows.Forms.Button();
            this.tbx_city = new System.Windows.Forms.TextBox();
            this.tbx_fullStaffName = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_staff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderDetailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_customers
            // 
            this.cbx_customers.FormattingEnabled = true;
            this.cbx_customers.Location = new System.Drawing.Point(45, 181);
            this.cbx_customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_customers.Name = "cbx_customers";
            this.cbx_customers.Size = new System.Drawing.Size(219, 28);
            this.cbx_customers.TabIndex = 0;
            // 
            // dgw_orderTable
            // 
            this.dgw_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orderTable.Location = new System.Drawing.Point(528, 18);
            this.dgw_orderTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_orderTable.Name = "dgw_orderTable";
            this.dgw_orderTable.RowHeadersWidth = 62;
            this.dgw_orderTable.Size = new System.Drawing.Size(697, 192);
            this.dgw_orderTable.TabIndex = 1;
            this.dgw_orderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_orderTable_CellContentClick);
            // 
            // dgw_orderDetailsTable
            // 
            this.dgw_orderDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orderDetailsTable.Location = new System.Drawing.Point(528, 316);
            this.dgw_orderDetailsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_orderDetailsTable.Name = "dgw_orderDetailsTable";
            this.dgw_orderDetailsTable.RowHeadersWidth = 62;
            this.dgw_orderDetailsTable.Size = new System.Drawing.Size(697, 117);
            this.dgw_orderDetailsTable.TabIndex = 2;
            // 
            // btn_loadOrders
            // 
            this.btn_loadOrders.Location = new System.Drawing.Point(308, 156);
            this.btn_loadOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadOrders.Name = "btn_loadOrders";
            this.btn_loadOrders.Size = new System.Drawing.Size(147, 54);
            this.btn_loadOrders.TabIndex = 10;
            this.btn_loadOrders.Text = "Load Orders";
            this.btn_loadOrders.UseVisualStyleBackColor = true;
            this.btn_loadOrders.Click += new System.EventHandler(this.btn_loadOrders_Click);
            // 
            // lbl_customers
            // 
            this.lbl_customers.AutoSize = true;
            this.lbl_customers.Location = new System.Drawing.Point(111, 156);
            this.lbl_customers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(86, 20);
            this.lbl_customers.TabIndex = 12;
            this.lbl_customers.Text = "Customers";
            // 
            // btn_loadOrderDetails
            // 
            this.btn_loadOrderDetails.Location = new System.Drawing.Point(528, 234);
            this.btn_loadOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadOrderDetails.Name = "btn_loadOrderDetails";
            this.btn_loadOrderDetails.Size = new System.Drawing.Size(697, 49);
            this.btn_loadOrderDetails.TabIndex = 13;
            this.btn_loadOrderDetails.Text = "Load Order Details";
            this.btn_loadOrderDetails.UseVisualStyleBackColor = true;
            // 
            // btn_goToInsertOrder
            // 
            this.btn_goToInsertOrder.Location = new System.Drawing.Point(45, 39);
            this.btn_goToInsertOrder.Name = "btn_goToInsertOrder";
            this.btn_goToInsertOrder.Size = new System.Drawing.Size(410, 46);
            this.btn_goToInsertOrder.TabIndex = 14;
            this.btn_goToInsertOrder.Text = "Go To Insert Order";
            this.btn_goToInsertOrder.UseVisualStyleBackColor = true;
            this.btn_goToInsertOrder.Click += new System.EventHandler(this.btn_goToInsertOrder_Click);
            // 
            // tbx_city
            // 
            this.tbx_city.Location = new System.Drawing.Point(197, 316);
            this.tbx_city.Name = "tbx_city";
            this.tbx_city.Size = new System.Drawing.Size(135, 26);
            this.tbx_city.TabIndex = 15;
            // 
            // tbx_fullStaffName
            // 
            this.tbx_fullStaffName.Location = new System.Drawing.Point(197, 366);
            this.tbx_fullStaffName.Name = "tbx_fullStaffName";
            this.tbx_fullStaffName.Size = new System.Drawing.Size(135, 26);
            this.tbx_fullStaffName.TabIndex = 16;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(77, 321);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(35, 20);
            this.lbl_city.TabIndex = 17;
            this.lbl_city.Text = "City";
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Location = new System.Drawing.Point(81, 371);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(90, 20);
            this.lbl_staff.TabIndex = 18;
            this.lbl_staff.Text = "Staff Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 472);
            this.Controls.Add(this.lbl_staff);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.tbx_fullStaffName);
            this.Controls.Add(this.tbx_city);
            this.Controls.Add(this.btn_goToInsertOrder);
            this.Controls.Add(this.btn_loadOrderDetails);
            this.Controls.Add(this.lbl_customers);
            this.Controls.Add(this.btn_loadOrders);
            this.Controls.Add(this.dgw_orderDetailsTable);
            this.Controls.Add(this.dgw_orderTable);
            this.Controls.Add(this.cbx_customers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderDetailsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_customers;
        private System.Windows.Forms.DataGridView dgw_orderTable;
        private System.Windows.Forms.DataGridView dgw_orderDetailsTable;
        private System.Windows.Forms.Button btn_loadOrders;
        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.Button btn_loadOrderDetails;
        private System.Windows.Forms.Button btn_goToInsertOrder;
        private System.Windows.Forms.TextBox tbx_city;
        private System.Windows.Forms.TextBox tbx_fullStaffName;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_staff;
    }
}

