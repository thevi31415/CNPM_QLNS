using CNPM_QLNS.Admin;
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
    public partial class NhanVien_FormTaiKhoan : Form
    {
        public List<TaiKhoan> taikhoanlist;

        BL_TaiKhoan tkBL = new BL_TaiKhoan();
        public NhanVien_FormMain nv_formMain;
        public TaiKhoan tk;
        int check = 0;
        public NhanVien_FormTaiKhoan(TaiKhoan tk)
        {
            InitializeComponent();
            check = 1;
            this.tk = tk;
            lblMaNV.Text = tk.MaNV;
            lblEmail.Text = tk.Email;
            lblTrangThai.Text = tk.TrangThai;
            if (tk.TrangThai.Trim() == "Active")
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#04A144");
            }
            else
            {
                lblTrangThai.BackColor = ColorTranslator.FromHtml("#F70000");
            }
            if (tk.PhanQuyen.Trim() == "Admin")
            {
                lblPhanQuyen.BackColor = ColorTranslator.FromHtml("#2337C6");
            }
            else
            {
                lblPhanQuyen.BackColor = ColorTranslator.FromHtml("#870001");
            }
            lblPhanQuyen.Text = tk.PhanQuyen;
            lblTruyCap.Text = tk.TruyCap.ToString();
        }
        public void LoadData(List<TaiKhoan> tkList)
        {

           /* panelListTaiKhoan.Controls.Clear();

            //  nvList = nv.LayNhanVien();
            panelListTaiKhoan.Padding = new Padding(10, 0, 10, 0);
            // MessageBox.Show(taikhoanlist.Count().ToString());
            if (tkList.Count > 0)
            {
                //  MessageBox.Show(nhanVienList.Count().ToString());
                foreach (TaiKhoan taikhoan in tkList)
                {
                    Item_TaiKhoan item_taikhoan = new Item_TaiKhoan(nv_formMain, taikhoan); // Pass the reference
                    item_taikhoan.TopLevel = false;
                    panelListTaiKhoan.Controls.Add(item_taikhoan);
                    item_taikhoan.Show();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay nhan vien nao =)))");
            }
*/

        }
        private void Admin_FormTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
       

        private void btnSua_Click(object sender, EventArgs e)
        {
          /*  NhanVien_FormSuaTaiKhoan formSuaTK = new NhanVien_FormSuaTaiKhoan();
            formSuaTK.ShowDialog();*/
        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPhanQuyen_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblMaNV_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            NhanVien_FormDoiMatKhau dmk = new NhanVien_FormDoiMatKhau(tk);
            dmk.ShowDialog();
        }
    }
}
