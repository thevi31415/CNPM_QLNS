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
    public partial class Admin_FormXemLuong : Form
    {
        BL_PhongBan blphongban = new BL_PhongBan();
        BL_ChucVu blchucvu = new BL_ChucVu();
        BL_TrinhDo bltrinhdo = new BL_TrinhDo();
        BL_ChuyenMon blchuyenmon = new BL_ChuyenMon();
        List<PhongBan> listphongban = new List<PhongBan>();
        List<ChucVuNV> listchucvu = new List<ChucVuNV>();
        List<TrinhDo> listtrinhdo = new List<TrinhDo>();
        List<ChuyenMon> listchuyenmon = new List<ChuyenMon>();
        public List<Luong> luongList = new List<Luong>();
        public List<NhanVien> ketquatimkiemnv = new List<NhanVien>();
        BL_Luong luong = new BL_Luong();
        BL_TimKiem timKiem = new BL_TimKiem();
        public NhanVien nv;
        public Admin_FormMain formmain;
        int check = 0;
        public Admin_FormXemLuong(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            lblMaNV.Text = nv.MaNV.ToString();
            lblHoTen.Text = nv.HoTen.ToString();
            lblCMND.Text = nv.CMND.ToString();
            lblGioiTinh.Text = nv.GioiTinh.ToString();
            lblQueQuan.Text = nv.QueQuan.ToString();
            lblTonGiao.Text = nv.TonGiao.ToString();
            lblDiachi.Text = nv.DiaChi.ToString();
            lblNgaySinh.Text = nv.NgaySinh.ToString();
            lblTrangThai.Text = nv.TrangThai.ToString();
            if (lblTrangThai.Text == "Đang làm việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#0FD99B");
            }
            if (lblTrangThai.Text == "Đã nghỉ việc")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#FF0000");
            }
            if (lblTrangThai.Text == "Nghỉ việc tạm thời")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#EC9E0C");

            }
            listphongban = blphongban.LayDanhSachPhongBanTheoMaPB(nv.MaPB.ToString());
            listchucvu = blchucvu.LayDanhSachChucVuTheoMaCV(nv.MaCV.ToString());
            listtrinhdo = bltrinhdo.LayDanhSachTrinhDoTheoMaTD(nv.MaTD.ToString());
            listchuyenmon = blchuyenmon.LayDanhSachCHUYENMONTheoMaCM(nv.MaCM.ToString());
            if (listphongban.Count > 0)
            {
                lblPhongBan.Text = listphongban[0].TenPhongBan.ToString();
            }
            if (listchucvu.Count > 0)
            {
                //  lblChucVu.Text = blchucvu.LayDanhSachChucVuTheoMaCV(nv.MaCV)[0].TenCV.ToString();
                lblChucVu.Text = listchucvu[0].TenCV.ToString();
            }
            if (listtrinhdo.Count > 0)
            {
                lblTrinhDo.Text = listtrinhdo[0].TenTD.ToString();
            }
            if (listchuyenmon.Count > 0)
            {
                lblChuyenMon.Text = listchuyenmon[0].TenCM.ToString();
            }
        }
        public void LoadData(List<Luong> luongList)
        {

            panelListLuong.Controls.Clear();
            this.luongList = luong.LayLuong();
            //  nvList = nv.LayNhanVien();
            panelListLuong.Padding = new Padding(10, 0, 10, 0); ;
            if (luongList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (Luong luong in luongList)
                {
                    Item_Luong item_luong = new Item_Luong(luong, formmain, 1); // Pass the reference
                    item_luong.TopLevel = false;
                    panelListLuong.Controls.Add(item_luong);
                    item_luong.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }


        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_FormXemLuong_Load(object sender, EventArgs e)
        {
            this.Width = 1000;
            this.Height = 700;
            this.luongList = luong.LayLuongTheoMaNV(nv.MaNV);
            LoadData(luongList);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMaNV_Click(object sender, EventArgs e)
        {

        }

        private void picChanDung_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblDiachi_Click(object sender, EventArgs e)
        {

        }

        private void lblTonGiao_Click(object sender, EventArgs e)
        {

        }

        private void lblQueQuan_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lblCMND_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblChucVu_Click(object sender, EventArgs e)
        {

        }

        private void lblPhongBan_Click(object sender, EventArgs e)
        {

        }

        private void lblChuyenMon_Click(object sender, EventArgs e)
        {

        }

        private void lblTrinhDo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}
