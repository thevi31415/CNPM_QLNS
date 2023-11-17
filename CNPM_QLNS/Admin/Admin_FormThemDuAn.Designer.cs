namespace CNPM_QLNS.Admin
{
	partial class Admin_FormThemDuAn
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
			this.txtMaDuAn = new System.Windows.Forms.TextBox();
			this.txtTenDuAn = new System.Windows.Forms.TextBox();
			this.txtGiaTri = new System.Windows.Forms.TextBox();
			this.txtTrangThai = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dpNgayBatDau = new System.Windows.Forms.DateTimePicker();
			this.btnThem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMaDuAn
			// 
			this.txtMaDuAn.Location = new System.Drawing.Point(213, 37);
			this.txtMaDuAn.Name = "txtMaDuAn";
			this.txtMaDuAn.Size = new System.Drawing.Size(100, 20);
			this.txtMaDuAn.TabIndex = 0;
			// 
			// txtTenDuAn
			// 
			this.txtTenDuAn.Location = new System.Drawing.Point(213, 92);
			this.txtTenDuAn.Name = "txtTenDuAn";
			this.txtTenDuAn.Size = new System.Drawing.Size(100, 20);
			this.txtTenDuAn.TabIndex = 1;
			// 
			// txtGiaTri
			// 
			this.txtGiaTri.Location = new System.Drawing.Point(213, 158);
			this.txtGiaTri.Name = "txtGiaTri";
			this.txtGiaTri.Size = new System.Drawing.Size(100, 20);
			this.txtGiaTri.TabIndex = 2;
			// 
			// txtTrangThai
			// 
			this.txtTrangThai.Location = new System.Drawing.Point(213, 271);
			this.txtTrangThai.Name = "txtTrangThai";
			this.txtTrangThai.Size = new System.Drawing.Size(100, 20);
			this.txtTrangThai.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(81, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã dự án:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tên dự án:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(81, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Giá trị";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(81, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ngày bắt đầu:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(81, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Trạng thái";
			// 
			// dpNgayBatDau
			// 
			this.dpNgayBatDau.Location = new System.Drawing.Point(213, 220);
			this.dpNgayBatDau.Name = "dpNgayBatDau";
			this.dpNgayBatDau.Size = new System.Drawing.Size(200, 20);
			this.dpNgayBatDau.TabIndex = 10;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(224, 335);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 11;
			this.btnThem.Text = "Thêm ";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// Admin_FormThemDuAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dpNgayBatDau);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTrangThai);
			this.Controls.Add(this.txtGiaTri);
			this.Controls.Add(this.txtTenDuAn);
			this.Controls.Add(this.txtMaDuAn);
			this.Name = "Admin_FormThemDuAn";
			this.Text = "Admin_FormThemDuAn";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMaDuAn;
		private System.Windows.Forms.TextBox txtTenDuAn;
		private System.Windows.Forms.TextBox txtGiaTri;
		private System.Windows.Forms.TextBox txtTrangThai;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dpNgayBatDau;
		private System.Windows.Forms.Button btnThem;
	}
}