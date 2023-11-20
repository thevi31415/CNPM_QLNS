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

namespace CNPM_QLNS.Employees.NV_Luong
{
    public partial class NhanVien_FormTinhLuong : Form
    {
        public NhanVien_FormMain formMain;
        public NhanVien nv;
        public List<Luong> luongListTheoThangNam;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhuCap blphucap = new BL_PhuCap();
        BL_KyLuat blkyluat = new BL_KyLuat();
        BL_ChucVu blchucvu = new BL_ChucVu();
        BL_Luong blluong = new BL_Luong();
        public NhanVien_FormTinhLuong(NhanVien nhanVien, NhanVien_FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.nv = nhanVien;
            this.txtMaNV.Enabled = false;
            this.txtMaLuong.Enabled = false;
            this.txtSoNgayCong.Enabled = false;
            this.txtPhuCap.Enabled = false;
            this.txtKyLuat.Enabled = false;       
        }

        private void NhanVien_FormTinhLuong_Load(object sender, EventArgs e)
        {
            this.txtMaNV.Text = this.nv.MaNV;
            this.luongListTheoThangNam = blluong.LayLuong1NVTheoThangNam(this.nv.MaNV, this.dtpNgayTinhLuong.Value.Month, this.dtpNgayTinhLuong.Value.Year);
            if (this.luongListTheoThangNam.Count > 0)
            {
                this.txtMaLuong.Text = this.luongListTheoThangNam[0].MaLuong;
                this.txtSoNgayCong.Text = this.luongListTheoThangNam[0].NgayCong.ToString();
                this.txtPhuCap.Text = this.luongListTheoThangNam[0].PhuCap.ToString();
                this.txtKyLuat.Text = this.luongListTheoThangNam[0].KyLuat.ToString();
            }
            else
            {
                MessageBox.Show("Không thể tính lương");
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
           /* int luongcoban = 0;
            int songaycong = 0;
            int phucap = 0;
            int kyluat = 0;
            List<ChucVu> chucvu = this.blchucvu.LayDanhSachChucVuTheoMaCV(this.luongListTheoThangNam[0].MaCV);
            if (chucvu.Count > 0)
            {
                luongcoban = chucvu[0].LuongCoBan;
            }
            songaycong = luongListTheoThangNam[0].NgayCong;
            List<PhuCap> pc = this.blphucap.LayThongTinPhuCapTheoMaPC(this.luongListTheoThangNam[0].PhuCap);
            if (pc.Count > 0)
            {
                phucap = pc[0].GiaTriPC;
            }
            List<KyLuat> kl = this.blkyluat.LayDanhSachKyLuatTheoMaKL(this.luongListTheoThangNam[0].KyLuat);
            if (kl.Count > 0)
            {
                kyluat = kl[0].TienPhat;
            }
            float tongluong = blluong.TinhLuong(luongcoban, songaycong, phucap, kyluat);

            if (blluong.ThemThongTinLuong(this.nv.MaNV, txtMaLuong.Text.Trim(), this.luongListTheoThangNam[0].MaCV, dtpNgayTinhLuong.Value.Month
                    , dtpNgayTinhLuong.Value.Year, songaycong, this.luongListTheoThangNam[0].PhuCap, this.luongListTheoThangNam[0].KyLuat, txtMoTa.Text, tongluong))
            {
                MessageBox.Show("Tính lương thành công!\n", tongluong.ToString());
            }
            else
            {
                MessageBox.Show("Không thể tính !");
            }*/
        }
    }
}
