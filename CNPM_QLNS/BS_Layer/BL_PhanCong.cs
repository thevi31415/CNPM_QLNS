using CNPM_QLNS.DB_Layer;
using CNPM_QLNS.Class;
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
    public class BL_PhanCong
    {
        DBMain db = null;
        public BL_PhanCong()
        {
            db = new DBMain();
        }
        public bool XoaPhanCongTheoMaNVMaDa(string maNV, string maDA)
        {
            string deleteQuery = "DELETE FROM PHANCONG WHERE MaNV = @MaNV AND MaDA = @MaDA";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;

            parameters[1] = new SqlParameter("@MaDA", SqlDbType.NVarChar, 10);
            parameters[1].Value = maDA;

            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }
        public bool XoaPhanCongThemMaDA(string maDA)
        {
            DBMain db = new DBMain();
            string deleteQuery = "DELETE FROM PHANCONG WHERE MaDA = @MaDA";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaDA", SqlDbType.NVarChar, 10);
            parameters[0].Value = maDA;
            bool success = db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
            if (!success)
            {
                MessageBox.Show("Xóa dự án không thành công. Lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
         //   return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }
        public bool XoaPhanCong(string maNV)
        {
            string deleteQuery = "DELETE FROM PHANCONG WHERE MaNV = @MaNV";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;

            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }
        public List<PhanCong> LayPhanCongTheoMaDA(string maDA)
        {
            List<PhanCong> phanCongs = new List<PhanCong>();

            string query = "SELECT * FROM PHANCONG WHERE MaDA = @MaDA";
            SqlParameter[] parameters = {
                      new SqlParameter("@MaDA", SqlDbType.NVarChar) { Value = maDA }
           };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhanCong pc = new PhanCong
                    {
                        MaNV = row["MaNV"].ToString(),
                        MaDA = row["MaDA"].ToString(),
                        ThoiGian = Convert.ToInt32(row["ThoiGian"])
                    };

                    phanCongs.Add(pc);
                }
            }

            return phanCongs;
        }

        public bool ThemPhanCong(string maNV, string maDA, int thoiGian)
        {
            string error = "";

            SqlParameter[] parameterValuesPhanCong = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@MaDA", maDA),
        new SqlParameter("@ThoiGian", thoiGian)
            };

            string strSQLPhanCong = "INSERT INTO PHANCONG (MaNV, MaDA, ThoiGian) " +
                                    "VALUES (@MaNV, @MaDA, @ThoiGian)";

            return db.MyExecuteNonQuery(strSQLPhanCong, CommandType.Text, ref error, parameterValuesPhanCong);
        }



    }
}
