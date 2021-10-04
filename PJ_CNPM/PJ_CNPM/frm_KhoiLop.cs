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
    public partial class frm_KhoiLop : Form
    {
        CTR ctr = new CTR();
        public frm_KhoiLop()
        {
            InitializeComponent();
            LoadSV();
            LoadLop();
        }
        private void LoadSV()
        {
            dataGridView1.DataSource = ctr.LayDataTable("GV");
            
        }
        private void LoadLop()
        {
            cbo_malop.DisplayMember = "Mã Lớp";
            cbo_malop.DataSource = ctr.LayDataTable("LOP");


        }

        private void frm_KhoiLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
