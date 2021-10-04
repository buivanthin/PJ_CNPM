using System;

namespace PJ_CNPM.Controler
{
    class info_GV
    {

        private string id_gv;
        private string ho_ten;
        private DateTime nam_sinh;
        private bool gioi_tinh;
        private string sdt;
        private string chuyen_mon;
        private string chuc_vu;
        private string mat_khau;


        public info_GV()
        {
        }


        public info_GV(string id_gv, string ho_ten, DateTime nam_sinh, bool gioi_tinh, string sdt, string chuyen_mon, string chuc_vu, string mat_khau)
        {
            this.id_gv = id_gv;
            this.ho_ten = ho_ten;
            this.nam_sinh = nam_sinh;
            this.gioi_tinh = gioi_tinh;
            this.sdt = sdt;
            this.chuyen_mon = chuyen_mon;
            this.chuc_vu = chuc_vu;
            this.mat_khau = mat_khau;
        }

        public string Id_gv { get => id_gv; set => id_gv = value; }
        public string Ho_ten { get => ho_ten; set => ho_ten = value; }
        public DateTime Nam_sinh { get => nam_sinh; set => nam_sinh = value; }
        public bool Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chuyen_mon { get => chuyen_mon; set => chuyen_mon = value; }
        public string Chuc_vu { get => chuc_vu; set => chuc_vu = value; }
        public string Mat_khau { get => mat_khau; set => mat_khau = value; }


    }
}

