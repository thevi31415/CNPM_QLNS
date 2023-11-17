namespace CNPM_QLNS.Admin
{
    partial class Admin_FormDuAn
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
			this.panelListDuAn = new System.Windows.Forms.FlowLayoutPanel();
			this.btnThemDuAn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnThemDuAn);
			this.panel1.Controls.Add(this.panelListDuAn);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(910, 550);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panelListDuAn
			// 
			this.panelListDuAn.AutoScroll = true;
			this.panelListDuAn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelListDuAn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelListDuAn.Location = new System.Drawing.Point(0, 107);
			this.panelListDuAn.Margin = new System.Windows.Forms.Padding(0);
			this.panelListDuAn.Name = "panelListDuAn";
			this.panelListDuAn.Size = new System.Drawing.Size(910, 443);
			this.panelListDuAn.TabIndex = 82;
			this.panelListDuAn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListDuAn_Paint);
			// 
			// btnThemDuAn
			// 
			this.btnThemDuAn.BackColor = System.Drawing.Color.ForestGreen;
			this.btnThemDuAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnThemDuAn.FlatAppearance.BorderSize = 0;
			this.btnThemDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemDuAn.ForeColor = System.Drawing.Color.White;
			this.btnThemDuAn.Image = global::CNPM_QLNS.Properties.Resources.add;
			this.btnThemDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemDuAn.Location = new System.Drawing.Point(26, 28);
			this.btnThemDuAn.Margin = new System.Windows.Forms.Padding(2);
			this.btnThemDuAn.Name = "btnThemDuAn";
			this.btnThemDuAn.Size = new System.Drawing.Size(182, 38);
			this.btnThemDuAn.TabIndex = 83;
			this.btnThemDuAn.Text = "Thêm dự án";
			this.btnThemDuAn.UseVisualStyleBackColor = false;
			this.btnThemDuAn.Click += new System.EventHandler(this.btnThemDuAn_Click);
			// 
			// Admin_FormDuAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 548);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Admin_FormDuAn";
			this.Text = "Admin_FormDuAn";
			this.Load += new System.EventHandler(this.Admin_FormDuAn_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel panelListDuAn;
		private System.Windows.Forms.Button btnThemDuAn;
	}
}