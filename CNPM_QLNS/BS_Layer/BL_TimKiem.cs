using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM_QLNS.Class;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_TimKiem
    {
        DBMain db = null;
        public BL_TimKiem()
        {
            db = new DBMain();
        }
        public List<TaiKhoan> TimKiemTaiKhoan(string input, string propertyName)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string sql = "SELECT * FROM TAIKHOAN WHERE " + propertyName + " LIKE @input";
            SqlParameter[] parameters = {
        new SqlParameter("@input", "%" + input + "%")
    };

            DataSet dataSet = db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);

            // Kiểm tra xem DataSet có dữ liệu hay không
            if (dataSet.Tables.Count > 0)
            {
                DataTable dataTable = dataSet.Tables[0];

                foreach (DataRow row in dataTable.Rows)
                {
                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        MaNV = row["MaNV"].ToString(),
                        Email = row["Email"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        PhanQuyen = row["PhanQuyen"].ToString(),
                        TrangThai = row["TrangThai"].ToString(),
                        TruyCap = DateTime.Parse(row["TruyCap"].ToString())
                    };

                    taiKhoans.Add(taiKhoan);
                }
            }

            return taiKhoans;
        }

        public List<NhanVien> TimKiemNhanVien(string input, string propertyName)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT * FROM NHANVIEN WHERE " + propertyName + " LIKE @input";
            SqlParameter[] parameters = {
                new SqlParameter("@input", "%" + input + "%")
          };

            DataSet dataSet = db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);

            // Kiểm tra xem DataSet có dữ liệu hay không
            if (dataSet.Tables.Count > 0)
            {
                DataTable dataTable = dataSet.Tables[0];

                foreach (DataRow row in dataTable.Rows)
                {
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = row["MaNV"].ToString(),
                        HoTen = row["HoTen"].ToString(),
                        CMND = row["CMND"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        NgaySinh = DateTime.Parse(row["NgaySinh"].ToString()),
                        QueQuan = row["QueQuan"].ToString(),
                        TonGiao = row["TonGiao"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        TrangThai = row["TrangThai"].ToString(),
                        MaPB = row["MaPB"].ToString(),
                        MaCV = row["MaCV"].ToString(),
                        MaTD = row["MaTD"].ToString(),
                        MaCM = row["MaCM"].ToString(),
                        Hinh = row["Hinh"].ToString()
                    };

                    nhanViens.Add(nhanVien);
                }
            }

            return nhanViens;
        }
    }
}
