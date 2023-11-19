using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.BS_Layer
{
     public class BL_DuAn
    {
        DBMain db = null;

        public BL_DuAn()
        {
            db = new DBMain();
        }

        public List<DuAn> LayDuAn()
        {
            List<DuAn> danhSachDuAn = new List<DuAn>();

            string query = "SELECT * FROM DUAN";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    DuAn duAn = new DuAn
                    {
                        MaDA = row["MaDA"].ToString(),
                        TenDA = row["TenDA"].ToString().Trim(),
                        GiaTri = Convert.ToInt32(row["GiaTri"]),
                        NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]),
                        MoTa = row["MoTa"].ToString(),
                        TrangThai = Convert.ToInt32(row["TrangThai"])
                    };

                    danhSachDuAn.Add(duAn);
                }
            }

            return danhSachDuAn;
        }
        public bool XoaDuAn(string maDA)
        {
            string error = "";
            DBMain db = new DBMain();

            // Tạo câu truy vấn xóa dự án dựa trên MaDA
            string deleteQuery = "DELETE FROM DUAN WHERE MaDA = @MaDA";

            // Tạo tham số đầu vào
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaDA", SqlDbType.NVarChar, 10);
            parameters[0].Value = maDA;

            // Thực hiện xóa dự án
            bool success = db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);

            // Hiển thị thông báo nếu có lỗi xảy ra
            if (!success)
            {
                MessageBox.Show("Xóa dự án không thành công. Lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }

        public List<DuAn> LayDuAnTheoTrangThai(int trangThai)
        {
            List<DuAn> danhSachDuAn = new List<DuAn>();

            string query = "SELECT * FROM DUAN WHERE TrangThai = @TrangThai";
            SqlParameter[] parameters = {
        new SqlParameter("@TrangThai", SqlDbType.Int) { Value = trangThai }
         };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    DuAn duAn = new DuAn
                    {
                        MaDA = row["MaDA"].ToString(),
                        TenDA = row["TenDA"].ToString().Trim(),
                        GiaTri = Convert.ToInt32(row["GiaTri"]),
                        NgayBatDau = Convert.ToDateTime(row["NgayBatDau"]),
                        NgayKetThuc = Convert.ToDateTime(row["NgayKetThuc"]),
                        MoTa = row["MoTa"].ToString(),
                        TrangThai = Convert.ToInt32(row["TrangThai"])
                    };

                    danhSachDuAn.Add(duAn);
                }
            }

            return danhSachDuAn;
        }
       public bool ThemDuAn(string maDA, string tenDA, int giaTri, DateTime ngayBatDau, DateTime ngayKetThuc, string moTa, int trangThai)
         {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaDA", maDA),
                new SqlParameter("@TenDA", tenDA),
                new SqlParameter("@GiaTri", giaTri),
                new SqlParameter("@NgayBatDau", ngayBatDau),
                new SqlParameter("@NgayKetThuc", ngayKetThuc),
                new SqlParameter("@MoTa", moTa),
                new SqlParameter("@TrangThai", trangThai)
            };

            string strSQL = "INSERT INTO DUAN (MaDA, TenDA, GiaTri, NgayBatDau, NgayKetThuc, MoTa, TrangThai) " +
                            "VALUES (@MaDA, @TenDA, @GiaTri, @NgayBatDau, @NgayKetThuc, @MoTa, @TrangThai)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }
        public bool CapNhatTrangThaiDuAn(string maDA, int trangThaiMoi)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaDA", maDA),
        new SqlParameter("@TrangThaiMoi", trangThaiMoi)
            };

            string strSQL = "UPDATE DUAN SET TrangThai = @TrangThaiMoi WHERE MaDA = @MaDA";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }


    }
}
