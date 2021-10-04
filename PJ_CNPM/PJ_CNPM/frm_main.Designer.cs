
namespace PJ_CNPM.View
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hethong_doimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hethong_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanly_giaovien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quanly_khoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_baocao_lop = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_baocao_hocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_hethong,
            this.menu_quanly,
            this.menu_baocao,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_hethong
            // 
            this.menu_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_hethong_doimatkhau,
            this.menu_hethong_dangxuat});
            this.menu_hethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_hethong.Image = global::PJ_CNPM.Properties.Resources.start;
            this.menu_hethong.Name = "menu_hethong";
            this.menu_hethong.Size = new System.Drawing.Size(96, 20);
            this.menu_hethong.Text = "Hệ Thống";
            // 
            // menu_hethong_doimatkhau
            // 
            this.menu_hethong_doimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_hethong_doimatkhau.Image = global::PJ_CNPM.Properties.Resources.doimatkhau;
            this.menu_hethong_doimatkhau.Name = "menu_hethong_doimatkhau";
            this.menu_hethong_doimatkhau.Size = new System.Drawing.Size(154, 22);
            this.menu_hethong_doimatkhau.Text = "Đổi Mật Khẩu";
            this.menu_hethong_doimatkhau.Click += new System.EventHandler(this.menu_hethong_doimatkhau_Click);
            // 
            // menu_hethong_dangxuat
            // 
            this.menu_hethong_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_hethong_dangxuat.Image = global::PJ_CNPM.Properties.Resources.thoat;
            this.menu_hethong_dangxuat.Name = "menu_hethong_dangxuat";
            this.menu_hethong_dangxuat.Size = new System.Drawing.Size(154, 22);
            this.menu_hethong_dangxuat.Text = "Đăng Xuất";
            this.menu_hethong_dangxuat.Click += new System.EventHandler(this.menu_hethong_dangxuat_Click);
            // 
            // menu_quanly
            // 
            this.menu_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_quanly_giaovien,
            this.menu_quanly_khoi});
            this.menu_quanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_quanly.Image = global::PJ_CNPM.Properties.Resources.quanlynguoidung;
            this.menu_quanly.Name = "menu_quanly";
            this.menu_quanly.Size = new System.Drawing.Size(85, 20);
            this.menu_quanly.Text = "Quản Lý";
            // 
            // menu_quanly_giaovien
            // 
            this.menu_quanly_giaovien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_quanly_giaovien.Image = global::PJ_CNPM.Properties.Resources.giaovien;
            this.menu_quanly_giaovien.Name = "menu_quanly_giaovien";
            this.menu_quanly_giaovien.Size = new System.Drawing.Size(148, 22);
            this.menu_quanly_giaovien.Text = "Giáo Viên";
            // 
            // menu_quanly_khoi
            // 
            this.menu_quanly_khoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_quanly_khoi.Image = global::PJ_CNPM.Properties.Resources.khoilop;
            this.menu_quanly_khoi.Name = "menu_quanly_khoi";
            this.menu_quanly_khoi.Size = new System.Drawing.Size(148, 22);
            this.menu_quanly_khoi.Text = "Khối Và Lớp";
            this.menu_quanly_khoi.Click += new System.EventHandler(this.menu_quanly_khoi_Click);
            // 
            // menu_baocao
            // 
            this.menu_baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_baocao_lop,
            this.menu_baocao_hocsinh});
            this.menu_baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_baocao.Image = global::PJ_CNPM.Properties.Resources.ketqua;
            this.menu_baocao.Name = "menu_baocao";
            this.menu_baocao.Size = new System.Drawing.Size(89, 20);
            this.menu_baocao.Text = "Báo Cáo";
            // 
            // menu_baocao_lop
            // 
            this.menu_baocao_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_baocao_lop.Image = global::PJ_CNPM.Properties.Resources.xemdiem;
            this.menu_baocao_lop.Name = "menu_baocao_lop";
            this.menu_baocao_lop.Size = new System.Drawing.Size(236, 22);
            this.menu_baocao_lop.Text = "Kết Quả Học Tập Lớp";
            // 
            // menu_baocao_hocsinh
            // 
            this.menu_baocao_hocsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_baocao_hocsinh.Image = global::PJ_CNPM.Properties.Resources.xemdiem;
            this.menu_baocao_hocsinh.Name = "menu_baocao_hocsinh";
            this.menu_baocao_hocsinh.Size = new System.Drawing.Size(236, 22);
            this.menu_baocao_hocsinh.Text = "Kết Quả Học Tập Học Sinh";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_thongtin});
            this.hỗTrợToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hỗTrợToolStripMenuItem.Image = global::PJ_CNPM.Properties.Resources.thongtinphanmem;
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // menu_thongtin
            // 
            this.menu_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_thongtin.Image = global::PJ_CNPM.Properties.Resources.qdsiso;
            this.menu_thongtin.Name = "menu_thongtin";
            this.menu_thongtin.Size = new System.Drawing.Size(175, 22);
            this.menu_thongtin.Text = "Về Chương Trình";
            // 
            // lbl_hello
            // 
            this.lbl_hello.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.Location = new System.Drawing.Point(357, 4);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(294, 18);
            this.lbl_hello.TabIndex = 2;
            this.lbl_hello.Text = "lbl_hello";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 343);
            this.panel1.TabIndex = 3;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(758, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Quản Lý Học Sinh THPT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_hethong;
        private System.Windows.Forms.ToolStripMenuItem menu_hethong_doimatkhau;
        private System.Windows.Forms.ToolStripMenuItem menu_hethong_dangxuat;
        private System.Windows.Forms.ToolStripMenuItem menu_quanly;
        private System.Windows.Forms.ToolStripMenuItem menu_quanly_giaovien;
        private System.Windows.Forms.ToolStripMenuItem menu_quanly_khoi;
        private System.Windows.Forms.ToolStripMenuItem menu_baocao;
        private System.Windows.Forms.ToolStripMenuItem menu_baocao_lop;
        private System.Windows.Forms.ToolStripMenuItem menu_baocao_hocsinh;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_thongtin;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Panel panel1;
    }
}