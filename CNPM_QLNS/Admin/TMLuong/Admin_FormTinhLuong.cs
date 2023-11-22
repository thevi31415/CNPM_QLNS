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
        public Admin_FormMain formMain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhuCap blphucap = new BL_PhuCap();
        BL_KyLuat blkyluat = new BL_KyLuat();
        BL_ChucVu blchucvu = new BL_ChucVu();
        BL_Luong blluong = new BL_Luong();

        BL_KyLuatMotNhanVien blklmotnv = new BL_KyLuatMotNhanVien();
        List<KyLuatChoNhanVien> listkyluatchonv = new List<KyLuatChoNhanVien>();

        BL_PhuCapChoNhanVien blpcchonv = new BL_PhuCapChoNhanVien();
        List<PhuCapNhanVien> listphucapchonv = new List<PhuCapNhanVien>();




        List<PhuCapNV> phuCaplist = new List<PhuCapNV>();
        List<NhanVien> NhanVienList = new List<NhanVien>(); 
        List <KyLuatNV> KyLuatList = new List<KyLuatNV>();
        int songaycong =0;
        int kyluat = 0;
        int phucap = 0;
        public Admin_FormTinhLuong(Admin_FormMain formain)
        {
            InitializeComponent();
            dtpNgayTinhLuong.Format = DateTimePickerFormat.Custom;
            dtpNgayTinhLuong.CustomFormat = "MM/yyyy";
            dtpNgayTinhLuong.Value = DateTime.Now;
            dtpNgayTinhLuong.Enabled = false;
            this.formMain = formain;
            cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            txtKyLuat.Enabled = false;
            txtPhuCap.Enabled = false;

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
        }

        private void dtpNgayTinhLuong_CloseUp(object sender, EventArgs e)
        {
            dtpNgayTinhLuong.Value = new DateTime(dtpNgayTinhLuong.Value.Year, dtpNgayTinhLuong.Value.Month, 1);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e) {


            List<NhanVien> motnhanvien = new List<NhanVien>();
            List<PhuCapNV> motphucap = new List<PhuCapNV>();
            List<KyLuatNV> motkyluat = new List<KyLuatNV>(); 
            string[] parts = cmbMaNV.Text.Split('-'); // Tách chuỗi dựa trên dấu gạch
            string  MaNV = parts[0].Trim();

          











            motnhanvien = blnv.LayDanhSachNhanVienTheoMaNV(MaNV);
            int luongcoban = 0;
            if (blchucvu.LayDanhSachChucVuTheoMaCV(motnhanvien[0].MaCV).Count > 0)
            {
                luongcoban = blchucvu.LayDanhSachChucVuTheoMaCV(motnhanvien[0].MaCV)[0].LuongCoBan;
            }
          

            if(txtSoNgayCong.Text.Trim()=="" || txtMaLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! Vui lòng nhập lại !");
            }
            else
            {

                
                songaycong = Convert.ToInt32(txtSoNgayCong.Text);
               
              
               NhanVien nv = new NhanVien();
                nv = blnv.LayDanhSachNhanVienTheoMaNV(MaNV)[0];
                if(nv.MaCV == "")
                {
                    MessageBox.Show("Nhân viên chưa có chức vụ nên không thể tính lương !");
                }
                else
                {

                   
                    int tongluong = blluong.TinhLuong(luongcoban, songaycong, phucap, kyluat);


                    if (blluong.ThemThongTinLuong(MaNV, txtMaLuong.Text.Trim(), motnhanvien[0].MaCV, dtpNgayTinhLuong.Value.Month
                   , dtpNgayTinhLuong.Value.Year, songaycong, phucap, kyluat, txtMoTa.Text, tongluong))
                    {
                        MessageBox.Show("Tính lương thành công !");
                        formMain.LoadFormLuong();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể tính !");
                    }
                    //   MessageBox.Show(tongluong.ToString());



                }












            }
            
        }

        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] parts = cmbMaNV.Text.Split('-'); // Tách chuỗi dựa trên dấu gạch
            string MaNV = parts[0].Trim();

          //  MessageBox.Show(MaNV);
            listkyluatchonv = blklmotnv.LayKyLuatTheoMaNV(MaNV.Trim());
          //  MessageBox.Show(listkyluatchonv.Count().ToString());
            if(listkyluatchonv.Count <= 0 ) {
            
                kyluat = 0;

            }
            else
            {
                foreach (KyLuatChoNhanVien kyluatnv in listkyluatchonv)
                {
                    kyluat = kyluat + blkyluat.LayDanhSachKyLuatTheoMaKL(kyluatnv.MaKL)[0].TienPhat;
                }

               

            }
            txtKyLuat.Text = kyluat.ToString();


            listphucapchonv = blpcchonv.LayDanhSachPhuCapNhanVienTheoMaNV(MaNV.Trim());
            if(listphucapchonv.Count <= 0 )
            {
                phucap = 0;
            }
            else
            {
                foreach (PhuCapNhanVien phucapnv in listphucapchonv)
                {
                    phucap = phucap + blphucap.LayThongTinPhuCapTheoMaPC(phucapnv.MaPC.Trim())[0].GiaTriPC;
                }
            }

            txtPhuCap.Text = phucap.ToString();

        }
    }
}
