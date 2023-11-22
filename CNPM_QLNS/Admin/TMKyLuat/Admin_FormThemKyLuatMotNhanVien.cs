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

namespace CNPM_QLNS.Admin.TMKyLuat
{
    public partial class Admin_FormThemKyLuatMotNhanVien : Form
    {
        public Admin_FormMain formMain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_KyLuat blkl = new BL_KyLuat();
        BL_KyLuatMotNhanVien blklchonv = new BL_KyLuatMotNhanVien();
        List<NhanVien> listnv = new List<NhanVien>();
        List<KyLuatNV> listklnv = new List<KyLuatNV>();
        public Admin_FormThemKyLuatMotNhanVien(Admin_FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            listnv = blnv.LayNhanVien();
            listklnv = blkl.LayDanhSachTatCaKyLuat();
            cmbMaKL.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (NhanVien nhanVien in listnv)
            {
                cmbMaNV.Items.Add(nhanVien.MaNV + "-" + nhanVien.HoTen);
            }
            foreach (KyLuatNV nhanVien in listklnv)
            {
               cmbMaKL.Items.Add(nhanVien.MaKL + "-" + nhanVien.LoaiKL);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ID = GenerateRandomString(8);
            string[] parts = cmbMaNV.Text.Trim().Split('-');
            string[] parts2 = cmbMaKL.Text.Trim().Split('-');
            string MaNV = parts[0];
            string MaKL = parts2[0];
            string TenKL = parts2[1];
            string SoQD = txtSoQuyetDinh.Text.Trim();
            if (blklchonv.ThemKyLuatChoNhanVien(ID, MaKL, MaNV, TenKL, SoQD))
            {
                formMain.LoadFormKyLuat();
                this.Close();
                MessageBox.Show("Thêm thành công !");
            }
        }
        static string GenerateRandomString(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder randomStringBuilder = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length);
                randomStringBuilder.Append(characters[index]);
            }

            return randomStringBuilder.ToString();
        }
    }
}
