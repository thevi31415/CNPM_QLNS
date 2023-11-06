using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_TaiKhoan
    {
        DBMain db = null;
        public BL_TaiKhoan()
        {
            db = new DBMain();
        }
        public List<TaiKhoan> LayTaiKhoanTheoEmailMatKhau(string email, string matKhau)
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();

            string query = "SELECT * FROM TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email),
                new SqlParameter("@MatKhau", matKhau)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        MaNV = row["MaNV"].ToString(),
                        Email = row["Email"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        PhanQuyen = row["PhanQuyen"].ToString(),
                        TrangThai = row["TrangThai"].ToString(),
                        TruyCap = row["TruyCap"] != DBNull.Value ? (DateTime)row["TruyCap"] : (DateTime?)null
                    };

                    danhSachTaiKhoan.Add(taiKhoan);
                }
            }

            return danhSachTaiKhoan;
        }
        public List<TaiKhoan> LayTaiKhoan()
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            string query = "SELECT * FROM TAIKHOAN";
            SqlParameter[] parameters = null;
            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    TaiKhoan tk = new TaiKhoan
                    {
                        MaNV = row["MaNV"].ToString(),
                        Email = row["Email"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        PhanQuyen = row["PhanQuyen"].ToString(),
                        TrangThai = row["TrangThai"].ToString(),
                        TruyCap = Convert.ToDateTime(row["TruyCap"])
                    };

                    taiKhoans.Add(tk);
                }
            }
            return taiKhoans;
        }
        public bool CapNhatTaiKhoan(string maNV, string email, string matKhau, string phanQuyen, string trangThai)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@Email", email),
        new SqlParameter("@MatKhau", matKhau),
        new SqlParameter("@PhanQuyen", phanQuyen),
        new SqlParameter("@TrangThai", trangThai)
            };

            string strSQL = "UPDATE TAIKHOAN SET Email=@Email, MatKhau=@MatKhau, PhanQuyen=@PhanQuyen, TrangThai=@TrangThai WHERE MaNV=@MaNV";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool SetTruyCapThoiGianHienTai(string maNV)
        {
            string error = "";
            DBMain db = new DBMain();

            // Bước 1: Cập nhật cột TruyCap trong bảng TAIKHOAN thành thời gian hiện tại
            string updateTruyCapQuery = "UPDATE TAIKHOAN SET TruyCap = GETDATE() WHERE MaNV = @MaNV";
            SqlParameter[] updateTruyCapParameters = new SqlParameter[1];
            updateTruyCapParameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            updateTruyCapParameters[0].Value = maNV;

            // Thực hiện cập nhật cột TruyCap trong bảng TAIKHOAN
            bool updateResult = db.MyExecuteNonQuery(updateTruyCapQuery, CommandType.Text, ref error, updateTruyCapParameters);
            return updateResult;
        }
        public bool XoaTaiKhoan(string maNV)
        {
            string deleteQuery = "DELETE FROM TAIKHOAN WHERE MaNV = @MaNV";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;

            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }


    }
}
