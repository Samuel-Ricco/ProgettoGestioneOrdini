using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Metodo per inserire Nomi prodotti in cbx_inputProduct

            cbx_inputDiscount.Items.Add("0.05");
            cbx_inputDiscount.Items.Add("0.07");
            cbx_inputDiscount.Items.Add("0.10");
            cbx_inputDiscount.Items.Add("0.20");

            CountItem = 0;
        }

        private void btn_insertOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCorrectOrderItemInput())
                {
                    CountItem++;
                    // Metodo per inserire i dati di order item nel db
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
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
            else if (n <= 0 && n > 20)
            {
                MessageBox.Show("Devi inserire un numero compreso tra 1 e 20");
                return false;
            }

            return true;
        }
    }
}
