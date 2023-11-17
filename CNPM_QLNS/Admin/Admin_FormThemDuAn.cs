using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS.Admin
{
	public partial class Admin_FormThemDuAn : Form
	{
		DataTable dtDuAn = null;
		string err;
		BL_DuAn dbDa = new BL_DuAn();
		public Admin_FormMain formmain;
		public Admin_FormThemDuAn(Admin_FormMain formmain)
		{
			InitializeComponent();
			this.formmain = formmain;	
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				BL_DuAn blDa = new BL_DuAn();
				DuAn da = new DuAn();
				da.MaDa = txtMaDuAn.Text.ToString();
				da.TenDa = txtTenDuAn.Text.ToString();
				da.GiaTri = txtGiaTri.Text.ToString();
				da.NgayBatDau = dpNgayBatDau.Value;
				da.TrangThai = txtTrangThai.Text.ToString();

				blDa.ThemDuAn(da);

				txtMaDuAn.ResetText();
				txtTenDuAn.ResetText();
				txtGiaTri.ResetText();
				txtTrangThai.ResetText();
				MessageBox.Show("Da them thanh cong");
				formmain.LoadFormDuAn();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show( "Loi khong them duoc: ", ex.Message);
			}
		}
	}
}
