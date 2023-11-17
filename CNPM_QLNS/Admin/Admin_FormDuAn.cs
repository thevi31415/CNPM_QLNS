using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Item;
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
    public partial class Admin_FormDuAn : Form
    {
		public List<DuAn> duAnList = new List<DuAn>();
		public List<DuAn> ketquatimkiemnv = new List<DuAn>();
		BL_DuAn blDa = new BL_DuAn();
		DuAn da = new DuAn();
		DataTable dt = new DataTable();
		BL_TimKiem timKiem = new BL_TimKiem();
		public Admin_FormMain formmain;
		int check = 0;
		public Admin_FormDuAn(Admin_FormMain formmain)
        {
            InitializeComponent();
			this.formmain = formmain;

		}

		public void LoadData(List<DuAn> daList)
		{
			panelListDuAn.Controls.Clear();
			this.duAnList = blDa.LayDuAn();

			if (daList.Count > 0)
			{
				int itemsPerRow = 3; // Số mục trên mỗi hàng
				int itemCount = 0;
				FlowLayoutPanel currentRowPanel = null;

				foreach (DuAn duAn in daList)

				{
					// Tạo một Item mới
					Item_DuAn item_duan = new Item_DuAn(duAn, formmain); // Pass the reference
					item_duan.TopLevel = false;

					// Kiểm tra nếu chúng ta cần tạo một hàng mới
					if (itemCount % itemsPerRow == 0)
					{
						currentRowPanel = new FlowLayoutPanel();
						currentRowPanel.FlowDirection = FlowDirection.LeftToRight;
						currentRowPanel.WrapContents = false;
						currentRowPanel.AutoSize = true;
						panelListDuAn.Controls.Add(currentRowPanel);
					}

					// Thêm mục vào hàng hiện tại
					currentRowPanel.Controls.Add(item_duan);
					item_duan.Show();

					itemCount++;
				}
			}
			else
			{
				MessageBox.Show("Không tìm thấy dự án nào");
			}
		}

		private void btnThemDuAn_Click(object sender, EventArgs e)
		{
			Admin_FormThemDuAn frmthemda = new Admin_FormThemDuAn(formmain);
			frmthemda.ShowDialog();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelListDuAn_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Admin_FormDuAn_Load(object sender, EventArgs e)
		{
			this.duAnList = blDa.LayDuAn();
			LoadData(duAnList);
		}
	}
}
