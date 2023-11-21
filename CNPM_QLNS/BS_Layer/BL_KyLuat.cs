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
    class BL_KyLuat
    {
        DBMain db = null;
        public BL_KyLuat()
        {
            db = new DBMain();
        }
        public List<KyLuatNV> LayDanhSachTatCaKyLuat()
        {
            List<KyLuatNV> danhSachKyLuat = new List<KyLuatNV>();

            string query = "SELECT * FROM KyLuat"; // Đảm bảo bảng trong cơ sở dữ liệu có tên là KyLuat

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, null); // Giả sử db là đối tượng thực hiện kết nối và thao tác với cơ sở dữ liệu

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    KyLuatNV kyLuat = new KyLuatNV
                    {
                        MaKL = row["MaKL"].ToString(),
                        LoaiKL = row["LoaiKL"].ToString().Trim(),
                        TienPhat = Convert.ToInt32(row["TienPhat"])
                    };

                    danhSachKyLuat.Add(kyLuat);
                }
            }

            return danhSachKyLuat;
        }
        public List<KyLuatNV> LayDanhSachKyLuatTheoMaKL(string maKL)
        {
            List<KyLuatNV> danhSachKyLuat = new List<KyLuatNV>();

            string query = "SELECT * FROM KyLuat WHERE MaKL = @MaKL";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaKL", maKL)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    KyLuatNV kyLuat = new KyLuatNV
                    {
                        MaKL = row["MaKL"].ToString(),
                        LoaiKL = row["LoaiKL"].ToString(),
                        TienPhat = Convert.ToInt32(row["TienPhat"])
                    };

                    danhSachKyLuat.Add(kyLuat);
                }
            }

            return danhSachKyLuat;
        }

    }

}
