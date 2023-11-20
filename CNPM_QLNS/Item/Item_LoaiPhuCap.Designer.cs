namespace CNPM_QLNS.Item
{
    partial class Item_LoaiPhuCap
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
            this.lblGiaTriPhuCap = new System.Windows.Forms.Label();
            this.lblTenPC = new System.Windows.Forms.Label();
            this.lblMaPC = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.picChanDung = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaTriPhuCap
            // 
            this.lblGiaTriPhuCap.AutoSize = true;
            this.lblGiaTriPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriPhuCap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGiaTriPhuCap.Location = new System.Drawing.Point(839, 20);
            this.lblGiaTriPhuCap.Name = "lblGiaTriPhuCap";
            this.lblGiaTriPhuCap.Size = new System.Drawing.Size(96, 22);
            this.lblGiaTriPhuCap.TabIndex = 14;
            this.lblGiaTriPhuCap.Text = "NgaySinh";
            this.lblGiaTriPhuCap.Click += new System.EventHandler(this.lblGiaTriPhuCap_Click);
            // 
            // lblTenPC
            // 
            this.lblTenPC.AutoSize = true;
            this.lblTenPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPC.ForeColor = System.Drawing.Color.Black;
            this.lblTenPC.Location = new System.Drawing.Point(317, 20);
            this.lblTenPC.Name = "lblTenPC";
            this.lblTenPC.Size = new System.Drawing.Size(70, 22);
            this.lblTenPC.TabIndex = 13;
            this.lblTenPC.Text = "HoTen";
            this.lblTenPC.Click += new System.EventHandler(this.lblTenPC_Click);
            // 
            // lblMaPC
            // 
            this.lblMaPC.AutoSize = true;
            this.lblMaPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPC.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMaPC.Location = new System.Drawing.Point(136, 20);
            this.lblMaPC.Name = "lblMaPC";
            this.lblMaPC.Size = new System.Drawing.Size(69, 22);
            this.lblMaPC.TabIndex = 9;
            this.lblMaPC.Text = "Ma NV";
            this.lblMaPC.Click += new System.EventHandler(this.lblMaPC_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundImage = global::CNPM_QLNS.Properties.Resources.delete__2_;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(1230, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 38);
            this.btnXoa.TabIndex = 12;
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
            this.btnChinhSua.Location = new System.Drawing.Point(1176, 14);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(38, 38);
            this.btnChinhSua.TabIndex = 11;
            this.btnChinhSua.Tag = "Chỉnh sưa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // picChanDung
            // 
            this.picChanDung.Image = global::CNPM_QLNS.Properties.Resources.payment_method;
            this.picChanDung.Location = new System.Drawing.Point(12, 3);
            this.picChanDung.Name = "picChanDung";
            this.picChanDung.Size = new System.Drawing.Size(65, 60);
            this.picChanDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChanDung.TabIndex = 10;
            this.picChanDung.TabStop = false;
            this.picChanDung.Click += new System.EventHandler(this.picChanDung_Click);
            // 
            // Item_LoaiPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1295, 68);
            this.Controls.Add(this.lblGiaTriPhuCap);
            this.Controls.Add(this.lblTenPC);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.picChanDung);
            this.Controls.Add(this.lblMaPC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_LoaiPhuCap";
            this.Text = "Item_LoaiPhuCap";
            this.Load += new System.EventHandler(this.Item_LoaiPhuCap_Load);
            this.MouseEnter += new System.EventHandler(this.Item_LoaiPhuCap_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_LoaiPhuCap_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picChanDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiaTriPhuCap;
        private System.Windows.Forms.Label lblTenPC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.PictureBox picChanDung;
        private System.Windows.Forms.Label lblMaPC;
    }
}