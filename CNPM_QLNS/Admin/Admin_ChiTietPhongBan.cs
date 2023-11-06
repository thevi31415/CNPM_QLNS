using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.Item;
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
    public partial class Admin_ChiTietPhongBan : Form
    {
        public PhongBan pb;
        public BL_PhongBan blpb = new BL_PhongBan();
        BL_NhanVien blnv  = new BL_NhanVien();
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        List<NhanVien> tatcaNhavienList = new List<NhanVien>();
        public Admin_FormMain formmain;
        public Admin_ChiTietPhongBan(PhongBan pb, Admin_FormMain formmain)
        {
            InitializeComponent();
            this.pb = pb;
            this.formmain = formmain;
            lblMaPB.Text = pb.MaPB.Trim();
            txtTenPhongBan.Text = pb.TenPhongBan.Trim();
            richTxtDiaDiem.Text = pb.DiaDiem.Trim();
            richTxtMoTa.Text = pb.MoTa.Trim();
            this.nhanVienList = blpb.LayNhanVienTheoMaPB(pb.MaPB);
         //   cmbMaTrPhong.DropDownStyle = ComboBoxStyle.DropDownList;
          //  cmbMaTrPhong.SelectedItem = pb.MaTrPhong;
            cmbMaTrPhong.Text = pb.MaTrPhong;
          //  MessageBox.Show(pb.MaTrPhong);
            //  cmbMaTrPhong.Items.Add("Đang làm việc");
            LoadData(nhanVienList);

            tatcaNhavienList = blnv.LayNhanVien();
            txtTenPhongBan.Enabled = false;
            richTxtDiaDiem.Enabled = false;
            cmbMaTrPhong.Enabled = false;   
            richTxtMoTa.Enabled = false;
            btnLuu.Enabled = false;
            foreach (NhanVien nhanVien in tatcaNhavienList)
            {
               cmbMaTrPhong.Items.Add(nhanVien.MaNV);
            }
        }
        public void LoadData(List<NhanVien> nvList)
        {

            panellistNhanVienPhongBan.Controls.Clear();
            this.nhanVienList = blpb.LayNhanVienTheoMaPB(pb.MaPB);
            //  nvList = nv.LayNhanVien();
            panellistNhanVienPhongBan.Padding = new Padding(10, 0, 10, 0); ;
            if (nvList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (NhanVien nhanVien in nvList)
                {
                    Item_NhanVienPhongBan item_nhanvien = new Item_NhanVienPhongBan(pb, nhanVien, formmain, this); // Pass the reference
                    item_nhanvien.TopLevel = false;
                   panellistNhanVienPhongBan.Controls.Add(item_nhanvien);
                    item_nhanvien.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }
        private void Admin_ChiTietPhongBan_Load(object sender, EventArgs e)
        {
          
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Admin_ThemNhanVienVaoPhongBan frmthemnv = new Admin_ThemNhanVienVaoPhongBan(pb, this);
            frmthemnv.ShowDialog();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            txtTenPhongBan.Enabled = true;
            richTxtDiaDiem.Enabled = true;
            cmbMaTrPhong.Enabled = true;
            richTxtMoTa.Enabled = true;
            btnLuu.Enabled = true;
            btnChinhSua.Enabled = false ;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (blpb.CapNhatPhongBan(lblMaPB.Text, txtTenPhongBan.Text, richTxtDiaDiem.Text, richTxtMoTa.Text,
                    cmbMaTrPhong.Text))
            {
                MessageBox.Show("Câp nhật thành cong");
                formmain.LoadFormPhongBan();
            }
            else
            {
                MessageBox.Show("Câp nhật thất bại");
            }
            txtTenPhongBan.Enabled = false;
            richTxtDiaDiem.Enabled = false;
            cmbMaTrPhong.Enabled = false;
            richTxtMoTa.Enabled = false;
            btnLuu.Enabled = false;
            btnChinhSua .Enabled = true;
        }
    }
}
