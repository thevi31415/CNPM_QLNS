namespace CNPM_QLNS.Admin
{
    partial class Admin_FormChucVu
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
            this.flowLayoutPanelCV = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMaLg = new System.Windows.Forms.Label();
            this.lblNgayCong = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCV
            // 
            this.flowLayoutPanelCV.AutoScroll = true;
            this.flowLayoutPanelCV.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelCV.Location = new System.Drawing.Point(9, 155);
            this.flowLayoutPanelCV.Name = "flowLayoutPanelCV";
            this.flowLayoutPanelCV.Size = new System.Drawing.Size(1304, 620);
            this.flowLayoutPanelCV.TabIndex = 75;
            this.flowLayoutPanelCV.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelCV_Paint);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::CNPM_QLNS.Properties.Resources.plus1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1051, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(262, 37);
            this.btnLuu.TabIndex = 76;
            this.btnLuu.Text = "Thêm chức vụ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMaLg);
            this.panel4.Controls.Add(this.lblNgayCong);
            this.panel4.Controls.Add(this.lblChucVu);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(64, 113);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1299, 39);
            this.panel4.TabIndex = 91;
            // 
            // lblMaLg
            // 
            this.lblMaLg.AutoSize = true;
            this.lblMaLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLg.Location = new System.Drawing.Point(79, 12);
            this.lblMaLg.Name = "lblMaLg";
            this.lblMaLg.Size = new System.Drawing.Size(69, 22);
            this.lblMaLg.TabIndex = 5;
            this.lblMaLg.Text = "Mã CV";
            // 
            // lblNgayCong
            // 
            this.lblNgayCong.AutoSize = true;
            this.lblNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayCong.Location = new System.Drawing.Point(511, 12);
            this.lblNgayCong.Name = "lblNgayCong";
            this.lblNgayCong.Size = new System.Drawing.Size(131, 22);
            this.lblNgayCong.TabIndex = 3;
            this.lblNgayCong.Text = "Lương cơ bản";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(764, 12);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(59, 22);
            this.lblChucVu.TabIndex = 1;
            this.lblChucVu.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên CV";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.lblTrangThai);
            this.panel3.Location = new System.Drawing.Point(-2, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1351, 40);
            this.panel3.TabIndex = 90;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.White;
            this.lblTrangThai.Location = new System.Drawing.Point(499, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(342, 32);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Các chức vụ của công ty";
            // 
            // Admin_FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 784);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.flowLayoutPanelCV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_FormChucVu";
            this.Text = "Admin_FormChucVu";
            this.Load += new System.EventHandler(this.Admin_FormChucVu_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMaLg;
        private System.Windows.Forms.Label lblNgayCong;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTrangThai;
    }
}