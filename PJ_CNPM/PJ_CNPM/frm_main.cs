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

namespace PJ_CNPM.View
{
    public partial class frm_main : Form
    {
        CTR ctr = new CTR();

        string id_gv,ho_ten,chuc_vu;// khai  báo biến global để dùng
        public frm_main(string idgv, string hoten, string chucvu)// các đối số được truyền từ bên form login qua, là biến local
        {
            InitializeComponent();
            id_gv = idgv;// truyền id_gv từ bên form login vào biến id_gv của form main để thao tác
            ho_ten = hoten;

            chuc_vu = chucvu;

            lbl_hello.Text = "Chào Bạn " + hoten;
            switch(chuc_vu)// kiểm tra chức vụ là gì để phân quyền 
            {
                case "Hiệu Trưởng":// nếu là hiệu trưởng thì được cấp đầy đủ chức năng của hệ thống

                    break;
                case "Giáo Viên":// nếu là giáo viên thì không được quản lý khối, cũng như thêm bớt nhân sự

                    break;
                case "Giáo Vụ":// nếu là giáo vụ thì không được thêm bớt nhân sự

                    break;
            }    
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menu_quanly_khoi_Click(object sender, EventArgs e)
        {
            frm_KhoiLop f = new frm_KhoiLop();
            f.TopLevel = false;
            panel1.Controls.Add(f);// hiển thị form Khối Lớp vào panel ở Form Main
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();

        }

        private void menu_hethong_dangxuat_Click(object sender, EventArgs e)// dang xuat he thong ve frm_login
        {
            frm_login f = new frm_login();
            this.Hide();
            f.Show();
            
            
        }

        private void menu_hethong_doimatkhau_Click(object sender, EventArgs e)
        {
            
            frm_DoiMatKhau f = new frm_DoiMatKhau(id_gv);
            f.TopLevel = false;
            panel1.Controls.Add(f);// hiển thị form Đổi MK vào panel ở Form Main
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            
            
        }
    }
}
