using CNPM_QLNS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.BS_Layer
{
    public class BL_DangNhap
    {
        DBMain db = null;
        public BL_DangNhap()
        {
            db = new DBMain();
        }

    }
}
