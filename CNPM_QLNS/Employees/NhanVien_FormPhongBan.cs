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
    public partial class NhanVien_FormPhongBan : Form
    {
        public List<PhongBan> phongBanList = new List<PhongBan>();
        public List<PhongBan> ketquatimkiemnv = new List<PhongBan>();
        public NhanVien nv;
        BL_PhongBan pb = new BL_PhongBan();
        public NhanVien_FormPhongBan(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;

        }
        public void LoadData(List<PhongBan> pbList)
        {
            panelListPhongBan.Controls.Clear();
            this.phongBanList = pb.LayPhongBan();

            if (pbList.Count > 0)
            {
                int itemsPerRow = 3; // Số mục trên mỗi hàng
                int itemCount = 0;
                FlowLayoutPanel currentRowPanel = null;

                foreach (PhongBan phongBan in pbList)
                {
                    // Tạo một Item_PhongBan mới
                   Item_PhongBanNhanVien item_phongban = new Item_PhongBanNhanVien(phongBan); // Pass the reference
                    item_phongban.TopLevel = false;

                    // Kiểm tra nếu chúng ta cần tạo một hàng mới
                    if (itemCount % itemsPerRow == 0)
                    {
                        currentRowPanel = new FlowLayoutPanel();
                        currentRowPanel.FlowDirection = FlowDirection.LeftToRight;
                        currentRowPanel.WrapContents = false;
                        currentRowPanel.AutoSize = true;
                        panelListPhongBan.Controls.Add(currentRowPanel);
                    }

                    // Thêm mục vào hàng hiện tại
                    currentRowPanel.Controls.Add(item_phongban);
                    item_phongban.Show();

                    itemCount++;
                }
            }
            else
            {
                //MessageBox.Show("Không tìm thấy phòng ban nào =)))");
            }
        }

        private void panelListPhongBan_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void NhanVien_FormPhongBan_Load(object sender, EventArgs e)
        {
            this.phongBanList = pb.LayDanhSachPhongBanTheoMaPB(nv.MaPB);
            LoadData(phongBanList);
        }
    }
}
