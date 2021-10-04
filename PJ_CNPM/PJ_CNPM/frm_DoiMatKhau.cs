using PJ_CNPM.View;
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

namespace PJ_CNPM
{
    public partial class frm_DoiMatKhau : Form
    {
        CTR ctr = new CTR();
        public frm_DoiMatKhau(string id_gv)
        {
            InitializeComponent();
            txt_username.Text = id_gv;
            txt_newpass.UseSystemPasswordChar = true;
            txt_oldpass.UseSystemPasswordChar = true;
            txt_xacnhan.UseSystemPasswordChar = true;
        }

        private void frm_DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)// trở về frm_main
        {
            this.Hide();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_oldpass.TextLength==0||txt_newpass.TextLength == 0 || txt_xacnhan.TextLength == 0)
                    MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            else {
                if (txt_newpass.Text != txt_xacnhan.Text)
                {   
                    MessageBox.Show("Mật Khẩu Mới Không Khớp", "Thông Báo", MessageBoxButtons.OK);
                    txt_xacnhan.Focus();
                }
                else
                   if (ctr.DoiMatKhau(txt_username.Text, txt_newpass.Text) > 0)
                    {    
                        MessageBox.Show("Đổi Mật Khẩu Thành Công","Thông Báo", MessageBoxButtons.OK);
                        this.Hide();
                    }
            }
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                txt_newpass.UseSystemPasswordChar = false;
            else
                txt_newpass.UseSystemPasswordChar = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                txt_oldpass.UseSystemPasswordChar = false;
            else
                txt_oldpass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txt_xacnhan.UseSystemPasswordChar = false;
            else
                txt_xacnhan.UseSystemPasswordChar = true;
        }
    }
}
