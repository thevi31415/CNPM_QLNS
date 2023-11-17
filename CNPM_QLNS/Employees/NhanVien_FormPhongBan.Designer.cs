namespace CNPM_QLNS.Employees
{
    partial class NhanVien_FormPhongBan
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
            this.panelListPhongBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListPhongBan
            // 
            this.panelListPhongBan.AutoScroll = true;
            this.panelListPhongBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelListPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListPhongBan.Location = new System.Drawing.Point(0, 82);
            this.panelListPhongBan.Margin = new System.Windows.Forms.Padding(0);
            this.panelListPhongBan.Name = "panelListPhongBan";
            this.panelListPhongBan.Size = new System.Drawing.Size(1194, 545);
            this.panelListPhongBan.TabIndex = 83;
            this.panelListPhongBan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListPhongBan_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 79);
            this.panel1.TabIndex = 82;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(140)))), ((int)(((byte)(254)))));
            this.lblLink.Location = new System.Drawing.Point(22, 29);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(328, 32);
            this.lblLink.TabIndex = 5;
            this.lblLink.Text = "Phòng ban đã tham gia";
            // 
            // NhanVien_FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 627);
            this.Controls.Add(this.panelListPhongBan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien_FormPhongBan";
            this.Text = "NhanVien_FormPhongBan";
            this.Load += new System.EventHandler(this.NhanVien_FormPhongBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelListPhongBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLink;
    }
}