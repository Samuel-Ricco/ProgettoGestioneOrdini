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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.btn_loadOrderDetails = new System.Windows.Forms.Button();
            this.btn_goToInsertOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderDetailsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_customers
            // 
            this.cbx_customers.FormattingEnabled = true;
            this.cbx_customers.Location = new System.Drawing.Point(80, 182);
            this.cbx_customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_customers.Name = "cbx_customers";
            this.cbx_customers.Size = new System.Drawing.Size(378, 28);
            this.cbx_customers.TabIndex = 0;
            // 
            // dgw_orderTable
            // 
            this.dgw_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orderTable.Location = new System.Drawing.Point(528, 18);
            this.dgw_orderTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_orderTable.Name = "dgw_orderTable";
            this.dgw_orderTable.RowHeadersWidth = 62;
            this.dgw_orderTable.Size = new System.Drawing.Size(808, 274);
            this.dgw_orderTable.TabIndex = 1;
            // 
            // dgw_orderDetailsTable
            // 
            this.dgw_orderDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orderDetailsTable.Location = new System.Drawing.Point(27, 451);
            this.dgw_orderDetailsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_orderDetailsTable.Name = "dgw_orderDetailsTable";
            this.dgw_orderDetailsTable.RowHeadersWidth = 62;
            this.dgw_orderDetailsTable.Size = new System.Drawing.Size(1310, 148);
            this.dgw_orderDetailsTable.TabIndex = 2;
            // 
            // btn_loadOrders
            // 
            this.btn_loadOrders.Location = new System.Drawing.Point(170, 48);
            this.btn_loadOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadOrders.Name = "btn_loadOrders";
            this.btn_loadOrders.Size = new System.Drawing.Size(188, 88);
            this.btn_loadOrders.TabIndex = 10;
            this.btn_loadOrders.Text = "Load Orders";
            this.btn_loadOrders.UseVisualStyleBackColor = true;
            // 
            // lbl_customers
            // 
            this.lbl_customers.AutoSize = true;
            this.lbl_customers.Location = new System.Drawing.Point(240, 157);
            this.lbl_customers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(86, 20);
            this.lbl_customers.TabIndex = 12;
            this.lbl_customers.Text = "Customers";
            // 
            // btn_loadOrderDetails
            // 
            this.btn_loadOrderDetails.Location = new System.Drawing.Point(1149, 302);
            this.btn_loadOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_loadOrderDetails.Name = "btn_loadOrderDetails";
            this.btn_loadOrderDetails.Size = new System.Drawing.Size(188, 88);
            this.btn_loadOrderDetails.TabIndex = 13;
            this.btn_loadOrderDetails.Text = "Load Order Details";
            this.btn_loadOrderDetails.UseVisualStyleBackColor = true;
            // 
            // btn_goToInsertOrder
            // 
            this.btn_goToInsertOrder.Location = new System.Drawing.Point(361, 671);
            this.btn_goToInsertOrder.Name = "btn_goToInsertOrder";
            this.btn_goToInsertOrder.Size = new System.Drawing.Size(631, 91);
            this.btn_goToInsertOrder.TabIndex = 14;
            this.btn_goToInsertOrder.Text = "Go To Insert Order";
            this.btn_goToInsertOrder.UseVisualStyleBackColor = true;
            this.btn_goToInsertOrder.Click += new System.EventHandler(this.btn_goToInsertOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 822);
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
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_customers;
        private System.Windows.Forms.DataGridView dgw_orderTable;
        private System.Windows.Forms.DataGridView dgw_orderDetailsTable;
        private System.Windows.Forms.Button btn_loadOrders;
        private System.Windows.Forms.Label lbl_customers;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button btn_loadOrderDetails;
        private System.Windows.Forms.Button btn_goToInsertOrder;
    }
}

