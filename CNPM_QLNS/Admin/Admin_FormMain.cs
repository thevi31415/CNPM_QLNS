﻿using CNPM_QLNS.Admin;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QLNS
{
    public partial class Admin_FormMain : Form
    {
        public Admin_FormMain()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }
        private void Admin_FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Width = 1200;
            this.Height = 750;

            loadform(new Admin_FormTongQuan());
            lblLink.Text = "Admin / Tổng quan";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.TimeString();
            lbl_Date.Text = DateTime.Now.DateString();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormTaiKhoan());
            lblLink.Text = "Admin / Tài khoản";
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormTongQuan());
            lblLink.Text = "Admin / Tổng quan";
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormNhanVien());
            lblLink.Text = "Admin / Nhân viên";
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormPhongBan());
            lblLink.Text = "Admin / Phòng ban";
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormChucVu());
            lblLink.Text = "Admin / Chức vụ";
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormDuAn());
            lblLink.Text = "Admin / Dự án";
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormLuong());
            lblLink.Text = "Admin / Lương";
        }

        private void btnAllowance_Click(object sender, EventArgs e)
        {
            loadform(new Admin_FormPhuCap());
            lblLink.Text = "Admin / Phụ Cấp";
        }
    }
}