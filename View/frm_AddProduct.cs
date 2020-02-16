using Kotches.BusinessImp;
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
    public partial class frm_AddProduct : Form
    {
        public frm_AddProduct()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            combo_producttype.SelectedIndex    =   0;
            combo_productSize.SelectedIndex    =   0;
            combo_productNumber.SelectedIndex  =   0;
            combo_productColor.SelectedIndex   =   0;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductBaoImp Bao = new ProductBaoImp();
           try
            {
                int isProductExist = 0;
                isProductExist = Bao.getProduct(txt_productName.Text, combo_producttype.SelectedItem.ToString(), Convert.ToDouble(txt_productCost.Text), Convert.ToDouble(txt_productPrice.Text),
                combo_productColor.SelectedItem.ToString(), Convert.ToInt32(combo_productSize.SelectedItem)).Rows.Count;

            if (isProductExist == 0)
            {
                Bao.addProduct(txt_productCode.Text, txt_productName.Text, combo_producttype.SelectedItem.ToString(), Convert.ToDouble(txt_productCost.Text), Convert.ToDouble(txt_productPrice.Text));
                Bao.addProductDiscription(Convert.ToInt32(combo_productSize.SelectedItem), combo_productColor.SelectedItem.ToString(), Convert.ToInt32(combo_productNumber.SelectedItem), txt_productCode.Text);


                MessageBox.Show("تم اضافة المنتج");
                
            }
            else if (isProductExist != 0 )
            {

                if (MessageBox.Show(" هل تريد تحديث بياناته", "تنبيه هذا المنتج موجود", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    dataGridView1.DataSource = (Bao.getProductId(txt_productCode.Text, combo_productColor.SelectedItem.ToString(), Convert.ToInt32(combo_productNumber.SelectedItem), Convert.ToInt32(combo_productSize.SelectedItem)));
                    int id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);

                    dataGridView1.DataSource = Bao.getProduct(txt_productName.Text, combo_producttype.SelectedItem.ToString(), Convert.ToDouble(txt_productCost.Text), Convert.ToDouble(txt_productPrice.Text),
                    combo_productColor.SelectedItem.ToString(), Convert.ToInt32(combo_productSize.SelectedItem));

                    string productCode = dataGridView1.Rows[0].Cells[0].Value.ToString();


                    Bao.updateProduct(productCode, txt_productName.Text, combo_producttype.SelectedItem.ToString(), Convert.ToDouble(txt_productCost.Text), Convert.ToDouble(txt_productPrice.Text));
                    Bao.updateProductDiscription(productCode, combo_productColor.SelectedItem.ToString(), Convert.ToInt32(combo_productNumber.SelectedItem), Convert.ToInt32(combo_productSize.SelectedItem), id);
                    MessageBox.Show("تم تحديث بيانات المنتج");
                }
                else
                {
                    MessageBox.Show("تم الالغاء");
                }
               

            }
           
                
                txt_productCode.Text = Bao.getLastProductId().Rows[0][0].ToString();
                txt_productName.Text = Bao.getLastProduct().Rows[0][1].ToString();
                combo_producttype.SelectedItem = Bao.getLastProduct().Rows[0][2].ToString();
                txt_productCost.Text = Bao.getLastProduct().Rows[0][3].ToString();
                txt_productPrice.Text = Bao.getLastProduct().Rows[0][4].ToString();
                combo_productColor.SelectedItem = Bao.getLastProduct().Rows[0][5].ToString();
                combo_productSize.SelectedItem = Bao.getLastProduct().Rows[0][6].ToString();
                combo_productNumber.SelectedItem = Bao.getLastProduct().Rows[0][7].ToString();

                frm_Products.getFRMProducts.data_products.DataSource = Bao.getProducts();
                frm_Products.getFRMProducts.data_products.Update(); 
            }
             catch
             {
                 MessageBox.Show("لم تتم الاضافه تأكد ان جميع المعلومات صحيحه");
             }
             
         
        }

        private void combo_colorsNmber_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
