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
    public partial class Admin_FormXemChiTietDuAn : Form
    {
        public DuAn da;
        Admin_FormMain formMain;
        List<PhanCong> pclist = new List<PhanCong>();
        BL_PhanCong blpc = new BL_PhanCong();
        BL_NhanVien bvlnv = new BL_NhanVien();
        List<NhanVien> nvthamgialist = new List<NhanVien>();
        public Admin_FormXemChiTietDuAn(DuAn da, Admin_FormMain formmain)
        {
            InitializeComponent();
            this.da = da;
            this.formMain = formmain;
            lblMaDA.Text = da.MaDA.Trim();
            lblTenDA.Text = da.TenDA.Trim();
            lblGiaTri.Text = da.GiaTri.ToString();
            lblMoTa.Text = da.MoTa.Trim();
            pclist = blpc.LayPhanCongTheoMaDA(da.MaDA.Trim());
            lblNgayBatDau.Text = da.NgayBatDau.ToString();
            lblNgayKetThuc.Text = da.NgayKetThuc.ToString();
            if(da.TrangThai == 0)
            {
                lblTrangThai.Text = "Chưa khỏi công";
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
            }
            if(da.TrangThai == 1)
            {
                lblTrangThai.Text = "Đang thực hiện";
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#F9C70D");
            }
            if (da.TrangThai == 2)
            {
                lblTrangThai.Text = "Đã hoàn thành";
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#20D374");
            }

            foreach (var phanCong in pclist)
            {
                NhanVien nv = new NhanVien();
                nv = bvlnv.LayNhanVienTheoMa(phanCong.MaNV);
                nvthamgialist.Add(nv);
            }
            LoadData(nvthamgialist);
            //   lblNgayKetThuc
        }
        public void LoadData(List<NhanVien> nvList)
        {

           panellistNhanVienDuAn.Controls.Clear();
          //  this.nhanVienList = blpb.LayNhanVienTheoMaPB(pb.MaPB);
            //  nvList = nv.LayNhanVien();
            panellistNhanVienDuAn.Padding = new Padding(10, 0, 10, 0); ;
            if (nvList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (NhanVien nhanVien in nvList)
                {
                   Item_NhanVienDuAn item_nhanvien = new Item_NhanVienDuAn(da, nhanVien, formMain, this); // Pass the reference
                    item_nhanvien.TopLevel = false;
                    panellistNhanVienDuAn.Controls.Add(item_nhanvien);
                    item_nhanvien.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }

        private void Admin_FormXemChiTietDuAn_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Admin_FormPhanCongDuAn pc = new Admin_FormPhanCongDuAn(da, this);
            pc.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
