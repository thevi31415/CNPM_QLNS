using CNPM_QLNS.Admin.TMKyLuat;
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
    public partial class Item_LoaiKyLuat : Form
    {

        public KyLuatNV kyluat;
        public Admin_FormMain formain;
        BL_KyLuat blkl = new BL_KyLuat();
        public Item_LoaiKyLuat(KyLuatNV kyluat, Admin_FormMain formMain)
        {
            InitializeComponent();
            this.kyluat = kyluat;
            this.formain = formMain;
            lblMaKL.Text = kyluat.MaKL;
            lblTenKL.Text = kyluat.LoaiKL;
            lblGiaTriKyLuat.Text = kyluat.TienPhat.ToString();
        }

        private void Item_LoaiKyLuat_Load(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Admin_FormChinhSuaKyLuat cskt = new Admin_FormChinhSuaKyLuat(formain, kyluat);
            cskt.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa kỷ luật này ông?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {


                if (blkl.XoaKyLuat(kyluat.MaKL))
                {
                    formain.LoadFormKyLuat();
                    this.Close();
                    MessageBox.Show("Xóa  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                MessageBox.Show("Hủy xóa kỷ luật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Item_LoaiKyLuat_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Item_LoaiKyLuat_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }
    }
}
