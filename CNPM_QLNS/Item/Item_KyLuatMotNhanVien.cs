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
    public partial class Item_KyLuatMotNhanVien : Form
    {
        public Admin_FormMain formain;
        public KyLuatChoNhanVien klmotnv;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_KyLuat blkl = new BL_KyLuat();
        KyLuatNV kl = new KyLuatNV();
        BL_KyLuatMotNhanVien blklmotnv = new BL_KyLuatMotNhanVien();
       
        public Item_KyLuatMotNhanVien(Admin_FormMain formMain, KyLuatChoNhanVien klmotnv)
        {
            InitializeComponent();
            this.formain = formMain;
            this.klmotnv = klmotnv;
            kl = blkl.LayDanhSachKyLuatTheoMaKL(klmotnv.MaKL)[0];
            lblID.Text = klmotnv.ID;
            lblMaNV.Text = klmotnv.MaNV;
            lblHoTen.Text = blnv.LayDanhSachNhanVienTheoMaNV(klmotnv.MaNV)[0].HoTen;
            lblTenKL.Text = kl.LoaiKL;
            lblSoTien.Text = kl.TienPhat.ToString();
            lblSoQD.Text = klmotnv.SoQD;
            if (formain == null)
            {
                btnXoa.Visible = false;
            }


        }

        private void Item_KyLuatMotNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi dự án  không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {


                if (blklmotnv.XoaKyLuatNhanVien(klmotnv.ID))
                {
                    formain.LoadFormKyLuat();
                    this.Close();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                MessageBox.Show("Hủy xóa phụ cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Item_KyLuatMotNhanVien_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_KyLuatMotNhanVien_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
