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
    public partial class Admin_FormThemTaiKhoan : Form
    {
        public Admin_FormMain formain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_TaiKhoan bltk = new BL_TaiKhoan();
        List<NhanVien> tatcaNhavienList = new List<NhanVien>();
        public Admin_FormThemTaiKhoan(Admin_FormMain formain)
        {
            InitializeComponent();
            this.formain = formain;
            tatcaNhavienList = blnv.LayDanhSachNhanVienChuaCoTaiKhoan();
            foreach (NhanVien nhanVien in tatcaNhavienList)
            {
                cmbMaNV.Items.Add(nhanVien.MaNV);
            }
            cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPhanQuyen.Items.Add("Admin");
            cmbPhanQuyen.Items.Add("User");
    
            cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrangThai.Items.Add("Active");
            cmbTrangThai.Items.Add("Inactive");
        }

        private void Admin_FormThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim() == "" || txtMatKhau.Text.Trim() =="" ||cmbMaNV.Text.Trim()==""
            || cmbPhanQuyen.Text.Trim() =="" || cmbTrangThai.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin vui lòng nhập lại !");
                
            }
            else
            {
                if(bltk.ThemTaiKhoan(cmbMaNV.Text.Trim(), txtEmail.Text.Trim()
                    , txtMatKhau.Text.Trim(), cmbPhanQuyen.Text.Trim(), cmbTrangThai.Text.Trim(),  DateTime.Now)){
                    MessageBox.Show("Thêm thành công !");
                    formain.LoadFormTaiKhoan();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thành công !");
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
