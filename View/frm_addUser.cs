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
    public partial class frm_AddUser : Form
    {
        BusinessImp.EmployeeBaoImp Bao = new BusinessImp.EmployeeBaoImp();

        public frm_AddUser()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Bao.addEmployee(txt_user_fullname.Text, txt_user_name.Text, txt_user_password.Text, cmobo_accessiblity.SelectedItem.ToString());
            MessageBox.Show("تم اضافة المستخدم");
        }
    }
}
