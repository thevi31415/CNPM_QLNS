using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Admin
{
	public partial class Admin_ChiTietDuAn : Form
	{
		DuAn da;
		PhanCong pc;
		BL_PhanCong blPc = new BL_PhanCong();
		BL_DuAn blDa = new BL_DuAn();
		string err;

		public Admin_ChiTietDuAn()
		{
			InitializeComponent();
			loadMaCT();
			loadMaDA();
			loadMaDACapNhat();
		}

		private void btnThemNhanVien_Click(object sender, EventArgs e)
		{
			try
			{
				BL_PhanCong blPc = new BL_PhanCong();
				PhanCong pc = new PhanCong();
				pc.MaNV = cboNhanVien.Text.Trim();
				pc.MaDA = cboMaDA.Text.Trim();
				pc.ThoiGian = "3";

				blPc.ThemNhanVienVaoDuAn(pc);
				MessageBox.Show("Da them");

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		public void loadMaCT()
		{
			DataTable dataTable = new DataTable();
			BL_DuAn bLDa = new BL_DuAn();
			dataTable = blDa.layMaNV();

			foreach (DataRow dr in dataTable.Rows)
			{
				cboNhanVien.Items.Add(dr["MaNV"].ToString());
			}
		}
		public void loadMaDA()
		{
			DataTable dataTable = new DataTable();
			BL_DuAn bLDa = new BL_DuAn();
			dataTable = blDa.layMaDA();

			foreach (DataRow dr in dataTable.Rows)
			{
				cboMaDA.Items.Add(dr["MaDA"].ToString());
			}
		}
		public void loadMaDACapNhat()
		{
			DataTable dataTable = new DataTable();
			BL_DuAn bLDa = new BL_DuAn();
			dataTable = blDa.layMaDA();

			foreach (DataRow dr in dataTable.Rows)
			{
				cboMaDA_CapNhat.Items.Add(dr["MaDA"].ToString());
			}
		}
		private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
		{
			try
			{
				BL_DuAn blDa = new BL_DuAn();
				DuAn da = new DuAn();
				da.MaDa = cboMaDA_CapNhat.Text.Trim();
				da.TrangThai=txtCapNhatTrangThai.Text.ToString();

				blDa.CapNhatTrangThaiDuAn(da);
				MessageBox.Show("cap nhat thanh cong");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
