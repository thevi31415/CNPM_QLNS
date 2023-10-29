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
    public partial class Admin_FormThemNhanVien : Form
    {
        public NhanVien nv;
        public Admin_FormMain formnmain;
        BL_PhongBan blphongban = new BL_PhongBan();
        BL_ChucVu blchucvu = new BL_ChucVu();
        BL_TrinhDo bltrinhdo = new BL_TrinhDo();
        BL_ChuyenMon blchuyenmon = new BL_ChuyenMon();
        BL_NhanVien blnhanvien = new BL_NhanVien();
        List<PhongBan> listphongban = new List<PhongBan>();
        List<ChucVu> listchucvu = new List<ChucVu>();
        List<TrinhDo> listtrinhdo = new List<TrinhDo>();
        List<ChuyenMon> listchuyenmon = new List<ChuyenMon>();
        public Admin_FormThemNhanVien(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formnmain = formMain;
            txtMaNV.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtQueQuan.Text = string.Empty;
            txtTonGiao.Text = string.Empty;
            ricTextDiaChi.Text = string.Empty;
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            cmbTrangThai.Items.Add("Đang làm việc");
            cmbTrangThai.Items.Add("Nghỉ việc tạm thời");
            cmbTrangThai.Items.Add("Đã nghỉ việc");
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
          //  cmbTrangThai.SelectedItem = nv.TrangThai;
            listtrinhdo = bltrinhdo.LayDanhSachTatCaTrinhDo();
            listchuyenmon = blchuyenmon.LayDanhSachTatCaChuyenMon();
            listchucvu = blchucvu.LayDanhSachTatCaChucVu();
            listphongban = blphongban.LayDanhSachTatCaPhongBan();
            foreach (TrinhDo trinhdo in listtrinhdo)
            {
                cmbTrinhDo.Items.Add(trinhdo.TenTD);
            }
            cmbTrinhDo.DropDownStyle = ComboBoxStyle.DropDownList;
          
            foreach (ChuyenMon chuyenmon in listchuyenmon)
            {
                cmbChuyenMon.Items.Add(chuyenmon.TenCM);
            }
            cmbChuyenMon.DropDownStyle = ComboBoxStyle.DropDownList;
           
            foreach (ChucVu chucvu in listchucvu)
            {
                cmbChucVu.Items.Add(chucvu.TenCV);
            }
            cmbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
          



            foreach (PhongBan phongban in listphongban)
            {
                cmbPhongBan.Items.Add(phongban.TenPhongBan);
            }
            cmbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
           




        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text.ToString().Trim(); //Bat buoc
            string HoTen = txtHoTen.Text.ToString(); //Bat buoc
            string CMND = txtCMND.Text.ToString(); //Bat buoc
            string GioiTinh = cmbGioiTinh.Text.ToString(); //Bat buoc
            DateTime NgaySinh = dtpNgaySinh.Value;//Bat buoc
            string QueQuan = txtQueQuan.Text.ToString();//Bat buoc
            string TonGiao = txtTonGiao.Text.ToString();
            string DiaChi = ricTextDiaChi.Text.ToString();//Bat buoc
            string TrangThai = cmbTrangThai.Text.ToString().Trim();//Bat buoc
            string MaPB = null;
            string MaCV = null;
            string MaCM = null;
            string MaTD = null;
            if (MaNV.Trim() == "" || HoTen.Trim() == "" || CMND.Trim() == "" || GioiTinh.Trim() == ""
                || QueQuan.Trim() == "" || DiaChi.Trim() == "" || TrangThai.Trim() == null)

            {


                MessageBox.Show("Bạn chưa nhập đây đủ các thông tin bắt buộc. Vui lòng nhập lại !");

            }
            else
            {
                if (blphongban.LayDanhSachPhongBanTheoTenPB(cmbPhongBan.Text.ToString()).Count > 0)
                {
                    MaPB = blphongban.LayDanhSachPhongBanTheoTenPB(cmbPhongBan.Text.ToString())[0].MaPB.ToString().Trim();
                }
                if (blchucvu.LayDanhSachChucVuTheoTenCV(cmbChucVu.Text.ToString()).Count > 0)
                {
                    MaCV = blchucvu.LayDanhSachChucVuTheoTenCV(cmbChucVu.Text.ToString())[0].MaCV.ToString().Trim();
                }
                if (blchuyenmon.LayDanhSachCHUYENMONTheoTenCM(cmbChuyenMon.Text.ToString()).Count > 0)
                {
                    MaCM = blchuyenmon.LayDanhSachCHUYENMONTheoTenCM(cmbChuyenMon.Text.ToString())[0].MaCM.ToString().Trim();
                }
                if (bltrinhdo.LayDanhSachTrinhDoTheoTenTD(cmbTrinhDo.Text.ToString()).Count > 0)
                {
                    MaTD = bltrinhdo.LayDanhSachTrinhDoTheoTenTD(cmbTrinhDo.Text.ToString())[0].MaTD.ToString().Trim();
                }
                // CapNhatNhanVien(string maNV, string hoTenNV, string cmnd, string gioiTinh, DateTime ngaySinh, string queQuan, string tonGiao, string diaChi, string trangThai, string maPB, string maCV, string maTD, string maCM, string hinh)
                if (blnhanvien.ThemNhanVien(MaNV, HoTen, CMND, GioiTinh, NgaySinh, QueQuan, TonGiao, DiaChi, TrangThai, MaPB, MaCV, MaTD, MaCM, "HHH"))
                {
                    this.Close();

                    formnmain.LoadFormNhanVien();

                    MessageBox.Show("Them thanh cong !");

                }
                else
                {
                    MessageBox.Show("Them that bai");
                }


            }
        }
    }
}
