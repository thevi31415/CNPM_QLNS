using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.Class
{
    public class DuAn
    {
        public string MaDA { get; set; }
        public string TenDA { get; set; }

        public int GiaTri { get; set; }
        public DateTime NgayBatDau { get; set; }
        public int TrangThai { get; set; }
    }
}
