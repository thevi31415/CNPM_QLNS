using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        BL_PhanCong blpc = new BL_PhanCong();
        BL_DuAn blda = new BL_DuAn();
        public int check;
        public Item_DuAn(DuAn da, Admin_FormMain formnmain, int check)
        {
            InitializeComponent();
            this.da = da;
            this.formmain = formnmain;
            this.check = check;
            lblMaDA.Text = da.MaDA.Trim();
            lblTenDA.Text = da.TenDA.Trim();
            lblGiaTri.Text= da.GiaTri.ToString();
            lblSLNV.Text = blpc.LayPhanCongTheoMaDA(da.MaDA.Trim()).Count().ToString();
            if(da.TrangThai == 0)
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
                btnTrangThai.Text = "Chưa thực hiện";
            }
            if(da.TrangThai == 1)
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#F9C70D");
                btnTrangThai.Text = "Đang thực hiện";
            }


            if (da.TrangThai == 2)
            {
                btnTrangThai.BackColor = ColorTranslator.FromHtml("#20D374");
                btnTrangThai.Text = "Đã hoàn thành";
            }
            if(check == 0)
            {
                btnXoa.Visible = false;
                btnThaiDoiTrangThai.Visible = false;
            }
          //  lblSLNV.Text = blpc.LayPhanCongTheoMaDA(da.MaDA.Trim()).Count().ToString();
        }

        private void Item_DuAn_Load(object sender, EventArgs e)
        {
           /// formmain.LoadFormDuAn();
        }

        private void Item_DuAn_MouseClick(object sender, MouseEventArgs e)
        {
            if(check !=0)
            {
                Admin_FormXemChiTietDuAn ctda = new Admin_FormXemChiTietDuAn(this.da, this.formmain);
                ctda.ShowDialog();
            }
         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi dự án  không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {


                if(blpc.XoaPhanCongThemMaDA(da.MaDA) && blda.XoaDuAn(da.MaDA))
                {
                    formmain.LoadFormDuAn();
                    this.Close();
                    MessageBox.Show("Xóa  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
              

            }
            else
            {
                MessageBox.Show("Hủy xóa phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThaiDoiTrangThai_Click(object sender, EventArgs e)
        {
            Admin_FormThayDoiTrangThaiDA td = new Admin_FormThayDoiTrangThaiDA(da, formmain);
            td.ShowDialog();
        }

        private void Item_DuAn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_DuAn_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
