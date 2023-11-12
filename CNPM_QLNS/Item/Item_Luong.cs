﻿using CNPM_QLNS.Admin;
using CNPM_QLNS.BS_Layer;
using CNPM_QLNS.Class;
using CNPM_QLNS.DB_Layer;
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
    public partial class Item_Luong : Form
    {
        public Luong luong;
        BL_NhanVien blnv = new BL_NhanVien();
        public Admin_FormMain formmain;
        public NhanVien nv;
        DBMain db = new DBMain();
      
        public Item_Luong(Luong luong, Admin_FormMain formnmain)
        {
            InitializeComponent();
            this.luong = luong;
            this.formmain = formnmain;
            this.nv = blnv.LayNhanVienTheoMa(luong.MaNV);
            lblMaLuong.Text = luong.MaLuong;
            lblNgayCong.Text = luong.NgayCong.ToString();
            lblHoTen.Text = blnv.LayNhanVienTheoMa(luong.MaNV).HoTen.ToString();
            lblMaNV.Text    =  luong.MaNV.ToString();
            lblThoiGian.Text = luong.Thang.ToString() +"/" + luong.Nam.ToString();
            lblTongluong.Text = luong.TongLuong.ToString();
        }

        private void Item_Luong_Load(object sender, EventArgs e)
        {

        }

        private void Item_Luong_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#ABD0F9");
        }

        private void Item_Luong_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lblNgayCong_Click(object sender, EventArgs e)
        {

        }

        private void Item_Luong_MouseClick(object sender, MouseEventArgs e)
        {
            Admin_FormXemLuong xemluong = new Admin_FormXemLuong(nv);
            xemluong.ShowDialog();
        }
    }
}