namespace CNPM_QLNS.Item
{
    partial class Item_NhanVien
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picChanDung = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(12, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 13);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // picChanDung
            // 
            this.picChanDung.Image = global::CNPM_QLNS.Properties.Resources.picNhanVien;
            this.picChanDung.Location = new System.Drawing.Point(32, 5);
            this.picChanDung.Name = "picChanDung";
            this.picChanDung.Size = new System.Drawing.Size(80, 80);
            this.picChanDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChanDung.TabIndex = 3;
            this.picChanDung.TabStop = false;
            this.picChanDung.Click += new System.EventHandler(this.picChanDung_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImage = global::CNPM_QLNS.Properties.Resources.delete__2_;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(1265, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.LimeGreen;
            this.btnChinhSua.BackgroundImage = global::CNPM_QLNS.Properties.Resources.edit;
            this.btnChinhSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.ForeColor = System.Drawing.Color.Chocolate;
            this.btnChinhSua.Location = new System.Drawing.Point(1209, 29);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(38, 38);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.Tag = "Chỉnh sưa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMaNV.Location = new System.Drawing.Point(142, 37);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(69, 22);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Ma NV";
            this.lblMaNV.Click += new System.EventHandler(this.lblMaNV_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGioiTinh.Location = new System.Drawing.Point(845, 35);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(86, 22);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "GioiTinh";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNgaySinh.Location = new System.Drawing.Point(532, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(96, 22);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "NgaySinh";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHoTen.Location = new System.Drawing.Point(309, 37);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 22);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "HoTen";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.lblTrangThai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblTrangThai.FlatAppearance.BorderSize = 0;
            this.lblTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrangThai.Location = new System.Drawing.Point(1026, 31);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(163, 33);
            this.lblTrangThai.TabIndex = 48;
            this.lblTrangThai.Text = "Đóng";
            this.lblTrangThai.UseVisualStyleBackColor = false;
            this.lblTrangThai.Click += new System.EventHandler(this.lblTrangThai_Click_1);
            // 
            // Item_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 97);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.picChanDung);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblMaNV);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_NhanVien";
            this.Text = "Item_NhanVien";
            this.Load += new System.EventHandler(this.Item_NhanVien_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_NhanVien_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Item_NhanVien_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_NhanVien_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picChanDung;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button lblTrangThai;
    }
}