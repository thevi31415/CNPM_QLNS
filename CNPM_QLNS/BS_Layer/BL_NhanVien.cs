﻿using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.BS_Layer
{
     public class BL_NhanVien
    {
        DBMain db = null;
        public BL_NhanVien()
        {
            db = new DBMain();
        }
        public List<NhanVien> LayDanhSachNhanVienChuaCoTaiKhoan()
        {
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            string query = "SELECT NV.* " +
                           "FROM NHANVIEN NV " +
                           "LEFT JOIN TAIKHOAN TK ON NV.MaNV = TK.MaNV " +
                           "WHERE TK.MaNV IS NULL";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = row["MaNV"].ToString(),
                        HoTen = row["HoTen"].ToString(),
                        CMND = row["CMND"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        NgaySinh = (DateTime)row["NgaySinh"],
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

                    danhSachNhanVien.Add(nhanVien);
                }
            }

            return danhSachNhanVien;
        }

        public List<NhanVien> LayDanhSachNhanVienTheoMaNV(string maNV)
        {
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            string query = "SELECT * FROM NHANVIEN WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = row["MaNV"].ToString(),
                        HoTen = row["HoTen"].ToString(),
                        CMND = row["CMND"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        NgaySinh = (DateTime)row["NgaySinh"],
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

                    danhSachNhanVien.Add(nhanVien);
                }
            }

            return danhSachNhanVien;
        }

        public List<NhanVien> LayNhanVienChuaThuocPhongBan()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            string query = "SELECT * FROM NHANVIEN WHERE MaPB IS NULL";

            SqlParameter[] parameters = null;
            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNV = row["MaNV"].ToString(),
                        HoTen = row["HoTen"].ToString(),
                        CMND = row["CMND"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                        QueQuan = row["QueQuan"].ToString(),
                        TonGiao = row["TonGiao"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        TrangThai = row["TrangThai"].ToString().Trim(),
                        MaPB = row["MaPB"].ToString(),
                        MaCV = row["MaCV"].ToString(),
                        MaTD = row["MaTD"].ToString(),
                        MaCM = row["MaCM"].ToString(),
                        Hinh = row["Hinh"].ToString()
                    };

                    nhanViens.Add(nv);
                }
            }
            return nhanViens;



        }


        public List<NhanVien> LayNhanVien ()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

                string query = "SELECT * FROM NHANVIEN";
                SqlParameter[] parameters = null;
                DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

                if (result != null && result.Tables.Count > 0)
                {
                    foreach (DataRow row in result.Tables[0].Rows)
                    {
                        NhanVien nv = new NhanVien
                        {
                            MaNV = row["MaNV"].ToString(),
                            HoTen = row["HoTen"].ToString(),
                            CMND = row["CMND"].ToString(),
                            GioiTinh = row["GioiTinh"].ToString(),
                            NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                            QueQuan = row["QueQuan"].ToString(),
                            TonGiao = row["TonGiao"].ToString(),
                            DiaChi = row["DiaChi"].ToString(),
                            TrangThai = row["TrangThai"].ToString().Trim(),
                            MaPB = row["MaPB"].ToString(),
                            MaCV = row["MaCV"].ToString(),
                            MaTD = row["MaTD"].ToString(),
                            MaCM = row["MaCM"].ToString(),
                            Hinh = row["Hinh"].ToString()
                        };

                        nhanViens.Add(nv);
                    }
                }
              nhanViens.Reverse();
              return nhanViens;
            

      
        }
        public List<NhanVien> LayNhanVienKhongThamGiaDuAn(string maDuAn)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            // Sửa truy vấn để lấy những nhân viên không tham gia dự án
            string query = "SELECT * FROM NHANVIEN WHERE MaNV NOT IN (SELECT MaNV FROM PHANCONG WHERE MaDA = @MaDA)";
            SqlParameter[] parameters = {
        new SqlParameter("@MaDA", maDuAn)
    };
            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNV = row["MaNV"].ToString(),
                        HoTen = row["HoTen"].ToString(),
                        CMND = row["CMND"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                        QueQuan = row["QueQuan"].ToString(),
                        TonGiao = row["TonGiao"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        TrangThai = row["TrangThai"].ToString().Trim(),
                        MaPB = row["MaPB"].ToString(),
                        MaCV = row["MaCV"].ToString(),
                        MaTD = row["MaTD"].ToString(),
                        MaCM = row["MaCM"].ToString(),
                        Hinh = row["Hinh"].ToString()
                    };

                    nhanViens.Add(nv);
                }
            }
            nhanViens.Reverse();
            return nhanViens;
        }

        public bool ThemNhanVien(string maNV, string hoTen, string cmnd, string gioiTinh, DateTime ngaySinh, string queQuan, string tonGiao, string diaChi, string trangThai, string maPB, string maCV, string maTD, string maCM, string hinh)
        {
            string error = "";
            DBMain db = new DBMain();

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@HoTen", hoTen),
        new SqlParameter("@CMND", cmnd),
        new SqlParameter("@GioiTinh", gioiTinh),
        new SqlParameter("@NgaySinh", ngaySinh),
        new SqlParameter("@QueQuan", queQuan),
        new SqlParameter("@TonGiao", tonGiao),
        new SqlParameter("@DiaChi", diaChi),
        new SqlParameter("@TrangThai", trangThai),
        new SqlParameter("@MaPB", maPB),
        new SqlParameter("@MaCV", maCV),
        new SqlParameter("@MaTD", maTD),
        new SqlParameter("@MaCM", maCM),
        new SqlParameter("@Hinh", hinh)
            };

            string strSQL = "INSERT INTO NHANVIEN (MaNV, HoTen, CMND, GioiTinh, NgaySinh, QueQuan, TonGiao, DiaChi, TrangThai, MaPB, MaCV, MaTD, MaCM, Hinh) " +
                            "VALUES (@MaNV, @HoTen, @CMND, @GioiTinh, @NgaySinh, @QueQuan, @TonGiao, @DiaChi, @TrangThai, @MaPB, @MaCV, @MaTD, @MaCM, @Hinh)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public bool CapNhatNhanVien(string maNV, string hoTenNV, string cmnd, string gioiTinh, DateTime ngaySinh, string queQuan, string tonGiao, string diaChi, string trangThai, string maPB, string maCV, string maTD, string maCM, string hinh)
        {
            string error = "";
            DBMain db = new DBMain();

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@HoTenNV", hoTenNV),
        new SqlParameter("@CMND", cmnd),
        new SqlParameter("@GioiTinh", gioiTinh),
        new SqlParameter("@NgaySinh", ngaySinh),
        new SqlParameter("@QueQuan", queQuan),
        new SqlParameter("@TonGiao", tonGiao),
        new SqlParameter("@DiaChi", diaChi),
        new SqlParameter("@TrangThai", trangThai),
        new SqlParameter("@MaPB", maPB),
        new SqlParameter("@MaCV", maCV),
        new SqlParameter("@MaTD", maTD),
        new SqlParameter("@MaCM", maCM),
        new SqlParameter("@Hinh", hinh)
            };

            string strSQL = "UPDATE NHANVIEN SET HoTen=@HoTenNV, CMND=@CMND, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, QueQuan=@QueQuan, TonGiao=@TonGiao, DiaChi=@DiaChi, TrangThai=@TrangThai, MaPB=@MaPB, MaCV=@MaCV, MaTD=@MaTD, MaCM=@MaCM, Hinh=@Hinh WHERE MaNV=@MaNV";

           bool check = db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
           if(check == false)
            {
                MessageBox.Show(error);
            }
            return check;
        }


        public bool XoaNhanVien(string maNV)
        {
            string error = "";
            DBMain db = new DBMain();

            // Tạo câu truy vấn xóa nhân viên dựa trên MaNV
            string deleteQuery = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";

            // Tạo tham số đầu vào
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;

            // Thực hiện xóa nhân viên
          //  return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
            // Thực hiện xóa nhân viên
            bool success = db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);

            // Hiển thị thông báo nếu có lỗi xảy ra
            if (!success)
            {
                MessageBox.Show("Xóa nhân viên không thành công. Lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }
        public NhanVien LayNhanVienTheoMa(string maNV)
        {
            string query = "SELECT * FROM NHANVIEN WHERE MaNV = @MaNV";
            SqlParameter[] parameters = {
        new SqlParameter("@MaNV", maNV)
    };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                DataRow row = result.Tables[0].Rows[0];
                NhanVien nv = new NhanVien
                {
                    MaNV = row["MaNV"].ToString(),
                    HoTen = row["HoTen"].ToString(),
                    CMND = row["CMND"].ToString(),
                    GioiTinh = row["GioiTinh"].ToString(),
                    NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                    QueQuan = row["QueQuan"].ToString(),
                    TonGiao = row["TonGiao"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    TrangThai = row["TrangThai"].ToString().Trim(),
                    MaPB = row["MaPB"].ToString(),
                    MaCV = row["MaCV"].ToString(),
                    MaTD = row["MaTD"].ToString(),
                    MaCM = row["MaCM"].ToString(),
                    Hinh = row["Hinh"].ToString()
                };

                return nv;
            }

            return null; // Trả về null nếu không tìm thấy nhân viên với Mã nhân viên tương ứng.
        }

    }
}
