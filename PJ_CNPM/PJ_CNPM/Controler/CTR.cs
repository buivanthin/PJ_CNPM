using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ_CNPM.Model;
using System.Data;

namespace PJ_CNPM.Controler
{
    class CTR
    {
        Database db;
        public CTR()
        {
            db = new Database();
        }
        public void Disconnect()
        {
            db.Disconnect();
        }
        public bool Login(string username,string password)// lấy thông tin đăng nhập
        {
            return db.Login(username, password);
        }
        public string PhanQuyen(string id_gv)// lay chuc vu giao vien
        {
            return db.PhanQuyen(id_gv);
        }

        public string LayTenGV(string id_gv)// lấy tên giáo viên
        {
            return db.LayTenGV(id_gv);
        }

        public int DoiMatKhau(string id_gv,string password)// đổi mật khẩu
        {
            return db.DoiMatKhau(id_gv, password);
        }

        internal bool Login(string text1, object text2)
        {
            throw new NotImplementedException();
        }
        public DataTable LayDataTable(string tenbang)
        {
            return db.LayDataTable(tenbang);
        }
    }
}
