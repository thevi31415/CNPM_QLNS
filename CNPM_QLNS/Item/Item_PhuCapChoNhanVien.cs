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

namespace CNPM_QLNS.Item
{
    public partial class Item_PhuCapChoNhanVien : Form
    {
        public Admin_FormMain formain;
        BL_NhanVien blnv = new BL_NhanVien();
        BL_PhuCap blpc = new BL_PhuCap();   
        PhuCapNV pc = new PhuCapNV();
        BL_PhuCapChoNhanVien blpcchonv = new BL_PhuCapChoNhanVien();
        PhuCapNhanVien pcnv;
        public Item_PhuCapChoNhanVien(Admin_FormMain formMain, PhuCapNhanVien pcnv)
        {
            InitializeComponent();
            this.formain = formMain;
            this.pcnv = pcnv;
          
            if(blpc.LayThongTinPhuCapTheoMaPC(pcnv.MaPC).Count > 0)
            {
                pc = blpc.LayThongTinPhuCapTheoMaPC(pcnv.MaPC)[0];
                lblID.Text = pcnv.ID;
                lblMaNV.Text = pcnv.MaNV;
                lblHoTen.Text = blnv.LayDanhSachNhanVienTheoMaNV(pcnv.MaNV)[0].HoTen;
                lblTenPC.Text = pc.LoaiPC;
                lblSoTien.Text = pc.GiaTriPC.ToString();
                lblSoQD.Text = pcnv.SoQD;
            }
           
            if (formain == null)
            {
                btnXoa.Visible = false;
            }
            
        }

        private void Item_PhuCapChoNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi dự án  không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {


                if (blpcchonv.XoaPhuCapNhanVien(pcnv.ID))
                {
                    formain.LoadFormPhuCap();
                    this.Close();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                MessageBox.Show("Hủy xóa phụ cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Item_PhuCapChoNhanVien_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_PhuCapChoNhanVien_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
