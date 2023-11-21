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

namespace CNPM_QLNS.Item
{
    public partial class Item_ChucVu : Form
    {
        public ChucVuNV cv;
        public Admin_FormMain FormMain;
        BL_ChucVu blcv = new BL_ChucVu();
        public Item_ChucVu(ChucVuNV cv, Admin_FormMain formMain)
        {
            InitializeComponent();
            this.cv = cv;
            this.FormMain = formMain;
            lblMaCV.Text = cv.MaCV.ToString();
            lblTenCV.Text = cv.TenCV.ToString();
            lblLuongCoBan.Text = cv.LuongCoBan.ToString();
            lblMoTa.Text = cv.MoTa.ToString();

        }

        private void Item_ChucVu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi dự án  không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {


                if (blcv.CapNhatMaCVThanhNull(cv.MaCV) && blcv.CapNhatMaCVThanhNullLuong(cv.MaCV) && blcv.XoaChucVu(cv.MaCV) )
                {

                    FormMain.LoadFormChucVu();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không thể xóa ");
                }


            }
            else
            {
                MessageBox.Show("Hủy xóa phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }
    }
}
