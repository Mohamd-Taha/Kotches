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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text == "frist" && txt_password.Text == "123")
            {
                frm_Config _Config = new frm_Config();
                _Config.ShowDialog();

            }
            else {
                
                Home _home = new Home();
                Program.user_name = txt_user_name.Text;
                this.Hide();
                _home.ShowDialog();
                this.Close();


            }

        }
    }
}
