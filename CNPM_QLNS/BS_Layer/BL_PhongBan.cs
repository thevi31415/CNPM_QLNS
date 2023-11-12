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
    public class BL_PhongBan
    {
        DBMain db = null;
        
        public BL_PhongBan()
        {
            db = new DBMain();
        }
        public bool ThemPhongBan(string maPB, string tenPhongBan, string maTrPhong, string diaDiem, string moTa)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaPB", maPB),
        new SqlParameter("@TenPhongBan", tenPhongBan),
        new SqlParameter("@MaTrPhong", maTrPhong),
        new SqlParameter("@DiaDiem", diaDiem),
        new SqlParameter("@MoTa", moTa)
            };

            string strSQL = "INSERT INTO PHONGBAN (MaPB, TenPhongBan, MaTrPhong, DiaDiem, MoTa) " +
                            "VALUES (@MaPB, @TenPhongBan, @MaTrPhong, @DiaDiem, @MoTa)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public bool CapNhatPhongBan(string maPB, string tenPhongBan, string diaDiem, string moTa, string maTrPhong)
        {
            DBMain db = new DBMain();
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaPB", maPB),
        new SqlParameter("@TenPhongBan", tenPhongBan),
        new SqlParameter("@DiaDiem", diaDiem),
        new SqlParameter("@MoTa", moTa),
        new SqlParameter("@MaTrPhong", maTrPhong)
            };

            string strSQL = "UPDATE PHONGBAN SET TenPhongBan=@TenPhongBan, DiaDiem=@DiaDiem, MoTa=@MoTa, MaTrPhong=@MaTrPhong WHERE MaPB=@MaPB";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public int LaySoLuongNhanVienMoiPhongBan(string maPB)
        {
          
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPB", SqlDbType.NVarChar, 10);
            parameters[0].Value = maPB;

            string strSQL = "SELECT COUNT(*) FROM dbo.NHANVIEN WHERE MaPB = @MaPB";

            DataSet ds = db.ExecuteQueryDataSet(strSQL, CommandType.Text, parameters);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                return count;
            }

            return -1; // Trả về -1 nếu có lỗi hoặc không tìm thấy bản ghi nào.
        }
        public List<PhongBan> LayDanhSachPhongBanTheoMaPB(string maPB)
        {
            List<PhongBan> danhSachPhongBan = new List<PhongBan>();

            string query = "SELECT * FROM PHONGBAN WHERE MaPB = @MaPB";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaPB", maPB)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhongBan phongBan = new PhongBan
                    {
                        MaPB = row["MaPB"].ToString(),
                        TenPhongBan = row["TenPhongBan"].ToString(),
                        MaTrPhong = row["MaTrPhong"].ToString(),
                        DiaDiem = row["DiaDiem"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachPhongBan.Add(phongBan);
                }
            }

            return danhSachPhongBan;
        }
        public List<PhongBan> LayDanhSachPhongBanTheoTenPB(string tenPB)
        {
            List<PhongBan> danhSachPhongBan = new List<PhongBan>();

            string query = "SELECT * FROM PHONGBAN WHERE TenPhongBan = @TenPB";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenPB", tenPB)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhongBan phongBan = new PhongBan
                    {
                        MaPB = row["MaPB"].ToString(),
                        TenPhongBan = row["TenPhongBan"].ToString(),
                        MaTrPhong = row["MaTrPhong"].ToString(),
                        DiaDiem = row["DiaDiem"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachPhongBan.Add(phongBan);
                }
            }

            return danhSachPhongBan;
        }
        public List<PhongBan> LayPhongBan()
        {
            List<PhongBan> danhSachPhongBan = new List<PhongBan>();

            string query = "SELECT * FROM PHONGBAN";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhongBan phongBan = new PhongBan
                    {
                        MaPB = row["MaPB"].ToString(),
                        TenPhongBan = row["TenPhongBan"].ToString().Trim(),
                        MaTrPhong = row["MaTrPhong"].ToString(), // Kiểm tra xem cần phải ánh xạ MaTrPhong sang đối tượng Nhân Viên (NhanVien) hay không
                        DiaDiem = row["DiaDiem"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachPhongBan.Add(phongBan);
                }
            }

            return danhSachPhongBan;
        }
        public bool SetNullMaPBMotNhanVien(string maNV)
        {
            string error = "";
            DBMain db = new DBMain();

            
                // Bước 1: Đặt MaPB là NULL trong bảng NHANVIEN
                string updateNhanVienQuery = "UPDATE NHANVIEN SET MaPB = NULL WHERE MaNV = @MaNV";
                SqlParameter[] updateNhanVienParameters = new SqlParameter[1];
                updateNhanVienParameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
                updateNhanVienParameters[0].Value = maNV;

                // Thực hiện cập nhật MaPB trong bảng NHANVIEN
                bool updateResult = db.MyExecuteNonQuery(updateNhanVienQuery, CommandType.Text, ref error, updateNhanVienParameters);
                return updateResult;
            
          
        }

        public bool SetNullMaPBNhanVien(string maPB)
        {
           
            string error = "";
            DBMain db = new DBMain();
            if (this.LaySoLuongNhanVienMoiPhongBan(maPB) >= 0)
            {
                // Bước 1: Đặt MaTrPhong là NULL trong bảng NHANVIEN
                string updateNhanVienQuery = "UPDATE NHANVIEN SET MaPB = NULL WHERE MaPB = @MaPB";
                SqlParameter[] updateNhanVienParameters = new SqlParameter[1];
                updateNhanVienParameters[0] = new SqlParameter("@MaPB", SqlDbType.NVarChar, 10);
                updateNhanVienParameters[0].Value = maPB;

                // Thực hiện cập nhật MaPB trong bảng NHANVIEN
                bool updateResult = db.MyExecuteNonQuery(updateNhanVienQuery, CommandType.Text, ref error, updateNhanVienParameters);
                
                
                
                return (updateResult);
            }
            else
            {
                return false ;
            }
         
        }
        public bool XoaPhongBan(string maPB)
        {

            string error = "";
            /*  string error = "";

              // Bước 2: Đặt MaTrPhong là NULL trong bảng PHONGBAN
              string updatePhongBanQuery = "UPDATE PHONGBAN SET MaTrPhong = NULL WHERE MaPB = @MaPB";
              SqlParameter[] updatePhongBanParameters = new SqlParameter[1];
              updatePhongBanParameters[0] = new SqlParameter("@MaPB", SqlDbType.NVarChar, 10);
              updatePhongBanParameters[0].Value = maPB;

              // Thực hiện cập nhật MaTrPhong trong bảng PHONGBAN
              bool updatePhongBanResult = db.MyExecuteNonQuery(updatePhongBanQuery, CommandType.Text, ref error, updatePhongBanParameters);

              if (!updatePhongBanResult)
              {
                  // Nếu có lỗi khi cập nhật MaTrPhong trong bảng PHONGBAN, không thực hiện xóa phòng ban
                  return false;
              }
              return true;*/

            // Bước 3: Xóa phòng ban
            DBMain db = new DBMain();
            string deleteQuery = "DELETE FROM PHONGBAN WHERE MaPB = @MaPB";
            SqlParameter[] deleteParameters = new SqlParameter[1];
            deleteParameters[0] = new SqlParameter("@MaPB", SqlDbType.NVarChar, 10);
            deleteParameters[0].Value = maPB;

            // Thực hiện xóa phòng ban
            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, deleteParameters);

        }
        public List<NhanVien> LayNhanVienTheoMaPB(string mapb)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            string query = "SELECT * FROM NHANVIEN WHERE MaPB = @MaPB";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaPB", mapb)
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

            return nhanViens;
        }
        public bool CapNhatMaPBNhanVien(string maNV, string maPB)
        {
            string error = "";
            DBMain db = new DBMain();

            // Tạo câu truy vấn cập nhật MaPB cho nhân viên dựa trên MaNV
            string updateQuery = "UPDATE NHANVIEN SET MaPB = @MaPB WHERE MaNV = @MaNV";

            // Tạo tham số đầu vào
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;
            parameters[1] = new SqlParameter("@MaPB", SqlDbType.NVarChar, 10);
            parameters[1].Value = maPB;

            // Thực hiện cập nhật MaPB cho nhân viên
            return db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, parameters);
        }


    }
}
