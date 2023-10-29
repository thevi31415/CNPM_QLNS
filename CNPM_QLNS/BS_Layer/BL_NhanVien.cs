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
     public class BL_NhanVien
    {
        DBMain db = null;
        public BL_NhanVien()
        {
            db = new DBMain();
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
                            TrangThai = row["TrangThai"].ToString(),
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
            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }
    }
}
