namespace CNPM_QLNS.Item
{
    partial class Item_LoaiKyLuat
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
            this.lblGiaTriKyLuat = new System.Windows.Forms.Label();
            this.lblTenKL = new System.Windows.Forms.Label();
            this.lblMaKL = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.picChanDung = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaTriKyLuat
            // 
            this.lblGiaTriKyLuat.AutoSize = true;
            this.lblGiaTriKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriKyLuat.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGiaTriKyLuat.Location = new System.Drawing.Point(846, 21);
            this.lblGiaTriKyLuat.Name = "lblGiaTriKyLuat";
            this.lblGiaTriKyLuat.Size = new System.Drawing.Size(96, 22);
            this.lblGiaTriKyLuat.TabIndex = 20;
            this.lblGiaTriKyLuat.Text = "NgaySinh";
            // 
            // lblTenKL
            // 
            this.lblTenKL.AutoSize = true;
            this.lblTenKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKL.ForeColor = System.Drawing.Color.Black;
            this.lblTenKL.Location = new System.Drawing.Point(324, 21);
            this.lblTenKL.Name = "lblTenKL";
            this.lblTenKL.Size = new System.Drawing.Size(70, 22);
            this.lblTenKL.TabIndex = 19;
            this.lblTenKL.Text = "HoTen";
            // 
            // lblMaKL
            // 
            this.lblMaKL.AutoSize = true;
            this.lblMaKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMaKL.Location = new System.Drawing.Point(143, 21);
            this.lblMaKL.Name = "lblMaKL";
            this.lblMaKL.Size = new System.Drawing.Size(69, 22);
            this.lblMaKL.TabIndex = 15;
            this.lblMaKL.Text = "Ma NV";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImage = global::CNPM_QLNS.Properties.Resources.delete__2_;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(1237, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 38);
            this.btnXoa.TabIndex = 18;
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
            this.btnChinhSua.Location = new System.Drawing.Point(1183, 15);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(38, 38);
            this.btnChinhSua.TabIndex = 17;
            this.btnChinhSua.Tag = "Chỉnh sưa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // picChanDung
            // 
            this.picChanDung.Image = global::CNPM_QLNS.Properties.Resources.yellow_card;
            this.picChanDung.Location = new System.Drawing.Point(19, 4);
            this.picChanDung.Name = "picChanDung";
            this.picChanDung.Size = new System.Drawing.Size(65, 60);
            this.picChanDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChanDung.TabIndex = 16;
            this.picChanDung.TabStop = false;
            // 
            // Item_LoaiKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 68);
            this.Controls.Add(this.lblGiaTriKyLuat);
            this.Controls.Add(this.lblTenKL);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.picChanDung);
            this.Controls.Add(this.lblMaKL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_LoaiKyLuat";
            this.Text = "Item_LoaiKyLuat";
            this.Load += new System.EventHandler(this.Item_LoaiKyLuat_Load);
            this.MouseEnter += new System.EventHandler(this.Item_LoaiKyLuat_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_LoaiKyLuat_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiaTriKyLuat;
        private System.Windows.Forms.Label lblTenKL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.PictureBox picChanDung;
        private System.Windows.Forms.Label lblMaKL;
    }
}