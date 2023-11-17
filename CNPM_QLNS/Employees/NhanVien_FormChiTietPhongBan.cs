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

namespace CNPM_QLNS.Employees
{
    public partial class NhanVien_FormChiTietPhongBan : Form
    {

        public PhongBan pb;
        public BL_PhongBan blpb = new BL_PhongBan();
        BL_NhanVien blnv = new BL_NhanVien();
        public List<NhanVien> nhanVienList = new List<NhanVien>();
        List<NhanVien> tatcaNhavienList = new List<NhanVien>();
        public Admin_FormMain formmain;
        public NhanVien_FormChiTietPhongBan(PhongBan pb)
        {
            InitializeComponent();
            this.pb = pb;
            this.nhanVienList = blpb.LayNhanVienTheoMaPB(pb.MaPB);
            this.pb = pb;
          //  this.formmain = formmain;
            lblMaPB.Text = pb.MaPB.Trim();
            txtMaTrPhong.Text = pb.MaTrPhong.Trim();
            txtTenPhongBan.Text = pb.TenPhongBan.Trim();
            txtDiaDiem.Text = pb.DiaDiem.Trim();
            txtMoTa.Text = pb.MoTa.Trim();
            txtMoTa.Enabled = false;
            LoadData(nhanVienList);
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
                    Item_NhanVienPhongBan item_nhanvien = new Item_NhanVienPhongBan(pb, nhanVien, formmain, null); // Pass the reference
                    item_nhanvien.MouseClick -= Item_NhanVienPhongBan_MouseClick;
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

       public void Item_NhanVienPhongBan_MouseClick(object sender, MouseEventArgs e)
        {
           throw new NotImplementedException();
        }

        private void NhanVien_FormChiTietPhongBan_Load(object sender, EventArgs e)
        {

        }
    }
}
