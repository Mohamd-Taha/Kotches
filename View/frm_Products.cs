using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kotches.View
{
    public partial class frm_Products : Form
    {
        public frm_Products()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_IncreaseCategory_Click(object sender, EventArgs e)
        {
            View.frm_BuyProduct frm = new frm_BuyProduct();
            frm.Show();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.Show();
        }
    }
}
