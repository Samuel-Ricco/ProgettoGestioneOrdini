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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //cbx_inputProduct

            cbx_inputDiscount.Items.Add("0.05");
            cbx_inputDiscount.Items.Add("0.07");
            cbx_inputDiscount.Items.Add("0.10");
            cbx_inputDiscount.Items.Add("0.20");
        }

        private void btn_insertOrderItem_Click(object sender, EventArgs e)
        {
            if (!CheckCorrectOrderItemInput())
            {
                
            }
            else
            {
                MessageBox.Show("Dati inseriti non corretti");
            }
        }

        private bool CheckCorrectOrderItemInput()
        {
            int n;
            if (int.TryParse(tbx_inputQuantity.Text, out n))
            {
                MessageBox.Show("Devi inserire un numero intero");
                return false;
            }
            else if (n <= 0)
            {
                MessageBox.Show("Devi inserire un numero intero");
            }
            return true;
        }
    }
}
