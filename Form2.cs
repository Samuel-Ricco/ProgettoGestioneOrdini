using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGruppo2
{
    public partial class Form2 : Form
    {
        public DataBase db;

        public Form2()
        {
            InitializeComponent();
            db = new DataBase();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbx_inputCustomer.DataSource = db.ctx.customers.ToList();
            cbx_inputCustomer.DisplayMember = "full_name";
            cbx_inputCustomer.ValueMember = "customer_id";

            cbx_inputStore.DataSource = db.ctx.stores.ToList();
            cbx_inputStore.DisplayMember = "store_name";
            cbx_inputStore.ValueMember = "store_id";

            cbx_inputStaff.DataSource = db.ctx.staffs.ToList();
            cbx_inputStaff.DisplayMember = "full_name";
            cbx_inputStaff.ValueMember = "staff_id";

            cbx_inputOrderStatus.Items.Add("In Elaborazione");
            cbx_inputOrderStatus.Items.Add("Spedito");
            cbx_inputOrderStatus.Items.Add("In Consegna");
            cbx_inputOrderStatus.Items.Add("Consegnato");


        }

        private void btn_insertOrder_Click(object sender, EventArgs e)
        {
            var o = new order();
            o.customer_id = (int)cbx_inputCustomer.SelectedValue;
            o.order_status = (byte)(cbx_inputOrderStatus.SelectedIndex + 1);
            o.order_date = dtp_inputOrderDate.Value;
            o.required_date = dtp_inputRequiredDate.Value;
            o.shipped_date = dtp_inputShippedDate.Value;
            o.store_id = (int)cbx_inputStore.SelectedValue;
            o.staff_id = (int)cbx_inputStaff.SelectedValue;
            
            //db.ctx.orders.Add(o);
            //db.ctx.SaveChanges();

            this.Close();
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}
