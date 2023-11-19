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
                        TrangThai = Convert.ToInt32(row["TrangThai"])
                    };

                    danhSachDuAn.Add(duAn);
                }
            }

            return danhSachDuAn;
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
                        TrangThai = Convert.ToInt32(row["TrangThai"])
                    };

                    danhSachDuAn.Add(duAn);
                }
            }

            return danhSachDuAn;
        }

    }
}
