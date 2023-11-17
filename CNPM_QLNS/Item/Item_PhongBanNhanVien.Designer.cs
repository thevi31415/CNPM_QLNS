namespace CNPM_QLNS.Item
{
    partial class Item_PhongBanNhanVien
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
            this.lblTenPhongBan = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblSoLuongNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenPhongBan
            // 
            this.lblTenPhongBan.AutoSize = true;
            this.lblTenPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhongBan.ForeColor = System.Drawing.Color.White;
            this.lblTenPhongBan.Location = new System.Drawing.Point(22, 135);
            this.lblTenPhongBan.Name = "lblTenPhongBan";
            this.lblTenPhongBan.Size = new System.Drawing.Size(172, 25);
            this.lblTenPhongBan.TabIndex = 82;
            this.lblTenPhongBan.Text = "lblTenPhongBan";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::CNPM_QLNS.Properties.Resources.building__1_;
            this.picAvatar.Location = new System.Drawing.Point(295, 32);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(156, 140);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 84;
            this.picAvatar.TabStop = false;
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPB.ForeColor = System.Drawing.Color.White;
            this.lblMaPB.Location = new System.Drawing.Point(20, 78);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(106, 38);
            this.lblMaPB.TabIndex = 86;
            this.lblMaPB.Text = "MaPB";
            // 
            // lblSoLuongNV
            // 
            this.lblSoLuongNV.AutoSize = true;
            this.lblSoLuongNV.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongNV.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongNV.Location = new System.Drawing.Point(18, 24);
            this.lblSoLuongNV.Name = "lblSoLuongNV";
            this.lblSoLuongNV.Size = new System.Drawing.Size(50, 54);
            this.lblSoLuongNV.TabIndex = 85;
            this.lblSoLuongNV.Text = "0";
            // 
            // Item_PhongBanNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(191)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(443, 218);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblSoLuongNV);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblTenPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_PhongBanNhanVien";
            this.Text = "Item_PhongBanNhanVien";
            this.Load += new System.EventHandler(this.Item_PhongBanNhanVien_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_PhongBanNhanVien_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Item_PhongBanNhanVien_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_PhongBanNhanVien_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenPhongBan;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblSoLuongNV;
    }
}