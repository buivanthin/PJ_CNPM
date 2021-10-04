using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_CNPM.Model
{
    class DataProvider// thao tác trực tiếp xuống database
    {
        public DataProvider() { }

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dap;
        // string connectionString = ConfigurationManager.ConnectionStrings["KN"].ConnectionString.ToString();
        string connectionString = "Data Source=DESKTOP-G1PNFLH\\SQLEXPRESS;Initial Catalog=QL_THPT;Integrated Security=True";

        public bool connect()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void Connect()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Disconnect()
        {
            con.Close();
        }
        public bool Login(string strStore, string username, string password)// dang nhap
        {
            
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username", username);// username trong ngoac la tham so cua stored procedures
            cmd.Parameters.AddWithValue("password", password);// password trong ngoac la tham so cua stored procederes
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            return dt.Rows.Count > 0;

        }
        public string PhanQuyen(string strStore,string id_gv)// lấy ra chức vụ của người đăng nhập
        {
            string chucvu;
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_gv", id_gv);// truyền id giáo viên vào stored proceduces để tìm phân quyền của giáo viên
            SqlDataReader dar = cmd.ExecuteReader();
            if(dar.Read())
            {
                chucvu = (string)dar["chuc_vu"];// lấy ra chức vụ của giáo viên
                return chucvu;// trả về chức vụ của giáo viên
            }
            Disconnect();
            return "";
        }

        public string LayTenGV(string strStore, string id_gv)// lấy ra tên của người đăng nhập
        {
            string hoten;
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_gv", id_gv);// truyền id giáo viên vào stored proceduces để tìm tên của giáo viên
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                hoten = (string)dar["ho_ten"];// lấy ra tên của giáo viên
                return hoten;// trả về tên của giáo viên
            }
            Disconnect();
            return "";
        }

        public int DoiMatKhau(string strStore,string id_gv,string password)//thay đổi mật khẩu
        {
            
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("password", password);// truyền mật khẩu mới vào để đổi
            cmd.Parameters.AddWithValue("username", id_gv);// truyền id giáo viên vào để làm điều kiện đổi pass
               
            int result= cmd.ExecuteNonQuery();
            return result;


        }
        public DataTable LayDataTable(string strStore,string tenbang)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tenbang", tenbang);
            dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
            
        }
    }
}

