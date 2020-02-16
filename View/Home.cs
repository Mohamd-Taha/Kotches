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
        BusinessImp.ProductBaoImp Bao = new BusinessImp.ProductBaoImp();
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Sells_Click(object sender, EventArgs e)
        {
            frm_Sells _sells = new frm_Sells();
            _sells.ShowDialog();
        }


        private void btn_SellingBill_Click(object sender, EventArgs e)
        {
            frm_SellingBill _Selling = new frm_SellingBill();
            _Selling.txt_currentUser.Text = Program.user_name;
            _Selling.ShowDialog();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            frm_Products frm = new frm_Products();
            frm.data_products.DataSource = Bao.getProducts();
            frm.Show();
            
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.txt_productCode.Text = Bao.getLastProductId().Rows[0][0].ToString();
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

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_Login _Login = new frm_Login();
            _Login.ShowDialog();

        }
    }
}
