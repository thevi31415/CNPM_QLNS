using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_QLNS.Class
{
	public class DuAn
	{
		private string maDa;
		private string tenDa;
		private string giaTri;
		private DateTime ngayBatDau;
		private string trangThai;

		public string MaDa { get => maDa; set => maDa = value; }
		public string TenDa { get => tenDa; set => tenDa = value; }
		public string GiaTri { get => giaTri; set => giaTri = value; }
		public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
		public string TrangThai { get => trangThai; set => trangThai = value; }
	}
}
