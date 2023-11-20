using CNPM_QLNS.Admin.PhuCap;
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

namespace CNPM_QLNS.Item
{
    public partial class Item_LoaiPhuCap : Form
    {

        public PhuCapNV phucap;
        public Admin_FormMain formMain;
        BL_PhuCap blpc = new BL_PhuCap();   
        public Item_LoaiPhuCap(PhuCapNV phucap, Admin_FormMain formMain)
        {
            InitializeComponent();
            this.phucap = phucap;
            this.formMain = formMain;
            lblMaPC.Text = phucap.MaPC;
            lblTenPC.Text = phucap.LoaiPC;
            lblGiaTriPhuCap.Text = phucap.GiaTriPC.ToString();
        }

        private void Item_LoaiPhuCap_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ra khỏi dự án  không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {


                if (blpc.XoaPhuCap(phucap.MaPC))
                {
                    formMain.LoadFormPhuCap();
                    this.Close();
                    MessageBox.Show("Xóa  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                MessageBox.Show("Hủy xóa phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Admin_FormChinhSuaPhuCap pc = new Admin_FormChinhSuaPhuCap(formMain, phucap);
            pc.ShowDialog();
        }

        private void lblMaPC_Click(object sender, EventArgs e)
        {

        }

        private void lblTenPC_Click(object sender, EventArgs e)
        {

        }

        private void picChanDung_Click(object sender, EventArgs e)
        {

        }

        private void lblGiaTriPhuCap_Click(object sender, EventArgs e)
        {

        }

        private void Item_LoaiPhuCap_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_LoaiPhuCap_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
