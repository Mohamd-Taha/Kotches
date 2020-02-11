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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductBaoImp Bao = new ProductBaoImp();
            Bao.addProduct(txt_productCode.Text, txt_productName.Text, txt_productType.Text, Convert.ToInt32(combo_product1Size.SelectedItem), combo_product1Color.Text, Convert.ToInt32(combo_product1Number.SelectedItem), Convert.ToDouble(txt_productCost.Text), Convert.ToDouble(txt_productPrice.Text));
        }

        private void combo_colorsNmber_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(combo_colorsNmber.SelectedItem))
            {
                case 1:
                    combo_product1Color.Enabled = true;
                    combo_product1Size.Enabled = true;
                    combo_product1Number.Enabled = true;

                    combo_product2Color.Enabled = false;
                    combo_product2Size.Enabled = false;
                    combo_product2Number.Enabled = false;

                    combo_product3Color.Enabled = false;
                    combo_product3Size.Enabled = false;
                    combo_product3Number.Enabled = false;

                    combo_product4Color.Enabled = false;
                    combo_product4Size.Enabled = false;
                    combo_product4Number.Enabled = false;

                    combo_product5Color.Enabled = false;
                    combo_product5Size.Enabled = false;
                    combo_product5Number.Enabled = false;


                    break;
                case 2:

                    combo_product1Color.Enabled = true;
                    combo_product1Size.Enabled = true;
                    combo_product1Number.Enabled = true;

                    combo_product2Color.Enabled = true;
                    combo_product2Size.Enabled = true;
                    combo_product2Number.Enabled = true;

                    combo_product3Color.Enabled = false;
                    combo_product3Size.Enabled = false;
                    combo_product3Number.Enabled = false;

                    combo_product4Color.Enabled = false;
                    combo_product4Size.Enabled = false;
                    combo_product4Number.Enabled = false;

                    combo_product5Color.Enabled = false;
                    combo_product5Size.Enabled = false;
                    combo_product5Number.Enabled = false;

                    break;
                case 3:
                    combo_product1Color.Enabled = true;
                    combo_product1Size.Enabled = true;
                    combo_product1Number.Enabled = true;

                    combo_product2Color.Enabled = true;
                    combo_product2Size.Enabled = true;
                    combo_product2Number.Enabled = true;

                    combo_product3Color.Enabled = true;
                    combo_product3Size.Enabled = true;
                    combo_product3Number.Enabled = true;

                    combo_product4Color.Enabled = false;
                    combo_product4Size.Enabled = false;
                    combo_product4Number.Enabled = false;

                    combo_product5Color.Enabled = false;
                    combo_product5Size.Enabled = false;
                    combo_product5Number.Enabled = false;

                    break;
                case 4:

                    combo_product1Color.Enabled = true;
                    combo_product1Size.Enabled = true;
                    combo_product1Number.Enabled = true;

                    combo_product2Color.Enabled = true;
                    combo_product2Size.Enabled = true;
                    combo_product2Number.Enabled = true;

                    combo_product3Color.Enabled = true;
                    combo_product3Size.Enabled = true;
                    combo_product3Number.Enabled = true;

                    combo_product4Color.Enabled = true;
                    combo_product4Size.Enabled = true;
                    combo_product4Number.Enabled = true;

                    combo_product5Color.Enabled = false;
                    combo_product5Size.Enabled = false;
                    combo_product5Number.Enabled = false;

                    break;
                case 5:

                    combo_product1Color.Enabled = true;
                    combo_product1Size.Enabled = true;
                    combo_product1Number.Enabled = true;

                    combo_product2Color.Enabled = true;
                    combo_product2Size.Enabled = true;
                    combo_product2Number.Enabled = true;

                    combo_product3Color.Enabled = true;
                    combo_product3Size.Enabled = true;
                    combo_product3Number.Enabled = true;

                    combo_product4Color.Enabled = true;
                    combo_product4Size.Enabled = true;
                    combo_product4Number.Enabled = true;

                    combo_product5Color.Enabled = true;
                    combo_product5Size.Enabled = true;
                    combo_product5Number.Enabled = true;

                    break;

            }
            
        }
    }
}
