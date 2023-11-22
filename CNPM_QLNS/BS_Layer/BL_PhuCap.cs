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
     class BL_PhuCap
    {
        DBMain db = null;
        public BL_PhuCap()
        {
            db = new DBMain();
        }
        public bool CapNhatPhuCap(string maPC, string loaiPC, int giaTriPC)
        {
            DBMain db = new DBMain();
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaPC", maPC),
        new SqlParameter("@LoaiPC", loaiPC),
        new SqlParameter("@GiaTriPC", giaTriPC)
            };

            string strSQL = "UPDATE PHUCAP SET LoaiPC=@LoaiPC, GiaTriPC=@GiaTriPC WHERE MaPC=@MaPC";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public bool ThemPhuCap(string maPC, string loaiPC, int giaTriPC)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaPC", maPC),
        new SqlParameter("@LoaiPC", loaiPC),
        new SqlParameter("@GiaTriPC", giaTriPC)
            };

            string strSQL = "INSERT INTO PHUCAP (MaPC, LoaiPC, GiaTriPC) " +
                            "VALUES (@MaPC, @LoaiPC, @GiaTriPC)";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

        public List<PhuCapNV> LayDanhSachTatCaPhuCap()
        {
            List<PhuCapNV> danhSachPhuCap = new List<PhuCapNV>();

            string query = "SELECT * FROM PHUCAP";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhuCapNV phuCap = new PhuCapNV
                    {
                        MaPC = row["MaPC"].ToString(),
                        LoaiPC = row["LoaiPC"].ToString().Trim(),
                        GiaTriPC = Convert.ToInt32(row["GiaTriPC"])
                    };

                    danhSachPhuCap.Add(phuCap);
                }
            }

            return danhSachPhuCap;
        }
        public List<PhuCapNV> LayThongTinPhuCapTheoMaPC(string maPC)
        {
            List<PhuCapNV> danhSachPhuCap = new List<PhuCapNV>();

            string query = "SELECT * FROM PHUCAP WHERE MaPC = @MaPC";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaPC", maPC)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhuCapNV phuCap = new PhuCapNV
                    {
                        MaPC = row["MaPC"].ToString(),
                        LoaiPC = row["LoaiPC"].ToString(),
                        GiaTriPC = Convert.ToInt32(row["GiaTriPC"])
                    };

                    danhSachPhuCap.Add(phuCap);
                }
            }

            return danhSachPhuCap;
        }
        public bool XoaPhuCap(string maPC)
        {
            string error = "";

            SqlParameter[] parameterValues = new SqlParameter[]
            {
        new SqlParameter("@MaPC", maPC)
            };

            string strSQL = "DELETE FROM PHUCAP WHERE MaPC = @MaPC";

            return db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error, parameterValues);
        }

    }
}
