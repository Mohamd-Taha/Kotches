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
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            if (groupBox2.Enabled == true)
            {


                groupBox2.Enabled = false;



               
                btn_save.Visible = false;
                groupBox2.Height = 177;
                groupBox1.Height = 177;
                
            }
            else
            {
                groupBox2.Enabled = true;

                groupBox2.Height = 246;
                groupBox1.Height = 246;
                btn_save.Visible = true ;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }
    }
}
