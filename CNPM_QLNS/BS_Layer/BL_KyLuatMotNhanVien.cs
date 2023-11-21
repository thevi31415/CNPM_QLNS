using CNPM_QLNS.DB_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_KyLuatMotNhanVien
    {
        DBMain db = null;
        
        public BL_KyLuatMotNhanVien()
        {
            db = new DBMain();
        }
        public List<KyLuatChoNhanVien> LayDanhSachTatCaKyLuatNhanVien()
        {
            List<KyLuatChoNhanVien> danhSachKyLuatNhanVien = new List<KyLuatChoNhanVien>();

            string query = "SELECT * FROM KyLuatNhanVien";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    KyLuatChoNhanVien kyLuatNhanVien = new KyLuatChoNhanVien
                    {
                        ID = row["ID"].ToString(),
                        MaKL = row["MaKL"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        TenKL = row["TenKL"].ToString().Trim(),
                        SoQD = row["SoQD"].ToString()
                    };

                    danhSachKyLuatNhanVien.Add(kyLuatNhanVien);
                }
            }

            return danhSachKyLuatNhanVien;
        }
        public bool ThemKyLuatChoNhanVien(string id, string maKL, string maNV, string tenKL, string soQD)
        {
            DBMain db = new DBMain();
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@ID", id),
        new SqlParameter("@MaKL", maKL),
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@TenKL", tenKL),
        new SqlParameter("@SoQD", soQD)
            };

            string strSQL = "INSERT INTO KyLuatNhanVien (ID, MaKL, MaNV, TenKL, SoQD) " +
                            "VALUES (@ID, @MaKL, @MaNV, @TenKL, @SoQD)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public bool XoaKyLuatNhanVien(string id)
        {
            DBMain db = new DBMain();
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@ID", id),
            };

            string strSQL = "DELETE FROM KyLuatNhanVien WHERE ID = @ID";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

    }
}
