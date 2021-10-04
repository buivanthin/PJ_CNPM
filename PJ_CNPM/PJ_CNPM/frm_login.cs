using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJ_CNPM.Controler;
using PJ_CNPM.View;

namespace PJ_CNPM
{
    public partial class frm_login : Form
    {
        CTR ctr = new CTR();
        CTR ctr2 = new CTR();

        public frm_login()
        {
            InitializeComponent();
            txt_password.UseSystemPasswordChar = true;
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ctr.Login(txt_username.Text, txt_password.Text))
            {
                string idgv = txt_username.Text;
                string chucvu = ctr.PhanQuyen(txt_username.Text);// lấy chức vụ để truyền sang form main              
                string hoten = ctr2.LayTenGV(txt_username.Text);//lấy họ tên để truyền sang form main

                frm_main f = new frm_main(idgv, hoten, chucvu);
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txt_password.UseSystemPasswordChar = false;
            else
                txt_password.UseSystemPasswordChar = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Chắc Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
                Application.Exit();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
