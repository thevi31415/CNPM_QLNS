using CNPM_QLNS.Class;
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
    class BL_ChucVu
    {
        DBMain db = null;
        public BL_ChucVu()
        {
            db = new DBMain();
        }
        public List<ChucVuNV> LayDanhSachChucVuTheoMaCV(string maCV)
        {
            List<ChucVuNV> danhSachChucVu = new List<ChucVuNV>();

            string query = "SELECT * FROM CHUCVU WHERE MaCV = @MaCV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@MaCV", maCV)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    ChucVuNV chucVu = new ChucVuNV
                    {
                        MaCV = row["MaCV"].ToString(),
                        TenCV = row["TenCV"].ToString(),
                        LuongCoBan = Convert.ToInt32(row["LuongCoBan"]),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachChucVu.Add(chucVu);
                }
            }

            return danhSachChucVu;
        }
        public List<ChucVuNV> LayDanhSachChucVuTheoTenCV(string tenCV)
        {
            List<ChucVuNV> danhSachChucVu = new List<ChucVuNV>();

            string query = "SELECT * FROM CHUCVU WHERE TenCV = @TenCV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@TenCV", tenCV)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    ChucVuNV chucVu = new ChucVuNV
                    {
                        MaCV = row["MaCV"].ToString(),
                        TenCV = row["TenCV"].ToString(),
                        LuongCoBan = Convert.ToInt32(row["LuongCoBan"]),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachChucVu.Add(chucVu);
                }
            }

            return danhSachChucVu;
        }
        public List<ChucVuNV> LayDanhSachTatCaChucVu()
        {
            List<ChucVuNV> danhSachChucVu = new List<ChucVuNV>();

            string query = "SELECT * FROM CHUCVU";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    ChucVuNV chucVu = new ChucVuNV
                    {
                        MaCV = row["MaCV"].ToString(),
                        TenCV = row["TenCV"].ToString().Trim(),
                        LuongCoBan = Convert.ToInt32(row["LuongCoBan"]),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachChucVu.Add(chucVu);
                }
            }

            return danhSachChucVu;
        }
        public bool CapNhatMaCVThanhNull(string maCV)
        {
            DBMain db = new DBMain();
            string updateQuery = "UPDATE NHANVIEN SET MaCV = NULL WHERE MaCV = @MaCV";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaCV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maCV;

            bool check = db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, parameters);

         //   MessageBox.Show(error);

            return check;

        }
        public bool CapNhatMaCVThanhNullLuong(string maCV)
        {
            DBMain db = new DBMain();
            string updateQuery = "UPDATE LUONG SET MaCV = NULL WHERE MaCV = @MaCV";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaCV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maCV;

            bool check = db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error, parameters);

            //   MessageBox.Show(error);

            return check;

        }
        public bool ThemChucVu(string maCV, string tenCV, int luongCoBan, string moTa)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
                new SqlParameter("@MaCV", maCV),
                new SqlParameter("@TenCV", tenCV),
                new SqlParameter("@LuongCoBan", luongCoBan),
                new SqlParameter("@MoTa", moTa)
            };

            string strSQL = "INSERT INTO CHUCVU (MaCV, TenCV, LuongCoBan, MoTa) " +
                            "VALUES (@MaCV, @TenCV, @LuongCoBan, @MoTa)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }


        public bool XoaChucVu(string maCV)
        {
            DBMain db = new DBMain();
            string deleteQuery = "DELETE FROM CHUCVU WHERE MaCV = @MaCV";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaCV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maCV;

            bool check = db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
            if (check == false)
            {
                MessageBox.Show(error);
            }
            return check;
        }

    }
}
