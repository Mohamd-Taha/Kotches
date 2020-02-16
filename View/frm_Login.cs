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
            else if (txt_user_name.Text == "1" && txt_password.Text == "1")
            {
                Program.user_name = txt_user_name.Text;
                Program.user_password = txt_password.Text;
                Home _home = new Home();
                _home.Lbl_signinDate.Text = dateTimePicker1.Value.ToString();
                _home.lbl_currentUser.Text = Program.user_name;
                this.Hide();
                
                _home.ShowDialog();
                this.Close();


            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
