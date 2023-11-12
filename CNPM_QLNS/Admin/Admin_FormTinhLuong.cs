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
    public partial class Admin_FormTinhLuong : Form
    {
        Admin_FormMain formMain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhuCap blphucap = new BL_PhuCap();
        BL_KyLuat blkyluat = new BL_KyLuat();
        BL_ChucVu blchucvu = new BL_ChucVu();
        List<PhuCap> phuCaplist= new List<PhuCap>();
        List<NhanVien> NhanVienList = new List<NhanVien>(); 
        List <KyLuat> KyLuatList = new List<KyLuat>();
        public Admin_FormTinhLuong(Admin_FormMain formain)
        {
            InitializeComponent();
            dtpNgayTinhLuong.Format = DateTimePickerFormat.Custom;
            dtpNgayTinhLuong.CustomFormat = "MM/yyyy";
            dtpNgayTinhLuong.Value = DateTime.Now;
            dtpNgayTinhLuong.Enabled = false;
            this.formMain = formain;
            cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKyLuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhuCap.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Admin_FormTinhLuong_Load(object sender, EventArgs e)
        {
            NhanVienList = blnv.LayNhanVien();
            phuCaplist = blphucap.LayDanhSachTatCaPhuCap();
            KyLuatList = blkyluat.LayDanhSachTatCaKyLuat();
            foreach (NhanVien nhanVien in NhanVienList)
            {
                cmbMaNV.Items.Add(nhanVien.MaNV + " - " + nhanVien.HoTen);
            }
            foreach (PhuCap phucap in phuCaplist)
            {
                cmbPhuCap.Items.Add(phucap.MaPC + " - " + phucap.LoaiPC);
            }
            foreach (KyLuat kyluat in KyLuatList)
            {
                cmbKyLuat.Items.Add(kyluat.MaKL + " - " + kyluat.LoaiKL);
            }
        }

        private void dtpNgayTinhLuong_CloseUp(object sender, EventArgs e)
        {
            dtpNgayTinhLuong.Value = new DateTime(dtpNgayTinhLuong.Value.Year, dtpNgayTinhLuong.Value.Month, 1);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e) {


            List<NhanVien> motnhanvien = new List<NhanVien>();
            List<PhuCap> motphucap = new List<PhuCap>();
            List<KyLuat> motkyluat = new List<KyLuat>(); 
            string[] parts = cmbMaNV.Text.Split('-'); // Tách chuỗi dựa trên dấu gạch
            string  MaNV = parts[0].Trim();

            string[] pc =cmbPhuCap.Text.Split('-');

            string MaPC = pc[0].Trim();


            string[] kl = cmbKyLuat.Text.Split('-');

            string MaKL = kl[0].Trim();



            motnhanvien = blnv.LayDanhSachNhanVienTheoMaNV(MaNV);

            int luongcoban = blchucvu.LayDanhSachChucVuTheoMaCV(motnhanvien[0].MaCV)[0].LuongCoBan;
          //  int songaycong = txtSoNgayCong
            MessageBox.Show(luongcoban.ToString());
        }
    }
}
