using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_CNPM.Model
{
    class Database
    {
        DataProvider pr = new DataProvider();

        public Database()
        {
            pr.Connect();
        }
        public void Disconnect()
        {
            pr.Disconnect();
        }

        public bool Login(string username,string password)// lấy thông tin đăng nhập
        {
            return pr.Login("sp_login", username, password);
        }
        public string PhanQuyen(string id_gv)// lấy chức vụ giáo viên
        {
            return pr.PhanQuyen("sp_phanquyen", id_gv);
        }
        public string LayTenGV(string id_gv)// lấy tên giáo viên
        {
            return pr.LayTenGV("sp_phanquyen",id_gv);
        }

        public int DoiMatKhau(string id_gv,string password)// đổi mật khẩu
        {
            return pr.DoiMatKhau("sp_DoiPass", id_gv, password);
        }

        public DataTable LayDataTable(string tenbang)
        {
            return pr.LayDataTable("sp_load", tenbang);
        }
    }
}
