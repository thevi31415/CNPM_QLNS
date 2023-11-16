using CNPM_QLNS.Admin;
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

namespace CNPM_QLNS
{
    public partial class Admin_ThemNhanVienVaoPhongBan : Form
    {
        public PhongBan pb;
        public Admin_ChiTietPhongBan chiTietPhongBan;
        BL_NhanVien blnhanvien = new BL_NhanVien();
        BL_PhongBan  blphongban = new BL_PhongBan();
        List<NhanVien> listnv = new List<NhanVien>();
        public Admin_ThemNhanVienVaoPhongBan(PhongBan pb, Admin_ChiTietPhongBan ctpb)
        {
            InitializeComponent();
            this.pb = pb;
            this.chiTietPhongBan = ctpb;
        }

        private void Admin_ThemNhanVienVaoPhongBan_Load(object sender, EventArgs e)
        {
            listnv = blnhanvien.LayNhanVienChuaThuocPhongBan();
           cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (NhanVien nhanvien in listnv)
            {
               cmbMaNV.Items.Add(nhanvien.MaNV);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (blphongban.CapNhatMaPBNhanVien(cmbMaNV.Text.ToString(), pb.MaPB))
            {
                MessageBox.Show("Thêm nhân viên vào phòng ban thành công !");
                this.Close();
                chiTietPhongBan.nhanVienList = this.chiTietPhongBan.blpb.LayNhanVienTheoMaPB(pb.MaPB);
                chiTietPhongBan.LoadData(chiTietPhongBan.nhanVienList);
            }
            else
            {
                MessageBox.Show("Không thể thêm nhân viên vào phòng ban thành công !");
            }

        }
    }
}
