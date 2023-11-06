namespace CNPM_QLNS.Item
{
    partial class Item_PhongBan
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblSoLuongNV = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenPhongBan
            // 
            this.lblTenPhongBan.AutoSize = true;
            this.lblTenPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhongBan.ForeColor = System.Drawing.Color.White;
            this.lblTenPhongBan.Location = new System.Drawing.Point(29, 118);
            this.lblTenPhongBan.Name = "lblTenPhongBan";
            this.lblTenPhongBan.Size = new System.Drawing.Size(172, 25);
            this.lblTenPhongBan.TabIndex = 0;
            this.lblTenPhongBan.Text = "lblTenPhongBan";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::CNPM_QLNS.Properties.Resources.building__1_;
            this.picAvatar.Location = new System.Drawing.Point(302, 36);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(156, 140);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 79;
            this.picAvatar.TabStop = false;
            this.picAvatar.MouseEnter += new System.EventHandler(this.picAvatar_MouseEnter);
            this.picAvatar.MouseLeave += new System.EventHandler(this.picAvatar_MouseLeave);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::CNPM_QLNS.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(-2, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(460, 36);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa phòng ban";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblSoLuongNV
            // 
            this.lblSoLuongNV.AutoSize = true;
            this.lblSoLuongNV.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongNV.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongNV.Location = new System.Drawing.Point(25, 9);
            this.lblSoLuongNV.Name = "lblSoLuongNV";
            this.lblSoLuongNV.Size = new System.Drawing.Size(50, 54);
            this.lblSoLuongNV.TabIndex = 80;
            this.lblSoLuongNV.Text = "0";
            this.lblSoLuongNV.MouseEnter += new System.EventHandler(this.lblSoLuongNV_MouseEnter);
            this.lblSoLuongNV.MouseLeave += new System.EventHandler(this.lblSoLuongNV_MouseLeave);
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPB.ForeColor = System.Drawing.Color.White;
            this.lblMaPB.Location = new System.Drawing.Point(27, 63);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(106, 38);
            this.lblMaPB.TabIndex = 81;
            this.lblMaPB.Text = "MaPB";
            // 
            // Item_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(443, 218);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblSoLuongNV);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblTenPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_PhongBan";
            this.Text = "Item_PhongBan";
            this.Load += new System.EventHandler(this.Item_PhongBan_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_PhongBan_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Item_PhongBan_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_PhongBan_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenPhongBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblSoLuongNV;
        private System.Windows.Forms.Label lblMaPB;
    }
}