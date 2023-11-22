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

namespace CNPM_QLNS.Admin.PhuCap
{
    public partial class Admin_FormThemPhuCapChoNhanVien : Form
    {
        public Admin_FormMain formMain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhuCap blpc = new BL_PhuCap();
        BL_PhuCapChoNhanVien blpchonv = new BL_PhuCapChoNhanVien();
        List<NhanVien> listnv = new List<NhanVien>();
        List<PhuCapNV> listpc = new List<PhuCapNV>();
        public Admin_FormThemPhuCapChoNhanVien(Admin_FormMain formMain)
        {

            InitializeComponent();
            this.formMain = formMain;
            listnv = blnv.LayNhanVien();
            listpc = blpc.LayDanhSachTatCaPhuCap();
               cmbMaPC.DropDownStyle = ComboBoxStyle.DropDownList;
               cmbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (NhanVien nhanVien in listnv)
            {
               cmbMaNV.Items.Add(nhanVien.MaNV + "-" + nhanVien.HoTen);
            }
            foreach (PhuCapNV nhanVien in listpc)
            {
                cmbMaPC.Items.Add(nhanVien.MaPC + "-" + nhanVien.LoaiPC);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ID = GenerateRandomString(8);
            string[] parts = cmbMaNV.Text.Trim().Split('-');
            string[] parts2 = cmbMaPC.Text.Trim().Split('-');
            string MaNV = parts[0];
            string MaPC = parts2[0];
            string TenPC = parts2[1];
            string SoQD = txtSoQuyetDinh.Text.Trim();
            if(blpchonv.ThemPhuCapNhanVien(ID, MaPC, MaNV, TenPC, SoQD))
            {
                formMain.LoadFormPhuCap();
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
        private void Admin_FormThemPhuCapChoNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
