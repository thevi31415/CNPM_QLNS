using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI.Win32;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_PhanCong
    {
        DBMain db = null;
        public BL_PhanCong()
        {
            db = new DBMain();
        }
        public bool XoaPhanCong(string maNV)
        {
            string deleteQuery = "DELETE FROM PHANCONG WHERE MaNV = @MaNV";
            string error = "";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar, 10);
            parameters[0].Value = maNV;

            return db.MyExecuteNonQuery(deleteQuery, CommandType.Text, ref error, parameters);
        }

    }
}
