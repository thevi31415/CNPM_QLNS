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

    }
}
