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
    public partial class Admin_FormXemNhanVien : Form
    {
        BL_PhongBan blphongban = new BL_PhongBan();
        BL_ChucVu blchucvu = new BL_ChucVu();
        BL_TrinhDo bltrinhdo = new BL_TrinhDo();
        BL_ChuyenMon blchuyenmon = new BL_ChuyenMon();
        List<PhongBan> listphongban = new List<PhongBan>();
        List<ChucVuNV>   listchucvu = new List<ChucVuNV>();
        List<TrinhDo>  listtrinhdo = new List<TrinhDo>();
        List<ChuyenMon> listchuyenmon = new List<ChuyenMon>();
        public Admin_FormXemNhanVien(NhanVien nv)
        {
            InitializeComponent();
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
            if(listchucvu.Count > 0)
            {
                //  lblChucVu.Text = blchucvu.LayDanhSachChucVuTheoMaCV(nv.MaCV)[0].TenCV.ToString();
                lblChucVu.Text = listchucvu[0].TenCV.ToString();
            }
            if(listtrinhdo.Count > 0)
            {
                lblTrinhDo.Text = listtrinhdo[0].TenTD.ToString();
            }
            if(listchuyenmon.Count > 0)
            {
                lblChuyenMon.Text = listchuyenmon[0].TenCM.ToString();
            }
        }

        private void Admin_FormXemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
