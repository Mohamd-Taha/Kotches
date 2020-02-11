using Kotches.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kotches
{
    public partial class Home : Form
    {
        BusinessImp.ProductBaoImp baoImp = new BusinessImp.ProductBaoImp();
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Sells_Click(object sender, EventArgs e)
        {

        }

        private void btn_SellingBill_Click(object sender, EventArgs e)
        {

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            frm_Products frm = new frm_Products();
            frm.data_products.DataSource = baoImp.getProducts();
            frm.Show();

        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.Show();
        }

        private void btn_IncreaseCategory_Click(object sender, EventArgs e)
        {
            frm_BuyProduct frm = new frm_BuyProduct();
            frm.Show();

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
