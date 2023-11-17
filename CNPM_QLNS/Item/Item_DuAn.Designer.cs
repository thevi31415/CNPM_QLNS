namespace CNPM_QLNS.Item
{
	partial class Item_DuAn
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
			this.lblTenDuAn = new System.Windows.Forms.Label();
			this.lblMaDA = new System.Windows.Forms.Label();
			this.btnXoaDuAn = new System.Windows.Forms.Button();
			this.picAvatar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTenDuAn
			// 
			this.lblTenDuAn.AutoSize = true;
			this.lblTenDuAn.BackColor = System.Drawing.Color.Transparent;
			this.lblTenDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenDuAn.ForeColor = System.Drawing.Color.White;
			this.lblTenDuAn.Location = new System.Drawing.Point(40, 84);
			this.lblTenDuAn.Name = "lblTenDuAn";
			this.lblTenDuAn.Size = new System.Drawing.Size(102, 25);
			this.lblTenDuAn.TabIndex = 82;
			this.lblTenDuAn.Text = "lblTenDA";
			// 
			// lblMaDA
			// 
			this.lblMaDA.AutoSize = true;
			this.lblMaDA.BackColor = System.Drawing.Color.Transparent;
			this.lblMaDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaDA.ForeColor = System.Drawing.Color.White;
			this.lblMaDA.Location = new System.Drawing.Point(34, 31);
			this.lblMaDA.Name = "lblMaDA";
			this.lblMaDA.Size = new System.Drawing.Size(108, 38);
			this.lblMaDA.TabIndex = 83;
			this.lblMaDA.Text = "MaDA";
			// 
			// btnXoaDuAn
			// 
			this.btnXoaDuAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
			this.btnXoaDuAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnXoaDuAn.FlatAppearance.BorderSize = 0;
			this.btnXoaDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoaDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaDuAn.ForeColor = System.Drawing.Color.White;
			this.btnXoaDuAn.Image = global::CNPM_QLNS.Properties.Resources.trash;
			this.btnXoaDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoaDuAn.Location = new System.Drawing.Point(-1, 155);
			this.btnXoaDuAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnXoaDuAn.Name = "btnXoaDuAn";
			this.btnXoaDuAn.Size = new System.Drawing.Size(460, 36);
			this.btnXoaDuAn.TabIndex = 81;
			this.btnXoaDuAn.Text = "Xóa dự án";
			this.btnXoaDuAn.UseVisualStyleBackColor = false;
			this.btnXoaDuAn.Click += new System.EventHandler(this.btnXoaDuAn_Click);
			// 
			// picAvatar
			// 
			this.picAvatar.Image = global::CNPM_QLNS.Properties.Resources.building__1_;
			this.picAvatar.Location = new System.Drawing.Point(303, 14);
			this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picAvatar.Name = "picAvatar";
			this.picAvatar.Size = new System.Drawing.Size(156, 140);
			this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAvatar.TabIndex = 80;
			this.picAvatar.TabStop = false;
			// 
			// Item_DuAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(453, 183);
			this.Controls.Add(this.lblMaDA);
			this.Controls.Add(this.lblTenDuAn);
			this.Controls.Add(this.btnXoaDuAn);
			this.Controls.Add(this.picAvatar);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Item_DuAn";
			this.Text = "Item_DuAn";
			this.Load += new System.EventHandler(this.Item_DuAn_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_DuAn_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picAvatar;
		private System.Windows.Forms.Button btnXoaDuAn;
		private System.Windows.Forms.Label lblTenDuAn;
		private System.Windows.Forms.Label lblMaDA;
	}
}