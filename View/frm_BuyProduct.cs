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
    public partial class frm_BuyProduct : Form
    {
        BusinessImp.ProductBaoImp Bao = new BusinessImp.ProductBaoImp();
        public frm_BuyProduct()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bao.updateProductNumber(Convert.ToInt32(combo_productNumber.SelectedItem),txt_productCode.Text);
            frm_Products.getFRMProducts.data_products.DataSource = Bao.getProducts();
            frm_Products.getFRMProducts.data_products.Update();
            MessageBox.Show("تم تزويد العدد لل المنتج");
        }

        private void frm_BuyProduct_Load(object sender, EventArgs e)
        {

        }

        private void combo_productColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
