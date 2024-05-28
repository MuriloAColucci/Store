using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class LOJA : Form
    {
        public LOJA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 
        private void clientRegister_Click(object sender, EventArgs e)
        {
            Form window_client = new Client();
            window_client.ShowDialog();
        }

        private void productRegister_Click(object sender, EventArgs e)
        {
            Form window_product = new Product();
            window_product.ShowDialog();
        }

        private void saleRegister_Click(object sender, EventArgs e)
        {
            Form window_sale = new Sale();
            window_sale.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Form window_sale = new Report();
            window_sale.ShowDialog();
        }
    }
}
