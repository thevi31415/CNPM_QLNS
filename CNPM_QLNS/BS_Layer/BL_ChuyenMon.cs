using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM_QLNS.DB_Layer;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_ChuyenMon
    {


        DBMain db = null;
        public BL_ChuyenMon()
        {
            db = new DBMain();
        }
        public List<ChuyenMon> LayDanhSachCHUYENMONTheoMaCM(string maCM)
        {
            List<ChuyenMon> danhSachCHUYENMON = new List<ChuyenMon>();

            string query = "SELECT * FROM CHUYENMON WHERE MaCM = @MaCM";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaCM", maCM)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    ChuyenMon chuyenMon = new ChuyenMon
                    {
                        MaCM = row["MaCM"].ToString(),
                        TenCM = row["TenCM"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachCHUYENMON.Add(chuyenMon);
                }
            }

            return danhSachCHUYENMON;
        }

    }
}
