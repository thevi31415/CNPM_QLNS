using CNPM_QLNS.Admin;
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

namespace CNPM_QLNS.Item
{
	public partial class Item_DuAn : Form
	{
		public DuAn da;
		public Admin_FormMain formmain;
		BL_DuAn blDa = new BL_DuAn();
		public Item_DuAn(DuAn da, Admin_FormMain formmain)
		{
			InitializeComponent();
			this.da = da;
			this.formmain = formmain;
		}

		private void btnXoaDuAn_Click(object sender, EventArgs e)
		{
			try
			{
				DuAn da = new DuAn();
				da.MaDa = lblMaDA.Text;
				MessageBox.Show(da.MaDa);
				if (blDa.XoaDuAn(da))
				{
					formmain.LoadFormDuAn();
					MessageBox.Show("da xoa du an");
				}

			}
			catch (SqlException ex) 
			{
				MessageBox.Show("khong xoa duoc, Loi: ", ex.Message);
			}

		}

		private void Item_DuAn_Load(object sender, EventArgs e)
		{
			lblMaDA.Text = this.da.MaDa.ToString();
			lblTenDuAn.Text = this.da.TenDa.ToString();

		}

		private void Item_DuAn_MouseClick(object sender, MouseEventArgs e)
		{
			Admin_ChiTietDuAn fromda = new Admin_ChiTietDuAn();
			fromda.ShowDialog();
		}
	}
}
