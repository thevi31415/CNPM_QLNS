using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using OfficeOpenXml.LoadFunctions.Params;
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
    public partial class Item_NhanVienDuAn : Form
    {
        public NhanVien nv;
        public DuAn da;
        public Admin_FormMain formain;
        public Admin_FormXemChiTietDuAn ctda;
        BL_PhanCong blpc = new BL_PhanCong();
        List<PhanCong> pclist = new List<PhanCong>();
        BL_NhanVien bvlnv = new BL_NhanVien();
        List<NhanVien> nvthamgialist = new List<NhanVien>();
        public Item_NhanVienDuAn(DuAn da, NhanVien nv, Admin_FormMain formnmain, Admin_FormXemChiTietDuAn ctda)
        {
            InitializeComponent();
            this.nv = nv;
            this.da = da;
            this.formain = formnmain;
            this.ctda = ctda;
               
            lblMaNV.Text = nv.MaNV;
            lblHoTen.Text = nv.HoTen;
            lblGioiTinh.Text = nv.GioiTinh;
            lblNgaySinh.Text = nv.NgaySinh.ToString("dd/MM/yyyy");
            lblTrangThai.Text = nv.TrangThai;
      
            if (lblTrangThai.Text == "Đang làm việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#0FD99B");
            }
            if (lblTrangThai.Text == "Đã nghỉ việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
            }
            if (lblTrangThai.Text == "Nghỉ việc tạm thời")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#EC9E0C");

            }

        }
      
        private void Item_NhanVienDuAn_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi dự án  không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {

                blpc.XoaPhanCongTheoMaNVMaDa(nv.MaNV.Trim(), da.MaDA.Trim());
                pclist = blpc.LayPhanCongTheoMaDA(da.MaDA.Trim());
                foreach (var phanCong in pclist)
                {
                    NhanVien nv = new NhanVien();
                    nv = bvlnv.LayNhanVienTheoMa(phanCong.MaNV);
                    nvthamgialist.Add(nv);
                }
                ctda.LoadData(nvthamgialist);
                formain.LoadFormDuAn();
                MessageBox.Show("Xóa  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Hủy xóa phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Item_NhanVienDuAn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_NhanVienDuAn_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
