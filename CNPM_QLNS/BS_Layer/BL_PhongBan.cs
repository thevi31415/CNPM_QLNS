using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM_QLNS.Class;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_PhongBan
    {
        DBMain db = null;
        public BL_PhongBan()
        {
            db = new DBMain();
        }

        public List<PhongBan> LayDanhSachPhongBanTheoMaPB(string maPB)
        {
            List<PhongBan> danhSachPhongBan = new List<PhongBan>();

            string query = "SELECT * FROM PHONGBAN WHERE MaPB = @MaPB";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaPB", maPB)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    PhongBan phongBan = new PhongBan
                    {
                        MaPB = row["MaPB"].ToString(),
                        TenPhongBan = row["TenPhongBan"].ToString(),
                        MaTrPhong = row["MaTrPhong"].ToString(),
                        DiaDiem = row["DiaDiem"].ToString(),
                        MoTa = row["MoTa"].ToString()
                    };

                    danhSachPhongBan.Add(phongBan);
                }
            }

            return danhSachPhongBan;
        }
    
}
}
