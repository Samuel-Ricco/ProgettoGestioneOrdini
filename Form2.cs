using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoGruppo2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbx_inputOrderStatus.Items.Add("Status 1");
            cbx_inputOrderStatus.Items.Add("Status 2");
            cbx_inputOrderStatus.Items.Add("Status 3");
            cbx_inputOrderStatus.Items.Add("Status 4");
        }

        private void btn_insertOrder_Click(object sender, EventArgs e)
        {
            if(CheckCorrectOrderInput())
            {


                Form3 frm = new Form3();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dati inseriti non corretti");
            }
        }

        private bool CheckCorrectOrderInput()
        {

            return true;
        }
    }
}
