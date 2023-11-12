using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<PhuCap> LayDanhSachTatCaPhuCap()
        {
            List<PhuCap> danhSachPhuCap = new List<PhuCap>();

            string query = "SELECT * FROM PHUCAP";

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhuCap phuCap = new PhuCap
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

    }
}
