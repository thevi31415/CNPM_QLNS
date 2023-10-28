namespace CNPM_QLNS.Admin
{
    partial class Admin_FormNhanVien
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
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelListNhanVien = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(45, 12);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(222, 39);
            this.btnThemNhanVien.TabIndex = 0;
            this.btnThemNhanVien.Text = "button1";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelListNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 578);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, -17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 34);
            this.panel3.TabIndex = 1;
            // 
            // panelListNhanVien
            // 
            this.panelListNhanVien.AutoScroll = true;
            this.panelListNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelListNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListNhanVien.Location = new System.Drawing.Point(0, 17);
            this.panelListNhanVien.Name = "panelListNhanVien";
            this.panelListNhanVien.Size = new System.Drawing.Size(1212, 561);
            this.panelListNhanVien.TabIndex = 0;
            this.panelListNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Admin_FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_FormNhanVien";
            this.Text = "Admin_FormNhanVien";
            this.Load += new System.EventHandler(this.Admin_FormNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelListNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThemNhanVien;
    }
}