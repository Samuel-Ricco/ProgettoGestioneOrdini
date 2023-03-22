using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProgettoGruppo2
{
    public partial class Form1 : Form
    {
        public DataBase db;

        public Form1()
        {
            InitializeComponent();
            db = new DataBase();

            List<order> nullList = new List<order>();
            dgw_orderTable.DataSource = nullList;
            dgw_orderTable.Columns["customer_id"].Visible = false;
            dgw_orderTable.Columns["store_id"].Visible = false;
            dgw_orderTable.Columns["staff_id"].Visible = false;
            dgw_orderTable.Columns["customer"].Visible = false;
            dgw_orderTable.Columns["order_items"].Visible = false;
            dgw_orderTable.Columns["staff"].Visible = false;
            dgw_orderTable.Columns["store"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_customers.DataSource = db.ctx.customers.ToList();
            cbx_customers.DisplayMember = "full_name";
            cbx_customers.ValueMember = "customer_id";
        }

        private void btn_goToInsertOrder_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void btn_loadOrders_Click(object sender, EventArgs e)
        {
            dgw_orderTable.DataSource = db.GetOrdersById((int)cbx_customers.SelectedValue);
        }

        private void dgw_orderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            order o = (order)dgw_orderTable.CurrentRow.DataBoundItem;

            dgw_orderDetailsTable.DataSource = db.GetOrderItems(o.order_id).ToList();

            var c = db.GetOrderDetails(o.order_id).ToList();
            tbx_city.Text = c[0].city_store.ToString();
            tbx_fullStaffName.Text = c[0].staff_name.ToString() + c[0].staff_surname.ToString();
        }
    }
}
