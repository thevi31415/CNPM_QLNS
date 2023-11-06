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
    public partial class Admin_ThemPhongBan : Form
    {
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhongBan blpb = new BL_PhongBan();
        public Admin_FormMain formain;
        List<NhanVien> tatcaNhavienList = new List<NhanVien>();
        public Admin_ThemPhongBan( Admin_FormMain formain)
        {
            InitializeComponent();
            this.formain = formain;
            tatcaNhavienList = blnv.LayNhanVien();
            foreach (NhanVien nhanVien in tatcaNhavienList)
            {
                cmbMaTrPhong.Items.Add(nhanVien.MaNV);
            }
         cmbMaTrPhong.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Admin_ThemPhongBan_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Trim() == "" || txtTenPhongBan.Text.Trim() == "" ||
                cmbMaTrPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin vui lòng nhập lại !");
            }
            else
            {

                if (blpb.ThemPhongBan(txtMaPB.Text.Trim(), txtTenPhongBan.Text, cmbMaTrPhong.Text,
               richTxtDiaDiem.Text, richTxtMoTa.Text))
                {
                    formain.LoadFormPhongBan();
                    this.Close();
                    MessageBox.Show("Thêm thánh công");

                }
                else
                {
                    MessageBox.Show("Không thể thêm");
                }

            }
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
