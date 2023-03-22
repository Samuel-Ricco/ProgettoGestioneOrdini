using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGruppo2
{
    public partial class Form3 : Form
    {
        public int CountItem { get; set; }
        public DataBase db;

        public Form3()
        {
            InitializeComponent();
            db = new DataBase();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cbx_inputProduct.DataSource = db.ctx.products.ToList();
            cbx_inputProduct.DisplayMember = "product_name";

            cbx_inputDiscount.Items.Add("0.05");
            cbx_inputDiscount.Items.Add("0.07");
            cbx_inputDiscount.Items.Add("0.10");
            cbx_inputDiscount.Items.Add("0.20");

            CountItem = 0;
        }

        private void btn_insertOrderItem_Click(object sender, EventArgs e)
        {
            CountItem++;
            var oi = new order_items();
            oi.order_id = db.ctx.orders.OrderByDescending(o => o.order_id).FirstOrDefault().order_id;
            oi.item_id = CountItem;
            oi.product_id = (int)cbx_inputProduct.SelectedValue;
            oi.quantity = int.Parse(tbx_inputQuantity.Text);
            oi.list_price = ((product)cbx_inputProduct.SelectedItem).list_price;
            oi.discount = decimal.Parse(cbx_inputDiscount.Text);

            //db.ctx.orders.Add(o);
            //db.ctx.SaveChanges();            
        }

        private void btn_backToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
