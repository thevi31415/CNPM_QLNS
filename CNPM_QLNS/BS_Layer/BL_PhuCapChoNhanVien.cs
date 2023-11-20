using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_PhuCapChoNhanVien
    {
        DBMain db = null;
        public BL_PhuCapChoNhanVien()
        {
            db = new DBMain();
        }
        public List<PhuCapNhanVien> LayDanhSachTatCaPhuCapNhanVien()
        {
            List<PhuCapNhanVien> danhSachPhuCapNhanVien = new List<PhuCapNhanVien>();

            string query = "SELECT * FROM PhuCapNhanVien";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhuCapNhanVien phuCapNhanVien = new PhuCapNhanVien
                    {
                        ID = row["ID"].ToString(),
                        MaPC = row["MaPC"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        TenPC = row["TenPC"].ToString().Trim(),
                        SoQD = row["SoQD"].ToString()
                    };

                    danhSachPhuCapNhanVien.Add(phuCapNhanVien);
                }
            }

            return danhSachPhuCapNhanVien;
        }
        public bool ThemPhuCapNhanVien(string id, string maPC, string maNV, string tenPC, string soQD)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@ID", id),
        new SqlParameter("@MaPC", maPC),
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@TenPC", tenPC),
        new SqlParameter("@SoQD", soQD)
            };

            string strSQL = "INSERT INTO PhuCapNhanVien (ID, MaPC, MaNV, TenPC, SoQD) " +
                            "VALUES (@ID, @MaPC, @MaNV, @TenPC, @SoQD)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public bool XoaPhuCapNhanVien(string id)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@ID", id)
            };

            string strSQL = "DELETE FROM PhuCapNhanVien WHERE ID = @ID";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }


    }
}
