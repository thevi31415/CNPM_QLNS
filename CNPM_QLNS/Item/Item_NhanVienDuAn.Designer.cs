namespace CNPM_QLNS.Item
{
    partial class Item_NhanVienDuAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_NhanVienDuAn));
            this.lblTrangThai = new System.Windows.Forms.Button();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.picChanDung = new System.Windows.Forms.PictureBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            resources.ApplyResources(this.lblTrangThai, "lblTrangThai");
            this.lblTrangThai.FlatAppearance.BorderSize = 0;
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.UseVisualStyleBackColor = false;
            // 
            // lblGioiTinh
            // 
            resources.ApplyResources(this.lblGioiTinh, "lblGioiTinh");
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Name = "lblGioiTinh";
            // 
            // lblNgaySinh
            // 
            resources.ApplyResources(this.lblNgaySinh, "lblNgaySinh");
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Name = "lblNgaySinh";
            // 
            // lblHoTen
            // 
            resources.ApplyResources(this.lblHoTen, "lblHoTen");
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Name = "lblHoTen";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImage = global::CNPM_QLNS.Properties.Resources.delete__2_;
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // picChanDung
            // 
            this.picChanDung.Image = global::CNPM_QLNS.Properties.Resources.picNhanVien;
            resources.ApplyResources(this.picChanDung, "picChanDung");
            this.picChanDung.Name = "picChanDung";
            this.picChanDung.TabStop = false;
            // 
            // lblMaNV
            // 
            resources.ApplyResources(this.lblMaNV, "lblMaNV");
            this.lblMaNV.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMaNV.Name = "lblMaNV";
            // 
            // Item_NhanVienDuAn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.picChanDung);
            this.Controls.Add(this.lblMaNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_NhanVienDuAn";
            this.Load += new System.EventHandler(this.Item_NhanVienDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblTrangThai;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox picChanDung;
        private System.Windows.Forms.Label lblMaNV;
    }
}