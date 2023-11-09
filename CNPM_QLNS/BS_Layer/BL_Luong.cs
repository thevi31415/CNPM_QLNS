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
     class BL_Luong
    {
        DBMain db = null;
        public BL_Luong()
        {
            db = new DBMain();
        }
        public List<Luong> LayLuong()
        {
            List<Luong> luongs = new List<Luong>();

            string query = "SELECT * FROM LUONG";
            SqlParameter[] parameters = null;
            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    Luong luong = new Luong
                    {
                        MaNV = row["MaNV"].ToString(),
                        MaLuong = row["MaLuong"].ToString(),
                        MaCV = row["MaCV"].ToString(),
                        Thang = Convert.ToInt32(row["Thang"]),
                        Nam = Convert.ToInt32(row["Nam"]),
                        NgayCong = Convert.ToInt32(row["NgayCong"]),
                        PhuCap = row["PhuCap"].ToString(),
                        KyLuat = row["KyLuat"].ToString(),
                        TongLuong = Convert.ToDouble(row["TongLuong"])
                
                    };

                    luongs.Add(luong);
                }
            }

            return luongs;
        }
        public List<Luong> LayLuongTheoMaNV(string maNV)
        {
            List<Luong> luongs = new List<Luong>();

            string query = "SELECT * FROM LUONG WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV)
            };

            DataSet result = db.ExecuteQueryDataSet(query, CommandType.Text, parameters);

            if (result != null && result.Tables.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    Luong luong = new Luong
                    {
                        MaNV = row["MaNV"].ToString(),
                        MaLuong = row["MaLuong"].ToString(),
                        MaCV = row["MaCV"].ToString(),
                        Thang = Convert.ToInt32(row["Thang"]),
                        Nam = Convert.ToInt32(row["Nam"]),
                        NgayCong = Convert.ToInt32(row["NgayCong"]),
                        PhuCap = row["PhuCap"].ToString(),
                        KyLuat = row["KyLuat"].ToString(),
                        TongLuong = Convert.ToDouble(row["TongLuong"])
                    };

                    luongs.Add(luong);
                }
            }

            return luongs;
        }

        public bool XoaLuong(string maNV)
        {
            string error = "";
        

            // Tạo câu truy vấn xóa lương dựa trên MaNV
            string deleteQuery = "DELETE FROM LUONG WHERE MaNV = @MaNV";

     
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;

            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }


    }
}
