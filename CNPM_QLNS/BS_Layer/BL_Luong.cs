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
     class BL_Luong
    {
        DBMain db = null;
        public BL_Luong()
        {
            db = new DBMain();
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
