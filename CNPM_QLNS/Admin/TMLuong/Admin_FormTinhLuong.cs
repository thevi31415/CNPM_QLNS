﻿using CNPM_QLNS.BS_Layer;
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
        List<PhuCapNV> phuCaplist = new List<PhuCapNV>();
        List<NhanVien> NhanVienList = new List<NhanVien>(); 
        List <KyLuatNV> KyLuatList = new List<KyLuatNV>();
        public Admin_FormTinhLuong(Admin_FormMain formain)
        {
            InitializeComponent();
            dtpNgayTinhLuong.Format = DateTimePickerFormat.Custom;
            dtpNgayTinhLuong.CustomFormat = "MM/yyyy";
            dtpNgayTinhLuong.Value = DateTime.Now;
            dtpNgayTinhLuong.Enabled = false;
            this.formMain = formain;
            cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
           

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

                
                int songaycong = Convert.ToInt32(txtSoNgayCong.Text);
                int kyluat = 0;
                int phucap = 0;
              
                NhanVien nv = new NhanVien();
                nv = blnv.LayDanhSachNhanVienTheoMaNV(MaNV)[0];
                if(nv.MaCV == "")
                {
                    MessageBox.Show("Nhân viên chưa có chức vụ nên không thể tính lương !");
                }





                int tongluong = blluong.TinhLuong(luongcoban, songaycong, phucap, kyluat);

                /*if(blluong.ThemThongTinLuong(MaNV, txtMaLuong.Text.Trim(), motnhanvien[0].MaCV, dtpNgayTinhLuong.Value.Month
                    , dtpNgayTinhLuong.Value.Year,songaycong, MaPC, MaKL, txtMoTa.Text, tongluong))
                {
                    MessageBox.Show("Tính lương thành công !");
                    formMain.LoadFormLuong();
                }
                else
                {
                    MessageBox.Show("Không thể tính !");
                }
             //   MessageBox.Show(tongluong.ToString());*/

            }
            
        }
    }
}
