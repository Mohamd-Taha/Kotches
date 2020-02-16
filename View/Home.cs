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
        BusinessImp.EmployeeBaoImp BaoEmp = new BusinessImp.EmployeeBaoImp();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            
            frm_Login frm  = new frm_Login();

            this.Hide();

            frm.ShowDialog();
            this.Close();

        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            frm_Users frm = new frm_Users();
            frm.data_Users.DataSource = BaoEmp.getEmployee();
            frm.Show();
        }
    }
}
