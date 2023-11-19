using CNPM_QLNS.BS_Layer;
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
    public partial class Admin_FormThemDuAn : Form
    {
        BL_DuAn blda = new BL_DuAn();
        public Admin_FormMain formmain;
        public Admin_FormThemDuAn(Admin_FormMain formMain)
        {
            InitializeComponent();
            formmain = formMain;
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;

        }

        private void Admin_FormThemDuAn_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaDA = txtMaDA.Text.Trim();
            string TenDA = txtTenDA.Text.Trim();
            string MoTa = txtMoTa.Text.Trim();
            int trangthai = 0;
            int giatri = Convert.ToInt32(txtGiaTRi.Text.Trim());
            DateTime ngaybatdau = dtpNgayBatDau.Value;
            DateTime ngayketthuc = dtpNgayKetThuc.Value;
            if (blda.ThemDuAn(MaDA, TenDA, giatri, ngaybatdau, ngayketthuc, MoTa, trangthai))
            {
                formmain.LoadFormDuAn();
                this.Close();
                MessageBox.Show("Thêm thành công !");

            }
            else
            {
                MessageBox.Show("Không thể thêm do trùng MaDA");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
