namespace CNPM_QLNS.Admin
{
    partial class Admin_FormPhongBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelListPhongBan = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 129);
            this.panel1.TabIndex = 0;
            // 
            // panelListPhongBan
            // 
            this.panelListPhongBan.AutoScroll = true;
            this.panelListPhongBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelListPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListPhongBan.Location = new System.Drawing.Point(0, 129);
            this.panelListPhongBan.Margin = new System.Windows.Forms.Padding(0);
            this.panelListPhongBan.Name = "panelListPhongBan";
            this.panelListPhongBan.Size = new System.Drawing.Size(1212, 545);
            this.panelListPhongBan.TabIndex = 81;
            this.panelListPhongBan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListPhongBan_Paint);
            // 
            // Admin_FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 674);
            this.Controls.Add(this.panelListPhongBan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_FormPhongBan";
            this.Text = "Admin_FormPhongBan";
            this.Load += new System.EventHandler(this.Admin_FormPhongBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelListPhongBan;
    }
}