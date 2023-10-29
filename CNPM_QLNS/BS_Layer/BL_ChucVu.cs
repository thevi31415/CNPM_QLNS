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
    class BL_ChucVu
    {
        DBMain db = null;
        public BL_ChucVu()
        {
            db = new DBMain();
        }
        public List<ChucVu> LayDanhSachChucVuTheoMaCV(string maCV)
        {
            List<ChucVu> danhSachChucVu = new List<ChucVu>();

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
                    ChucVu chucVu = new ChucVu
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

    }
}
