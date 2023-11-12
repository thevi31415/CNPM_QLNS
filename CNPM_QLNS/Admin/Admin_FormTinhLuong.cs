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
        List<PhuCap> phuCaplist= new List<PhuCap>();
        List<NhanVien> NhanVienList = new List<NhanVien>(); 
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
            foreach (NhanVien nhanVien in NhanVienList)
            {
                cmbMaNV.Items.Add(nhanVien.MaNV + " - " + nhanVien.HoTen);
            }
            foreach (PhuCap phucap in phuCaplist)
            {
                cmbPhuCap.Items.Add(phucap.LoaiPC);
            }
        }

        private void dtpNgayTinhLuong_CloseUp(object sender, EventArgs e)
        {
            dtpNgayTinhLuong.Value = new DateTime(dtpNgayTinhLuong.Value.Year, dtpNgayTinhLuong.Value.Month, 1);
        }
    }
}
