using System;
using Kotches.BusinessImp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kotches.View
{
    public partial class frm_Products : Form
    {
        private static frm_Products frmproducts;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmproducts = null;
        }
        public static frm_Products getFRMProducts
        {
                get
                {   
                if (frmproducts == null)
                {
                    frmproducts = new frm_Products();
                    frmproducts.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frmproducts;


                }
        }
        ProductBaoImp Bao = new ProductBaoImp();
        public frm_Products()
        {
            InitializeComponent();
            if (frmproducts == null)
            {
                frmproducts = this;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchWord.Text != string.Empty)
            {
                data_products.DataSource = Bao.searchInProducts(txt_searchWord.Text);
            }
            else
                data_products.DataSource = Bao.getProducts();


        }

        private void btn_IncreaseCategory_Click(object sender, EventArgs e)
        {
            View.frm_BuyProduct frm = new frm_BuyProduct();

            try
            {
                frm.txt_productCode.Text = data_products.CurrentRow.Cells[0].Value.ToString();
                frm.combo_productName.SelectedItem = data_products.CurrentRow.Cells[1].Value.ToString();
                frm.txt_productCost.Text = data_products.CurrentRow.Cells[3].Value.ToString();
                frm.txt_productPrice.Text = data_products.CurrentRow.Cells[4].Value.ToString();
                frm.combo_productColor.SelectedItem = data_products.CurrentRow.Cells[5].Value.ToString();
                frm.combo_productSize.SelectedItem = data_products.CurrentRow.Cells[6].Value.ToString();
                frm.combo_productNumber.SelectedItem = data_products.CurrentRow.Cells[7].Value.ToString();
                frm.Show();
            }
            catch
            {
                MessageBox.Show("الرجاء اختيار المنتج المراد تزويده", "فشل التزويد", MessageBoxButtons.OK);
            }
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.txt_productCode.Text = Bao.getLastProductId().Rows[0][0].ToString();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Bao.deleteProduct(data_products.CurrentRow.Cells[0].Value.ToString());
                data_products.DataSource = Bao.getProducts();
                data_products.Update();
                MessageBox.Show("تمت عملية الحذف بنجاح", "تم الحذف", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("الرجاء اختيار المنتج المراد حذفه", "فشل الحذف", MessageBoxButtons.OK);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            try
            {
                frm.txt_productCode.Text = data_products.CurrentRow.Cells[0].Value.ToString();
                frm.txt_productName.Text = data_products.CurrentRow.Cells[1].Value.ToString();
                frm.combo_producttype.SelectedItem = data_products.CurrentRow.Cells[2].Value.ToString();
                frm.txt_productCost.Text = data_products.CurrentRow.Cells[3].Value.ToString();
                frm.txt_productPrice.Text = data_products.CurrentRow.Cells[4].Value.ToString();
                frm.combo_productColor.SelectedItem = data_products.CurrentRow.Cells[5].Value.ToString();
                frm.combo_productSize.SelectedItem = data_products.CurrentRow.Cells[6].Value.ToString();
                frm.combo_productNumber.SelectedItem = data_products.CurrentRow.Cells[7].Value.ToString();
                frm.Show();
            }
            catch
            {
                MessageBox.Show("الرجاء اختيار المنتج المراد التعديل عليه", "فشل التعديل", MessageBoxButtons.OK);
            }
        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            Data_Acess_Layer.DALConection DAL = new Data_Acess_Layer.DALConection();
            DAL.open();
            
                  SqlCommand cmd = new SqlCommand("Select product_name From Product",DAL.sqlconnection);
                
                 SqlDataReader reader = cmd.ExecuteReader();
                 AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                 while (reader.Read())
                 {
                     MyCollection.Add(reader.GetString(0));
                 }
                 txt_searchWord.AutoCompleteCustomSource = MyCollection;
            DAL.close();
            

        }
    }
}
