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
    public class BL_TrinhDo
    {


        DBMain db = null;
        public BL_TrinhDo()
        {
            db = new DBMain();
        }

        public List<TrinhDo> LayDanhSachTrinhDoTheoMaTD(string maTD)
        {
            List<TrinhDo> danhSachTrinhDo = new List<TrinhDo>();

            string query = "SELECT * FROM TRINHDO WHERE MaTD = @MaTD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@MaTD", maTD)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    TrinhDo trinhDo = new TrinhDo
                    {
                        MaTD = row["MaTD"].ToString(),
                        TenTD = row["TenTD"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachTrinhDo.Add(trinhDo);
                }
            }

            return danhSachTrinhDo;
        }
        public List<TrinhDo> LayDanhSachTrinhDoTheoTenTD(string tenTD)
        {
            List<TrinhDo> danhSachTrinhDo = new List<TrinhDo>();

            string query = "SELECT * FROM TRINHDO WHERE TenTD = @TenTD";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@TenTD", tenTD)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    TrinhDo trinhDo = new TrinhDo
                    {
                        MaTD = row["MaTD"].ToString(),
                        TenTD = row["TenTD"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachTrinhDo.Add(trinhDo);
                }
            }

            return danhSachTrinhDo;
        }
        public List<TrinhDo> LayDanhSachTatCaTrinhDo()
        {
            List<TrinhDo> danhSachTrinhDo = new List<TrinhDo>();

            string query = "SELECT * FROM TRINHDO";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    TrinhDo trinhDo = new TrinhDo
                    {
                        MaTD = row["MaTD"].ToString(),
                        TenTD = row["TenTD"].ToString().Trim(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachTrinhDo.Add(trinhDo);
                }
            }

            return danhSachTrinhDo;
        }
    }
}
