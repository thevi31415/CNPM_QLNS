namespace CNPM_QLNS.Employees
{
    partial class NhanVien_FormLuong
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
            this.panelListLuong = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelListLuong
            // 
            this.panelListLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListLuong.AutoScroll = true;
            this.panelListLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelListLuong.Location = new System.Drawing.Point(9, 234);
            this.panelListLuong.Margin = new System.Windows.Forms.Padding(0);
            this.panelListLuong.Name = "panelListLuong";
            this.panelListLuong.Size = new System.Drawing.Size(1039, 380);
            this.panelListLuong.TabIndex = 86;
            // 
            // NhanVien_FormLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 635);
            this.Controls.Add(this.panelListLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien_FormLuong";
            this.Text = "NhanVien_FormLuong";
            this.Load += new System.EventHandler(this.NhanVien_FormLuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelListLuong;
    }
}